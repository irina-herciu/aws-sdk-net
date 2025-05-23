/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.Runtime.CredentialManagement.Internal;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal.Settings;
using Amazon.Runtime.Internal.UserAgent;
using Amazon.Util;
using Amazon.Util.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Amazon.Runtime.CredentialManagement
{
    /// <summary>
    /// Factory to construct different types of AWSCredentials based on a profile.
    /// </summary>
    public static class AWSCredentialsFactory
    {
        private static HashSet<CredentialProfileType> CallbackProfileTypes = new HashSet<CredentialProfileType>()
            {
                CredentialProfileType.SAMLRoleUserIdentity,
                CredentialProfileType.AssumeRoleExternalMFA,
                CredentialProfileType.AssumeRoleMFA,
                CredentialProfileType.SSO,
            };

        private const string RoleSessionNamePrefix = "aws-dotnet-sdk-session-";

        /// <summary>
        /// Gets the AWSCredentials for this profile if CanCreateAWSCredentials is true
        /// and AWSCredentials can be created.  Throws an exception otherwise.
        ///
        /// See <see cref="CredentialProfileOptions"/> for a list of AWSCredentials returned by this method.
        /// </summary>
        /// <param name="profile">The profile to get AWSCredentials for.</param>
        /// <param name="profileSource">The profile source, for profiles that reference other profiles.</param>
        /// <returns>AWSCredentials for this profile.</returns>
        public static AWSCredentials GetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource)
        {
            return GetAWSCredentials(profile.Name, profileSource, profile.Options, profile.Region, false);
        }

        /// <summary>
        /// Gets the AWSCredentials for this profile if CanCreateAWSCredentials is true
        /// and AWSCredentials can be created.  Throws an exception otherwise.
        ///
        /// See <see cref="CredentialProfileOptions"/> for a list of AWSCredentials returned by this method.
        /// </summary>
        /// <param name="options">The options to get AWSCredentials for.</param>
        /// <param name="profileSource">The profile source, for options that reference other profiles.</param>
        /// <returns>AWSCredentials for the options given.</returns>
        public static AWSCredentials GetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource)
        {
            return GetAWSCredentials(null, profileSource, options, null, false);
        }

        /// <summary>
        /// Gets the AWSCredentials for this profile if CanCreateAWSCredentials is true
        /// and AWSCredentials can be created.  Throws an exception otherwise.
        ///
        /// See <see cref="CredentialProfileOptions"/> for a list of AWSCredentials returned by this method.
        /// </summary>
        /// <param name="profile">The profile to get AWSCredentials for.</param>
        /// <param name="profileSource">The profile source, for profiles that reference other profiles.</param>
        /// <param name="nonCallbackOnly">If true, throw a descriptive exception for any credentials that would not operate as-is.
        /// In other words, any credentials that require programmatic callbacks at runtime.</param>
        /// <returns>AWSCredentials for this profile.</returns>
        public static AWSCredentials GetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource, bool nonCallbackOnly)
        {
            return GetAWSCredentials(profile.Name, profileSource, profile.Options, profile.Region, nonCallbackOnly);
        }

        /// <summary>
        /// Gets the AWSCredentials for this profile if CanCreateAWSCredentials is true
        /// and AWSCredentials can be created.  Throws an exception otherwise.
        ///
        /// See <see cref="CredentialProfileOptions"/> for a list of AWSCredentials returned by this method.
        /// </summary>
        /// <param name="options">The options to get AWSCredentials for.</param>
        /// <param name="profileSource">The profile source, for options that reference other profiles.</param>
        /// <param name="nonCallbackOnly">If true, throw a descriptive exception for any credentials that would not operate as-is.
        /// In other words, any credentials that require programmatic callbacks at runtime.</param>
        /// <returns>AWSCredentials for the options given.</returns>
        public static AWSCredentials GetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource, bool nonCallbackOnly)
        {
            return GetAWSCredentials(null, profileSource, options, null, nonCallbackOnly);
        }

        /// <summary>
        /// Return the credentials for the profile if valid credentials can created.
        /// </summary>
        /// <param name="profile">The profile to create credentials with.</param>
        /// <param name="profileSource">The profile source, for profiles that reference other profiles.</param>
        /// <param name="credentials">The credentials for the profile.</param>
        /// <returns>True if credentials can be created from the profile, false otherwise.</returns>
        public static bool TryGetAWSCredentials(CredentialProfile profile, ICredentialProfileSource profileSource, out AWSCredentials credentials)
        {
            credentials = GetAWSCredentialsInternal(profile.Name, profile.ProfileType, profile.Options, profile.Region, profileSource, false);
            return credentials != null;
        }

        /// <summary>
        /// Return the credentials for the profile if valid credentials can created.
        /// </summary>
        /// <param name="options">The options to get AWSCredentials for.</param>
        /// <param name="profileSource">The profile source, for profiles that reference other profiles.</param>
        /// <param name="credentials">The credentials for the profile.</param>
        /// <returns>True if credentials can be created from the profile, false otherwise.</returns>
        public static bool TryGetAWSCredentials(CredentialProfileOptions options, ICredentialProfileSource profileSource, out AWSCredentials credentials)
        {
            var profileType = CredentialProfileTypeDetector.DetectProfileType(options);
            credentials = GetAWSCredentialsInternal(null, profileType, options, null, profileSource, false);
            return credentials != null;
        }

        /// <summary>
        /// Determine if the profileType will generate AWSCredentials that require a callback to be set on them.
        /// </summary>
        /// <param name="profileType"></param>
        /// <returns></returns>
        internal static bool IsCallbackRequired(CredentialProfileType? profileType)
        {
            return profileType.HasValue && CallbackProfileTypes.Contains(profileType.Value);
        }

        private static AWSCredentials GetAWSCredentials(
            string profileName, 
            ICredentialProfileSource profileSource,
            CredentialProfileOptions options, 
            RegionEndpoint stsRegion, 
            bool nonCallbackOnly)
        {
            var ssoTokenFileCache = new SSOTokenFileCache(
                CryptoUtilFactory.CryptoInstance,
                new FileRetriever(),
                new DirectoryRetriever());

            var profileType = CredentialProfileTypeDetector.DetectProfileType(options);
            if (nonCallbackOnly && profileType.HasValue && IsCallbackRequired(profileType.Value))
            {
                if (profileType == CredentialProfileType.AssumeRoleExternalMFA ||
                    profileType == CredentialProfileType.AssumeRoleMFA)
                {
                    var mfaMessage = profileName == null
                        ? "The credential options represent AssumeRoleAWSCredentials that require an MFA.  This is not allowed here.  " +
                            "Please use credential options for AssumeRoleAWSCredentials that don't require an MFA, or a different type of credentials."
                        : String.Format(CultureInfo.InvariantCulture,
                            "The profile [{0}] is an assume role profile that requires an MFA.  This type of profile is not allowed here.  " +
                            "Please use an assume role profile that doesn't require an MFA, or a different type of profile.", profileName);
                    throw new InvalidOperationException(mfaMessage);
                }
                else if (profileType == CredentialProfileType.SSO && !ssoTokenFileCache.Exists(options))
                {
                    var ssoMessage = profileName == null
                        ? $"The credential options represent {nameof(SSOAWSCredentials)}.  This is not allowed here.  " +
                          "Please use a different type of credentials."
                        : String.Format(CultureInfo.InvariantCulture,
                            "The profile [{0}] is an SSO profile.  This type of profile is not allowed here.  " +
                            "Please use a different type of profile.", profileName);
                    throw new InvalidOperationException(ssoMessage);
                }
                else if (profileType == CredentialProfileType.SAMLRoleUserIdentity)
                {
                    var samlMessage = profileName == null
                        ? "The credential options represent FederatedAWSCredentials that specify a user identity.  This is not allowed here.  " +
                            "Please use credential options for FederatedAWSCredentials without an explicit user identity, or a different type of credentials."
                        : String.Format(CultureInfo.InvariantCulture,
                            "The profile [{0}] is a SAML role profile that specifies a user identity.  This type of profile is not allowed here.  " +
                            "Please use a SAML role profile without an explicit user identity, or a different type of profile.", profileName);
                    throw new InvalidOperationException(samlMessage);
                }
            }
            return GetAWSCredentialsInternal(profileName, profileType, options, stsRegion, profileSource, true);
        }

        private static AWSCredentials GetAWSCredentialsInternal(
            string profileName,
            CredentialProfileType? profileType,
            CredentialProfileOptions options,
            RegionEndpoint stsRegion,
            ICredentialProfileSource profileSource,
            bool throwIfInvalid,
            HashSet<string> profileLoopAvoidance = null)
        {
            if (profileType.HasValue)
            {
                AWSCredentials awsCredentials = null;
                switch (profileType)
                {
                    case CredentialProfileType.Basic:
                        awsCredentials = new BasicAWSCredentials(options.AccessKey, options.SecretKey, options.AwsAccountId);

                        // CREDENTIALS_PROFILE already implies static credentials so we can remove the redundant CREDENTIALS_CODE feature ID.
                        awsCredentials.FeatureIdSources.Remove(UserAgentFeatureId.CREDENTIALS_CODE);
                        awsCredentials.FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_PROFILE);
                        break;
                    case CredentialProfileType.Session:
                        awsCredentials = new SessionAWSCredentials(options.AccessKey, options.SecretKey, options.Token, options.AwsAccountId);
                        break;
                    case CredentialProfileType.AssumeRole:
                    case CredentialProfileType.AssumeRoleExternal:
                    case CredentialProfileType.AssumeRoleMFA:
                    case CredentialProfileType.AssumeRoleExternalMFA:
                    case CredentialProfileType.AssumeRoleSessionName:
                    case CredentialProfileType.AssumeRoleExternalSessionName:
                    case CredentialProfileType.AssumeRoleMFASessionName:
                    case CredentialProfileType.AssumeRoleExternalMFASessionName:
                        if (profileName != null)
                        {
                            if (profileLoopAvoidance == null)
                            {
                                profileLoopAvoidance = new HashSet<string>();
                            }
                            else if (profileLoopAvoidance.Contains(profileName))
                            {
                                var sourceMessage = string.Format(CultureInfo.InvariantCulture,
                                   "Error reading profile [{0}]: the source profile definition is cyclical.", profileName);
                                return ThrowOrReturnNull(sourceMessage, null, throwIfInvalid);
                            }
                            profileLoopAvoidance.Add(profileName);
                        }

                        AWSCredentials sourceCredentials;
                        try
                        {
                            sourceCredentials = GetSourceAWSCredentials(options.SourceProfile, profileSource, throwIfInvalid, profileLoopAvoidance);
                        }
                        catch (InvalidDataException e)
                        {
                            var sourceMessage = profileName == null
                               ? string.Format(CultureInfo.InvariantCulture,
                                   "Error reading source profile [{0}] for the credential options provided.", options.SourceProfile)
                               : string.Format(CultureInfo.InvariantCulture,
                                   "Error reading source profile [{0}] for profile [{1}].", options.SourceProfile, profileName);
                            return ThrowOrReturnNull(sourceMessage, e, throwIfInvalid);
                        }

                        var roleSessionName = options.RoleSessionName ?? RoleSessionNamePrefix + AWSSDKUtils.CorrectedUtcNow.Ticks;
                        var assumeRoleOptions = new AssumeRoleAWSCredentialsOptions()
                        {
                            ExternalId = options.ExternalID,
                            MfaSerialNumber = options.MfaSerial
                        };

                        awsCredentials = new AssumeRoleAWSCredentials(sourceCredentials, options.RoleArn, roleSessionName, assumeRoleOptions);
                        awsCredentials.FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_PROFILE_SOURCE_PROFILE);
                        break;

                    case CredentialProfileType.AssumeRoleCredentialSource:
                    case CredentialProfileType.AssumeRoleCredentialSourceSessionName:
                        // get credentials specified by credentialSource
                        try
                        {
                            sourceCredentials = GetCredentialSourceAWSCredentials(options.CredentialSource, throwIfInvalid);
                        }
                        catch (InvalidDataException e)
                        {
                            var sourceMessage = profileName == null
                               ? string.Format(CultureInfo.InvariantCulture,
                                   "Error reading credential source [{0}] for the credential options provided.", options.CredentialSource)
                               : string.Format(CultureInfo.InvariantCulture,
                                   "Error reading credential source [{0}] for profile [{1}].", options.CredentialSource, profileName);
                            return ThrowOrReturnNull(sourceMessage, e, throwIfInvalid);
                        }

                        roleSessionName = options.RoleSessionName ?? RoleSessionNamePrefix + AWSSDKUtils.CorrectedUtcNow.Ticks;
                        assumeRoleOptions = new AssumeRoleAWSCredentialsOptions();

                        awsCredentials = new AssumeRoleAWSCredentials(sourceCredentials, options.RoleArn, roleSessionName, assumeRoleOptions);
                        awsCredentials.FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_PROFILE_NAMED_PROVIDER);
                        break;

                    case CredentialProfileType.AssumeRoleWithWebIdentity:
                    case CredentialProfileType.AssumeRoleWithWebIdentitySessionName:
                        awsCredentials = new AssumeRoleWithWebIdentityCredentials(options.WebIdentityTokenFile, options.RoleArn, options.RoleSessionName);
                        awsCredentials.FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_PROFILE_STS_WEB_ID_TOKEN);
                        break;

                    case CredentialProfileType.SSO:
                        var ssoCredentialsOptions = new SSOAWSCredentialsOptions
                        {
                            SessionName = options.SsoSession,
                            Scopes = options.SsoRegistrationScopes?.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToList()
                        };

                        var isLegacyFormat = string.IsNullOrEmpty(options.SsoSession);
                        awsCredentials = new SSOAWSCredentials(options.SsoAccountId, options.SsoRegion, options.SsoRoleName, options.SsoStartUrl, ssoCredentialsOptions);
                        awsCredentials.FeatureIdSources.Add(isLegacyFormat ? UserAgentFeatureId.CREDENTIALS_PROFILE_SSO_LEGACY : UserAgentFeatureId.CREDENTIALS_PROFILE_SSO);
                        break;

                    case CredentialProfileType.SAMLRole:
                    case CredentialProfileType.SAMLRoleUserIdentity:
                        if (UserCrypto.IsUserCryptAvailable)
                        {
                            var federatedOptions = new FederatedAWSCredentialsOptions()
                            {
                                STSRegion = stsRegion,
                                UserIdentity = options.UserIdentity,
                                ProfileName = profileName
                            };
                            awsCredentials = new FederatedAWSCredentials(new SAMLEndpointManager().GetEndpoint(options.EndpointName),
                                options.RoleArn, federatedOptions);
                            break;
                        }
                        else
                        {
                            return ThrowOrReturnNull("Federated credentials are not available on this platform.", null, throwIfInvalid);
                        }
                    case CredentialProfileType.CredentialProcess:
                        awsCredentials = new ProcessAWSCredentials(options.CredentialProcess, options.AwsAccountId);
                        awsCredentials.FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_PROFILE_PROCESS);
                        break;

                    default:
                        var defaultMessage = profileName == null
                            ? string.Format(CultureInfo.InvariantCulture,
                                "Invalid ProfileType {0} for the credential options provided.", profileType)
                            : string.Format(CultureInfo.InvariantCulture,
                                "Invalid ProfileType {0} for credential profile [{1}].", profileType, profileName);

                        return ThrowOrReturnNull(defaultMessage, null, throwIfInvalid);
                }

                if (profileSource is NetSDKCredentialsFile)
                    awsCredentials.FeatureIdSources.Add(UserAgentFeatureId.CREDENTIALS_AWS_SDK_STORE);

                return awsCredentials;
            }
            else
            {
                return ThrowInvalidOrReturnNull(profileName, throwIfInvalid);
            }
        }

        private static AWSCredentials GetCredentialSourceAWSCredentials(string credentialSourceType, bool throwIfInvalid)
        {

            AWSCredentials credentials;
            CredentialSourceType type;
            try
            {
                type = (CredentialSourceType)Enum.Parse(typeof(CredentialSourceType), credentialSourceType, true);
            }
            catch
            {
                return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                            "Credential source [{0}] is invalid.", credentialSourceType), null, throwIfInvalid);
            }

            switch (type)
            {
                case CredentialSourceType.Ec2InstanceMetadata:
                    credentials = DefaultInstanceProfileAWSCredentials.Instance;
                    break;
                case CredentialSourceType.Environment:
                    credentials = new EnvironmentVariablesAWSCredentials();
                    break;
                case CredentialSourceType.EcsContainer:
                    var relativeUri = Environment.GetEnvironmentVariable(GenericContainerCredentials.RelativeURIEnvVariable);
                    var fullUri = Environment.GetEnvironmentVariable(GenericContainerCredentials.FullURIEnvVariable);

                    if (string.IsNullOrEmpty(relativeUri) && string.IsNullOrEmpty(fullUri))
                    {
                        return ThrowOrReturnNull($"Cannot fetch credentials from container - neither {GenericContainerCredentials.RelativeURIEnvVariable} or {GenericContainerCredentials.FullURIEnvVariable}" +
                                                 " environment variables are set.", null, throwIfInvalid);
                    }

                    credentials = new GenericContainerCredentials();
                    break;
                default:
                    return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                            "Credential source [{0}] is not implemented.", credentialSourceType), null, throwIfInvalid);
            }

            return credentials;
        }

        private static AWSCredentials GetSourceAWSCredentials(string sourceProfileName,
            ICredentialProfileSource profileSource, bool throwIfInvalid, HashSet<string> profileLoopAvoidance = null)
        {
            CredentialProfile sourceProfile = null;
            if (profileSource.TryGetProfile(sourceProfileName, out sourceProfile))
            {
                if (sourceProfile.CanCreateAWSCredentials)
                {
                    var sourceCredentials = GetAWSCredentialsInternal(sourceProfile.Name, sourceProfile.ProfileType, sourceProfile.Options, sourceProfile.Region, profileSource, throwIfInvalid, profileLoopAvoidance);
                    if (sourceCredentials == null)
                    {
                        return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                            "Could not get credentials from source profile [{0}].", sourceProfileName), null, throwIfInvalid);
                    }
                    return sourceCredentials;
                }
                else
                {
                    return ThrowInvalidOrReturnNull(sourceProfileName, throwIfInvalid);
                }
            }
            else
            {
                return ThrowOrReturnNull(string.Format(CultureInfo.InvariantCulture,
                    "Source profile [{0}] was not found.", sourceProfileName), null, throwIfInvalid);
            }

        }

        private static BasicAWSCredentials ThrowInvalidOrReturnNull(string profileName, bool doThrow)
        {
            var message = profileName == null
                ? "The credential options provided are not valid.  Please ensure the options contain a valid combination of properties."
                : string.Format(CultureInfo.InvariantCulture,
                    "Credential profile [{0}] is not valid.  Please ensure the profile contains a valid combination of properties.", profileName);
            return ThrowOrReturnNull(message, null, doThrow);
        }

        private static BasicAWSCredentials ThrowOrReturnNull(string message, Exception innerException, bool doThrow)
        {
            if (doThrow)
            {
                throw new InvalidDataException(message, innerException);
            }
            else
            {
                return null;
            }
        }
    }
}
