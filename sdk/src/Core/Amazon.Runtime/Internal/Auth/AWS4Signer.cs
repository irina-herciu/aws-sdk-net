﻿/*
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using Amazon.Util;
using Amazon.Runtime.Internal.Util;
using Amazon.Runtime.Endpoints;
using ThirdParty.RuntimeBackports;
using Amazon.Runtime.Identity;

namespace Amazon.Runtime.Internal.Auth
{
    /// <summary>
    /// AWS4 protocol signer for service calls that transmit authorization in the header field "Authorization".
    /// </summary>
    public class AWS4Signer : AbstractAWSSigner
    {
        
        public const string Scheme = "AWS4";
        public const string Algorithm = "HMAC-SHA256";
        public const string Sigv4aAlgorithm = "ECDSA-P256-SHA256";

        public const string AWS4AlgorithmTag = Scheme + "-" + Algorithm;
        public const string AWS4aAlgorithmTag = Scheme + "-" + Sigv4aAlgorithm;

        public const string Terminator = "aws4_request";
        public static readonly byte[] TerminatorBytes = Encoding.UTF8.GetBytes(Terminator);

        public const string Credential = "Credential";
        public const string SignedHeaders = "SignedHeaders";
        public const string Signature = "Signature";

        public const string EmptyBodySha256 = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";
        public const string StreamingBodySha256 = "STREAMING-AWS4-HMAC-SHA256-PAYLOAD";
        public const string StreamingBodySha256WithTrailer = "STREAMING-AWS4-HMAC-SHA256-PAYLOAD-TRAILER";
        public const string V4aStreamingBodySha256 = "STREAMING-AWS4-ECDSA-P256-SHA256-PAYLOAD";
        public const string V4aStreamingBodySha256WithTrailer = "STREAMING-AWS4-ECDSA-P256-SHA256-PAYLOAD-TRAILER";
        public const string AWSChunkedEncoding = "aws-chunked";

        public const string UnsignedPayload = "UNSIGNED-PAYLOAD";
        public const string UnsignedPayloadWithTrailer = "STREAMING-UNSIGNED-PAYLOAD-TRAILER";

        internal const SigningAlgorithm SignerAlgorithm = SigningAlgorithm.HmacSHA256;

        // If this list is updated to include new headers, the SigV4a signer (in "AWSSDK.Extensions.CrtIntegration\CrtAWS4aSigner.cs") may need to
        // be updated as well.
        private static IEnumerable<string> _headersToIgnoreWhenSigning = new HashSet<string>(StringComparer.OrdinalIgnoreCase) {
            HeaderKeys.XAmznTraceIdHeader,
            HeaderKeys.TransferEncodingHeader,
            HeaderKeys.AmzSdkInvocationId,
            HeaderKeys.AmzSdkRequest
        };

        public AWS4Signer()
            : this(true)
        {
        }

        public AWS4Signer(bool signPayload)
        {
            SignPayload = signPayload;
        }

        public bool SignPayload
        {
            get;
            private set;
        }

        public override ClientProtocol Protocol
        {
            get { return ClientProtocol.RestProtocol; }
        }

        /// <summary>
        /// Calculates and signs the specified request using the AWS4 signing protocol by using the
        /// AWS account credentials given in the method parameters. The resulting signature is added
        /// to the request headers as 'Authorization'. Parameters supplied in the request, either in
        /// the resource path as a query string or in the Parameters collection must not have been
        /// uri encoded. If they have, use the SignRequest method to obtain a signature.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4 protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="identity">
        /// The AWS credentials for the account making the service call.
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        public override void Sign(IRequest request, 
                                  IClientConfig clientConfig, 
                                  RequestMetrics metrics,
                                  BaseIdentity identity)
        {
            if (identity is not AWSCredentials credentials)
            {
                throw new AmazonClientException($"The identity parameter must be of type AWSCredentials for the signer {nameof(AWS4Signer)}.");
            }

            var immutableCredentials = credentials.GetCredentials();
            if (immutableCredentials is null)
            {
                return;
            }

            var signingResult = SignRequest(request, clientConfig, metrics, immutableCredentials.AccessKey, immutableCredentials.SecretKey);
            request.AWS4SignerResult = signingResult;
            request.Headers[HeaderKeys.AuthorizationHeader] = signingResult.ForAuthorizationHeader;
        }

        /// <inheritdoc/>
        public override IEventSigner CreateEventSigner(BaseIdentity identity, string region, string service, string requestSignature)
        {
            if (identity is not AWSCredentials credentials)
            {
                throw new AmazonClientException($"The identity parameter must be of type AWSCredentials for the signer {nameof(AWS4Signer)}.");
            }

            return new AWS4EventSigner(credentials, region, service, requestSignature);
        }

        /// <summary>
        /// Calculates and signs the specified request using the AWS4 signing protocol by using the
        /// AWS account credentials given in the method parameters.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4 protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Client configuration data encompassing the service call (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request.
        /// </param>
        /// <param name="awsAccessKeyId">
        /// The AWS public key for the account making the service call.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// The AWS secret key for the account making the call, in clear text.
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        /// <remarks>
        /// Parameters passed as part of the resource path should be uri-encoded prior to
        /// entry to the signer. Parameters passed in the request.Parameters collection should
        /// be not be encoded; encoding will be done for these parameters as part of the 
        /// construction of the canonical request.
        /// </remarks>
        public AWS4SigningResult SignRequest(IRequest request,
                                             IClientConfig clientConfig,
                                             RequestMetrics metrics,
                                             string awsAccessKeyId,
                                             string awsSecretAccessKey)
        {
            ValidateRequest(request);
            var signedAt = InitializeHeaders(request.Headers, request.Endpoint);
            
            var serviceSigningName = !string.IsNullOrEmpty(request.OverrideSigningServiceName) 
                ? request.OverrideSigningServiceName 
                : DetermineService(clientConfig, request);

            if (serviceSigningName == "s3")
            {
                // Older versions of the S3 package can be used with newer versions of Core, this guarantees no double encoding will be used.
                // The new behavior uses endpoint resolution rules, which are not present prior to 3.7.100
                request.UseDoubleEncoding = false;
            }

            request.DeterminedSigningRegion = DetermineSigningRegion(clientConfig, clientConfig.RegionEndpointServiceName, request.AlternateEndpoint, request);
            SetXAmzTrailerHeader(request.Headers, request.TrailingHeaders);

            var parametersToCanonicalize = GetParametersToCanonicalize(request);
            var canonicalParameters = CanonicalizeQueryParameters(parametersToCanonicalize);

            // If the request should use a fixed x-amz-content-sha256 header value, determine the appropriate one
            var bodySha = request.TrailingHeaders?.Count > 0
                ? StreamingBodySha256WithTrailer
                : StreamingBodySha256;

            var bodyHash = SetRequestBodyHash(request, SignPayload, bodySha, ChunkedUploadWrapperStream.V4_SIGNATURE_LENGTH);
            var sortedHeaders = SortAndPruneHeaders(request.Headers);

            var canonicalRequest = CanonicalizeRequest(request.Endpoint,
                                                       request.ResourcePath,
                                                       request.HttpMethod,
                                                       sortedHeaders,
                                                       canonicalParameters,
                                                       bodyHash,
                                                       request.PathResources,
                                                       request.UseDoubleEncoding);
            if (metrics != null)
                metrics.AddProperty(Metric.CanonicalRequest, canonicalRequest);
            request.SignatureVersion = SignatureVersion.SigV4;
            return ComputeSignature(awsAccessKeyId,
                                    awsSecretAccessKey,
                                    request.DeterminedSigningRegion,
                                    signedAt,
                                    serviceSigningName,
                                    CanonicalizeHeaderNames(sortedHeaders),
                                    canonicalRequest,
                                    metrics);
        }

        #region Public Signing Helpers

        /// <summary>
        /// Sets the AWS4 mandated 'host' and 'x-amz-date' headers, returning the date/time that will
        /// be used throughout the signing process in various elements and formats.
        /// </summary>
        /// <param name="headers">The current set of headers</param>
        /// <param name="requestEndpoint"></param>
        /// <returns>Date and time used for x-amz-date, in UTC</returns>
        public static DateTime InitializeHeaders(IDictionary<string, string> headers, Uri requestEndpoint)
        {
            return InitializeHeaders(headers, requestEndpoint, CorrectClockSkew.GetCorrectedUtcNowForEndpoint(requestEndpoint.ToString()));
        }

        /// <summary>
        /// Sets the AWS4 mandated 'host' and 'x-amz-date' headers, accepting and returning the date/time that will
        /// be used throughout the signing process in various elements and formats.
        /// </summary>
        /// <param name="headers">The current set of headers</param>
        /// <param name="requestEndpoint"></param>
        /// <param name="requestDateTime"></param>
        /// <returns>Date and time used for x-amz-date, in UTC</returns>
        public static DateTime InitializeHeaders(IDictionary<string, string> headers, Uri requestEndpoint, DateTime requestDateTime)
        {
            // clean up any prior signature in the headers if resigning
            CleanHeaders(headers);

            if (!headers.ContainsKey(HeaderKeys.HostHeader))
            {
                var hostHeader = requestEndpoint.Host;
                if (!requestEndpoint.IsDefaultPort)
                    hostHeader += ":" + requestEndpoint.Port;
                headers.Add(HeaderKeys.HostHeader, hostHeader);
            }

            var dt = requestDateTime;
            headers[HeaderKeys.XAmzDateHeader] = dt.ToUniversalTime().ToString(AWSSDKUtils.ISO8601BasicDateTimeFormat, CultureInfo.InvariantCulture);

            return dt;
        }

        /// <summary>
        /// Sets the x-amz-trailer header for the given set of trailing headers
        /// </summary>
        /// <param name="headers">request's headers</param>
        /// <param name="trailingHeaders">request's trailing headers</param>
        public static void SetXAmzTrailerHeader(IDictionary<string, string> headers, IDictionary<string, string> trailingHeaders)
        {
            if (trailingHeaders == null || trailingHeaders.Count == 0)
            {
                return;
            }

            // The x-amz-trailer HTTP header MUST be set with the value as comma-separated
            // string consisting of trailing header names in the order they are written on the HTTP request.
            headers[HeaderKeys.XAmzTrailerHeader] = string.Join(",", trailingHeaders.Keys.OrderBy(key => key).ToArray());
        }

        private static void CleanHeaders(IDictionary<string, string> headers)
        {
            headers.Remove(HeaderKeys.AuthorizationHeader);
            headers.Remove(HeaderKeys.XAmzContentSha256Header);

            if (headers.TryGetValue(HeaderKeys.XAmzDecodedContentLengthHeader, out string decodedContentLength))
            {
                headers[HeaderKeys.ContentLengthHeader] = decodedContentLength;
                headers.Remove(HeaderKeys.XAmzDecodedContentLengthHeader);
            }
        }

        private static void ValidateRequest(IRequest request)
        {
            Uri url = request.Endpoint;

            // Before we sign the request, we need to validate if the request is being 
            // sent over https when DisablePayloadSigning is true.
            if((request.DisablePayloadSigning ?? false) && url.Scheme != "https")
            {
                throw new AmazonClientException("When DisablePayloadSigning is true, the request must be sent over HTTPS.");
            }
        }

        /// <summary>
        /// Computes and returns an AWS4 signature for the specified canonicalized request
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="region"></param>
        /// <param name="signedAt"></param>
        /// <param name="service"></param>
        /// <param name="signedHeaders"></param>
        /// <param name="canonicalRequest"></param>
        /// <returns></returns>
        public static AWS4SigningResult ComputeSignature(ImmutableCredentials credentials,
                                                         string region,
                                                         DateTime signedAt,
                                                         string service,
                                                         string signedHeaders,
                                                         string canonicalRequest)
        {
            return ComputeSignature(credentials.AccessKey,
                                    credentials.SecretKey,
                                    region,
                                    signedAt,
                                    service,
                                    signedHeaders,
                                    canonicalRequest);
        }

        /// <summary>
        /// Computes and returns an AWS4 signature for the specified canonicalized request
        /// </summary>
        /// <param name="awsAccessKey"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="region"></param>
        /// <param name="signedAt"></param>
        /// <param name="service"></param>
        /// <param name="signedHeaders"></param>
        /// <param name="canonicalRequest"></param>
        /// <returns></returns>
        public static AWS4SigningResult ComputeSignature(string awsAccessKey,
                                                         string awsSecretAccessKey,
                                                         string region,
                                                         DateTime signedAt,
                                                         string service,
                                                         string signedHeaders,
                                                         string canonicalRequest)
        {
            return ComputeSignature(awsAccessKey, awsSecretAccessKey, region, signedAt, service, signedHeaders, canonicalRequest, null);
        }

        /// <summary>
        /// Computes and returns an AWS4 signature for the specified canonicalized request
        /// </summary>
        /// <param name="awsAccessKey"></param>
        /// <param name="awsSecretAccessKey"></param>
        /// <param name="region"></param>
        /// <param name="signedAt"></param>
        /// <param name="service"></param>
        /// <param name="signedHeaders"></param>
        /// <param name="canonicalRequest"></param>
        /// <param name="metrics"></param>
        /// <returns></returns>
        public static AWS4SigningResult ComputeSignature(string awsAccessKey,
                                                         string awsSecretAccessKey,
                                                         string region,
                                                         DateTime signedAt,
                                                         string service,
                                                         string signedHeaders,
                                                         string canonicalRequest,
                                                         RequestMetrics metrics)
        {
            var dateStamp = FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateFormat);
            var scope = string.Format(CultureInfo.InvariantCulture, "{0}/{1}/{2}/{3}", dateStamp, region, service, Terminator);

            var stringToSignBuilder = new StringBuilder();
            stringToSignBuilder.AppendFormat(CultureInfo.InvariantCulture, "{0}-{1}\n{2}\n{3}\n",
                                      Scheme,
                                      Algorithm,
                                      FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateTimeFormat),
                                      scope);

            var canonicalRequestHashBytes = ComputeHash(canonicalRequest);
            stringToSignBuilder.Append(AWSSDKUtils.ToHex(canonicalRequestHashBytes, true));

            if (metrics != null)
                metrics.AddProperty(Metric.StringToSign, stringToSignBuilder);

            var key = ComposeSigningKey(awsSecretAccessKey,
                                        region,
                                        dateStamp,
                                        service);

            var stringToSign = stringToSignBuilder.ToString();
            var signature = ComputeKeyedHash(SignerAlgorithm, key, stringToSign);
            return new AWS4SigningResult(awsAccessKey, signedAt, signedHeaders, scope, key, signature);
        }

        /// <summary>
        /// Formats the supplied date and time for use in AWS4 signing, where various formats are used.
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="formatString">The required format</param>
        /// <returns>The UTC date/time in the requested format</returns>
        public static string FormatDateTime(DateTime dt, string formatString)
        {
            return dt.ToUniversalTime().ToString(formatString, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Compute and return the multi-stage signing key for the request.
        /// </summary>
        /// <param name="awsSecretAccessKey">The clear-text AWS secret key, if not held in secureKey</param>
        /// <param name="region">The region in which the service request will be processed</param>
        /// <param name="date">Date of the request, in yyyyMMdd format</param>
        /// <param name="service">The name of the service being called by the request</param>
        /// <returns>Computed signing key</returns>
        public static byte[] ComposeSigningKey(string awsSecretAccessKey, string region, string date, string service)
        {
            char[] ksecret = null;

            try
            {
                ksecret = (Scheme + awsSecretAccessKey).ToCharArray();

                var hashDate = ComputeKeyedHash(SignerAlgorithm, Encoding.UTF8.GetBytes(ksecret), Encoding.UTF8.GetBytes(date));
                var hashRegion = ComputeKeyedHash(SignerAlgorithm, hashDate, Encoding.UTF8.GetBytes(region));
                var hashService = ComputeKeyedHash(SignerAlgorithm, hashRegion, Encoding.UTF8.GetBytes(service));
                return ComputeKeyedHash(SignerAlgorithm, hashService, TerminatorBytes);
            }
            finally
            {
                // clean up all secrets, regardless of how initially seeded (for simplicity)
                if (ksecret != null)
                    Array.Clear(ksecret, 0, ksecret.Length);
            }
        }

        /// <summary>
        /// If the caller has already set the x-amz-content-sha256 header with a pre-computed
        /// content hash, or it is present as ContentStreamHash on the request instance, return
        /// the value to be used in request canonicalization. 
        /// If not set as a header or in the request, attempt to compute a hash based on
        /// inspection of the style of the request content.
        /// </summary>
        /// <param name="request">Request to sign</param>
        /// <param name="chunkedBodyHash">The fixed value to set for the x-amz-content-sha256 header for chunked requests</param>
        /// <param name="signatureLength">Length of the signature for each chunk in a chuncked request, in bytes</param>
        /// <returns>
        /// The computed hash, whether already set in headers or computed here. Null
        /// if we were not able to compute a hash.
        /// </returns>
        public static string SetRequestBodyHash(IRequest request, string chunkedBodyHash, int signatureLength)
        {
            return SetRequestBodyHash(request, true, chunkedBodyHash, signatureLength);
        }

        /// <summary>
        /// If signPayload is false set the x-amz-content-sha256 header to
        /// the UNSIGNED-PAYLOAD magic string and return it.
        /// Otherwise, if the caller has already set the x-amz-content-sha256 header with a pre-computed
        /// content hash, or it is present as ContentStreamHash on the request instance, return
        /// the value to be used in request canonicalization.
        /// If not set as a header or in the request, attempt to compute a hash based on
        /// inspection of the style of the request content.
        /// </summary>
        /// <param name="request">Request to sign</param>
        /// <param name="signPayload">Whether to sign the payload</param>
        /// <param name="chunkedBodyHash">The fixed value to set for the x-amz-content-sha256 header for chunked requests</param>
        /// <param name="signatureLength">Length of the signature for each chunk in a chuncked request, in bytes</param>
        /// <returns>
        /// The computed hash, whether already set in headers or computed here. Null
        /// if we were not able to compute a hash.
        /// </returns>
        public static string SetRequestBodyHash(IRequest request, bool signPayload, string chunkedBodyHash, int signatureLength)
        {
            // If unsigned payload, set the appropriate magic string in the header and return it
            if (request.DisablePayloadSigning != null ? request.DisablePayloadSigning.Value : !signPayload)
            {
                if (request.TrailingHeaders?.Count > 0)
                {
                    // Set X-Amz-Decoded-Content-Length with the true size of the data
                    request.Headers[HeaderKeys.XAmzDecodedContentLengthHeader] = request.Headers[HeaderKeys.ContentLengthHeader];

                    // Substitute the originally declared content length with the inflated length due to trailing headers
                    var originalContentLength = long.Parse(request.Headers[HeaderKeys.ContentLengthHeader], CultureInfo.InvariantCulture);
                    request.Headers[HeaderKeys.ContentLengthHeader]
                        = TrailingHeadersWrapperStream.CalculateLength(request.TrailingHeaders, request.SelectedChecksum, originalContentLength).ToString(CultureInfo.InvariantCulture);

                    SetContentEncodingHeader(request);

                    return SetPayloadSignatureHeader(request, UnsignedPayloadWithTrailer);
                }
                else // request does not have trailing headers (and is still unsigned payload)
                {
                    return SetPayloadSignatureHeader(request, UnsignedPayload);
                }
            }

            // if the body hash has been precomputed and already placed in the header, just extract and return it
            string computedContentHash;
            var shaHeaderPresent = request.Headers.TryGetValue(HeaderKeys.XAmzContentSha256Header, out computedContentHash);
            if (shaHeaderPresent && !request.UseChunkEncoding)
                return computedContentHash;

            // otherwise continue to calculate the hash and set it in the headers before returning
            if (request.UseChunkEncoding)
            {
                computedContentHash = chunkedBodyHash;

                if (request.Headers.TryGetValue(HeaderKeys.ContentLengthHeader, out string contentLength))
                {
                    // Set X-Amz-Decoded-Content-Length with the true size of the data
                    request.Headers[HeaderKeys.XAmzDecodedContentLengthHeader] = contentLength;

                    // Substitute the originally declared content length with the inflated length due to chunking metadata and/or trailing headers
                    var originalContentLength = long.Parse(contentLength, CultureInfo.InvariantCulture);
                    request.Headers[HeaderKeys.ContentLengthHeader]
                        = ChunkedUploadWrapperStream.ComputeChunkedContentLength(originalContentLength, signatureLength, request.TrailingHeaders, request.SelectedChecksum).ToString(CultureInfo.InvariantCulture);
                }

                SetContentEncodingHeader(request);
            }
            else
            {
                if (request.ContentStream != null)
                    computedContentHash = request.ComputeContentStreamHash();
                else
                {
                    byte[] payloadBytes = AWSSDKUtils.GetRequestPayloadBytes(request, request.UseQueryString);
                    byte[] payloadHashBytes = CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(payloadBytes);
                    computedContentHash = AWSSDKUtils.ToHex(payloadHashBytes, true);
                }
            }


            // set the header if needed and return it
            return SetPayloadSignatureHeader(request, computedContentHash ?? UnsignedPayload);
        }

        /// <summary>
        /// Appends "aws-chunked" to the Content-Encoding header if it's already set
        /// </summary>
        /// <param name="request">Request to modify</param>
        private static void SetContentEncodingHeader(IRequest request)
        {
            if (request.Headers.TryGetValue(HeaderKeys.ContentEncodingHeader, out var originalEncoding) &&
                !originalEncoding.Contains(AWSChunkedEncoding))
            {
                request.Headers[HeaderKeys.ContentEncodingHeader] = $"{originalEncoding}, {AWSChunkedEncoding}";
            }
        }

        /// <summary>
        /// Returns the HMAC256 for an arbitrary blob using the specified key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] SignBlob(byte[] key, string data)
        {
            return SignBlob(key, Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// Returns the HMAC256 for an arbitrary blob using the specified key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] SignBlob(byte[] key, byte[] data)
        {
            return CryptoUtilFactory.CryptoInstance.HMACSignBinary(data, key, SignerAlgorithm);
        }

        /// <summary>
        /// Compute and return the hash of a data blob using the specified key
        /// </summary>
        /// <param name="algorithm">Algorithm to use for hashing</param>
        /// <param name="key">Hash key</param>
        /// <param name="data">Data blob</param>
        /// <returns>Hash of the data</returns>
        public static byte[] ComputeKeyedHash(SigningAlgorithm algorithm, byte[] key, string data)
        {
            return ComputeKeyedHash(algorithm, key, Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// Compute and return the hash of a data blob using the specified key
        /// </summary>
        /// <param name="algorithm">Algorithm to use for hashing</param>
        /// <param name="key">Hash key</param>
        /// <param name="data">Data blob</param>
        /// <returns>Hash of the data</returns>
        public static byte[] ComputeKeyedHash(SigningAlgorithm algorithm, byte[] key, byte[] data)
        {
            return CryptoUtilFactory.CryptoInstance.HMACSignBinary(data, key, algorithm);
        }

        /// <summary>
        /// Computes the non-keyed hash of the supplied data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] ComputeHash(string data)
        {
            return ComputeHash(Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// Computes the non-keyed hash of the supplied data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] ComputeHash(byte[] data)
        {
            return CryptoUtilFactory.CryptoInstance.ComputeSHA256Hash(data);
        }

        #endregion

        #region Private Signing Helpers
        static string SetPayloadSignatureHeader(IRequest request, string payloadHash)
        {
            if (request.Headers.ContainsKey(HeaderKeys.XAmzContentSha256Header))
                request.Headers[HeaderKeys.XAmzContentSha256Header] = payloadHash;
            else
                request.Headers.Add(HeaderKeys.XAmzContentSha256Header, payloadHash);

            return payloadHash;
        }

        public static string DetermineSigningRegion(IClientConfig clientConfig, 
                                                    string serviceName, 
                                                    RegionEndpoint alternateEndpoint,
                                                    IRequest request)
        {
            // Alternate endpoint (IRequest.AlternateEndpoint) takes precedence over
            // client config properties.
            if (alternateEndpoint != null)
            {
                return alternateEndpoint.SystemName;
            }

            string authenticationRegion = clientConfig.AuthenticationRegion;
            // We always have request.AuthenticationRegion defined, as per 
            // Amazon.Runtime.Internal.BaseEndpointResolver implementation.
            // request.AuthenticationRegion value is set either based on endpoint rules or
            // overriden by clientConfig.AuthenticationRegion if defined.
            // Normally, users should only override clientConfig.AuthenticationRegion value for non-AWS services
            if (request != null && request.AuthenticationRegion != null)
                authenticationRegion = request.AuthenticationRegion;

            if (!string.IsNullOrEmpty(authenticationRegion))
                return authenticationRegion.ToLowerInvariant();

            if (!string.IsNullOrEmpty(clientConfig.ServiceURL))
            {
                var parsedRegion = AWSSDKUtils.DetermineRegion(clientConfig.ServiceURL);
                if (!string.IsNullOrEmpty(parsedRegion))
                    return parsedRegion.ToLowerInvariant();
            }

            var endpoint = clientConfig.RegionEndpoint;
            if (endpoint != null)
            {
                return endpoint.SystemName; 
            }

            return string.Empty;
        }

        public static string DetermineService(IClientConfig clientConfig, IRequest request)
        {
            if ((!string.IsNullOrEmpty(clientConfig.AuthenticationServiceName)))
                return clientConfig.AuthenticationServiceName;

            var parameters = new ServiceOperationEndpointParameters(request.OriginalRequest);
            var endpoint = clientConfig.DetermineServiceOperationEndpoint(parameters);

            return AWSSDKUtils.DetermineService(endpoint.URL);
        }

        /// <summary>
        /// Computes and returns the canonical request
        /// </summary>
        /// <param name="endpoint">The endpoint URL</param>
        /// <param name="resourcePath">the path of the resource being operated on</param>
        /// <param name="httpMethod">The http method used for the request</param>
        /// <param name="sortedHeaders">The full request headers, sorted into canonical order</param>
        /// <param name="canonicalQueryString">The query parameters for the request</param>
        /// <param name="precomputedBodyHash">
        /// The hash of the binary request body if present. If not supplied, the routine
        /// will look for the hash as a header on the request.
        /// </param>
        /// <returns>Canonicalised request as a string</returns>
        protected static string CanonicalizeRequest(Uri endpoint,
                                                    string resourcePath,
                                                    string httpMethod,
                                                    IDictionary<string, string> sortedHeaders,
                                                    string canonicalQueryString,
                                                    string precomputedBodyHash)
        {
            return CanonicalizeRequest(endpoint, resourcePath, httpMethod, sortedHeaders, canonicalQueryString, precomputedBodyHash, null);
        }

        /// <summary>
        /// Computes and returns the canonical request
        /// </summary>
        /// <param name="endpoint">The endpoint URL</param>
        /// <param name="resourcePath">the path of the resource being operated on</param>
        /// <param name="httpMethod">The http method used for the request</param>
        /// <param name="sortedHeaders">The full request headers, sorted into canonical order</param>
        /// <param name="canonicalQueryString">The query parameters for the request</param>
        /// <param name="precomputedBodyHash">
        /// <param name="pathResources">The path resource values lookup to use to replace the keys within resourcePath</param>
        /// The hash of the binary request body if present. If not supplied, the routine
        /// will look for the hash as a header on the request.
        /// </param>
        /// <returns>Canonicalised request as a string</returns>
        protected static string CanonicalizeRequest(Uri endpoint,
                                                    string resourcePath,
                                                    string httpMethod,
                                                    IDictionary<string, string> sortedHeaders,
                                                    string canonicalQueryString,
                                                    string precomputedBodyHash,
                                                    IDictionary<string, string> pathResources)
        {
            return CanonicalizeRequestHelper(endpoint,
                resourcePath,
                httpMethod,
                sortedHeaders,
                canonicalQueryString,
                precomputedBodyHash,
                pathResources,
                true);
        }

        /// <summary>
        /// Computes and returns the canonical request
        /// </summary>
        /// <param name="endpoint">The endpoint URL</param>
        /// <param name="resourcePath">the path of the resource being operated on</param>
        /// <param name="httpMethod">The http method used for the request</param>
        /// <param name="sortedHeaders">The full request headers, sorted into canonical order</param>
        /// <param name="canonicalQueryString">The query parameters for the request</param>
        /// <param name="precomputedBodyHash">
        /// <param name="pathResources">The path resource values lookup to use to replace the keys within resourcePath</param>
        /// The hash of the binary request body if present. If not supplied, the routine
        /// will look for the hash as a header on the request.
        /// </param>
        /// <param name="doubleEncode">Encode "/" when canonicalize resource path</param>
        /// <returns>Canonicalised request as a string</returns>
        protected static string CanonicalizeRequest(Uri endpoint,
                                                    string resourcePath,
                                                    string httpMethod,
                                                    IDictionary<string, string> sortedHeaders,
                                                    string canonicalQueryString,
                                                    string precomputedBodyHash,
                                                    IDictionary<string, string> pathResources,
                                                    bool doubleEncode)
        {
            return CanonicalizeRequestHelper(endpoint,
                resourcePath,
                httpMethod,
                sortedHeaders,
                canonicalQueryString,
                precomputedBodyHash,
                pathResources,
                doubleEncode);
        }

        private static string CanonicalizeRequestHelper(Uri endpoint,
                                                    string resourcePath,
                                                    string httpMethod,
                                                    IDictionary<string, string> sortedHeaders,
                                                    string canonicalQueryString,
                                                    string precomputedBodyHash,
                                                    IDictionary<string, string> pathResources,
                                                    bool doubleEncode)
        {
            var canonicalRequest = new ValueStringBuilder(512);
            canonicalRequest.Append(httpMethod);
            canonicalRequest.Append('\n');
            canonicalRequest.Append($"{AWSSDKUtils.CanonicalizeResourcePathV2(endpoint, resourcePath, doubleEncode, pathResources)}\n");
            canonicalRequest.Append($"{canonicalQueryString}\n");

            canonicalRequest.Append($"{CanonicalizeHeaders(sortedHeaders)}\n");
            canonicalRequest.Append($"{CanonicalizeHeaderNames(sortedHeaders)}\n");

            if (precomputedBodyHash != null)
            {
                canonicalRequest.Append(precomputedBodyHash);
            }
            else
            {
                if (sortedHeaders.TryGetValue(HeaderKeys.XAmzContentSha256Header, out var contentHash))
                    canonicalRequest.Append(contentHash);
            }

            return canonicalRequest.ToString();
        }

        /// <summary>
        /// Reorders the headers for the request for canonicalization.
        /// </summary>
        /// <param name="requestHeaders">The set of proposed headers for the request</param>
        /// <returns>List of headers that must be included in the signature</returns>
        /// <remarks>For AWS4 signing, all headers are considered viable for inclusion</remarks>
        protected internal static IDictionary<string, string> SortAndPruneHeaders(IEnumerable<KeyValuePair<string, string>> requestHeaders)
        {
            // Refer https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html. (Step #4: "Build the canonical headers list by sorting the (lowercase) headers by character code"). StringComparer.OrdinalIgnoreCase incorrectly places '_' after lowercase chracters.
            var sortedHeaders = new SortedDictionary<string, string>(StringComparer.Ordinal);
            foreach (var header in requestHeaders)
            {
                if (_headersToIgnoreWhenSigning.Contains(header.Key))
                {
                    continue;
                }
                sortedHeaders.Add(header.Key.ToLowerInvariant(), header.Value);
            }
            
            return sortedHeaders;
        }

        /// <summary>
        /// Computes the canonical headers with values for the request. Only headers included in the signature
        /// are included in the canonicalization process.
        /// </summary>
        /// <param name="sortedHeaders">All request headers, sorted into canonical order</param>
        /// <returns>Canonicalized string of headers, with the header names in lower case.</returns>
        protected internal static string CanonicalizeHeaders(IEnumerable<KeyValuePair<string, string>> sortedHeaders)
        {
            if (sortedHeaders == null)
                return string.Empty;

            // Majority of the cases we will always have a IDictionary<string, string> for headers which implements ICollection<KeyValuePair<string, string>>.
            var materializedSortedHeaders = sortedHeaders as ICollection<KeyValuePair<string, string>> ?? sortedHeaders.ToList();
            if (materializedSortedHeaders.Count == 0)
                return string.Empty;

            var builder = new ValueStringBuilder(512);
            foreach (var entry in materializedSortedHeaders)
            {
                // Refer https://docs.aws.amazon.com/general/latest/gr/sigv4-create-canonical-request.html. (Step #4: "To create the canonical headers list, convert all header names to lowercase and remove leading spaces and trailing spaces. Convert sequential spaces in the header value to a single space.").
                builder.Append(entry.Key.ToLowerInvariant());
                builder.Append(':');
                builder.Append(AWSSDKUtils.CompressSpaces(entry.Value)?.Trim());
                builder.Append("\n");
            }
            return builder.ToString();
        }

        /// <summary>
        /// Returns the set of headers included in the signature as a flattened, ;-delimited string
        /// </summary>
        /// <param name="sortedHeaders">The headers included in the signature</param>
        /// <returns>Formatted string of header names</returns>
        protected static string CanonicalizeHeaderNames(IEnumerable<KeyValuePair<string, string>> sortedHeaders)
        {
            var builder = new ValueStringBuilder(512);

            foreach (var header in sortedHeaders)
            {
                if (builder.Length > 0)
                    builder.Append(';');
                builder.Append(header.Key.ToLowerInvariant());
            }

            return builder.ToString();
        }

        /// <summary>
        /// Collects the subresource and query string parameters into one collection
        /// ready for canonicalization
        /// </summary>
        /// <param name="request">The in-flight request being signed</param>
        /// <returns>The fused set of parameters</returns>
        protected static List<KeyValuePair<string, string>> GetParametersToCanonicalize(IRequest request)
        {
            var parametersToCanonicalize = new List<KeyValuePair<string, string>>();

            if (request.SubResources != null && request.SubResources.Count > 0)
            {
                foreach (var subResource in request.SubResources)
                {
                    parametersToCanonicalize.Add(new KeyValuePair<string,string>(subResource.Key, subResource.Value));
                }
            }

            if (request.UseQueryString && request.Parameters != null && request.Parameters.Count > 0)
            {
                var requestParameters = request.ParameterCollection.GetSortedParametersList();
                foreach (var queryParameter in requestParameters.Where(queryParameter => queryParameter.Value != null))
                {
                    parametersToCanonicalize.Add(new KeyValuePair<string,string>(queryParameter.Key, queryParameter.Value));
                }
            }

            return parametersToCanonicalize;
        }

        protected static string CanonicalizeQueryParameters(string queryString)
        {
            return CanonicalizeQueryParameters(queryString, true);
        }

        /// <summary>
        /// Computes and returns the canonicalized query string, if query parameters have been supplied.
        /// Parameters with no value will be canonicalized as 'param='. The expectation is that parameters
        /// have not already been url encoded prior to canonicalization.
        /// </summary>
        /// <param name="queryString">The set of parameters being passed on the uri</param>
        /// <param name="uriEncodeParameters">
        /// Parameters must be uri encoded into the canonical request and by default the signer expects
        /// that the supplied collection contains non-encoded data. Set this to false if the encoding was
        /// done prior to signer entry.
        /// </param>
        /// <returns>The uri encoded query string parameters in canonical ordering</returns>
        protected static string CanonicalizeQueryParameters(string queryString, bool uriEncodeParameters)
        {
            if (string.IsNullOrEmpty(queryString))
                return string.Empty;

            var queryParams = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            var queryParamsStart = queryString.IndexOf('?');
            var qs = queryString.Substring(++queryParamsStart); 
            var subStringPos = 0;
            var index = qs.IndexOfAny(new char[] { '&', ';' }, 0);
            if (index == -1 && subStringPos < qs.Length)
                index = qs.Length;
            while (index != -1)
            {
                var token = qs.Substring(subStringPos, index - subStringPos);

                // If the next character is a space then this isn't the end of query string value
                // Content Disposition is an example of this.
                if (!(index + 1 < qs.Length && qs[index + 1] == ' '))
                {
                    var equalPos = token.IndexOf('=');
                    if (equalPos == -1)
                        queryParams.Add(token, null);
                    else
                        queryParams.Add(token.Substring(0, equalPos), token.Substring(equalPos + 1));

                    subStringPos = index + 1;
                }

                if (qs.Length <= index + 1)
                    break;

                index = qs.IndexOfAny(new char[] { '&', ';' }, index + 1);
                if (index == -1 && subStringPos < qs.Length)
                    index = qs.Length;
            }

            return CanonicalizeQueryParameters(queryParams, uriEncodeParameters: uriEncodeParameters);
        }

        protected static string CanonicalizeQueryParameters(IEnumerable<KeyValuePair<string, string>> parameters)
        {
            return CanonicalizeQueryParameters(parameters, true);
        }
        /// <summary>
        /// Computes and returns the canonicalized query string, if query parameters have been supplied.
        /// Parameters with no value will be canonicalized as 'param='. The expectation is that parameters
        /// have not already been url encoded prior to canonicalization.
        /// </summary>
        /// <param name="parameters">The set of parameters to be encoded in the query string</param>
        /// <param name="uriEncodeParameters">
        /// Parameters must be uri encoded into the canonical request and by default the signer expects
        /// that the supplied collection contains non-encoded data. Set this to false if the encoding was
        /// done prior to signer entry.
        /// </param>
        /// <returns>The uri encoded query string parameters in canonical ordering</returns>
        protected static string CanonicalizeQueryParameters(
            IEnumerable<KeyValuePair<string, string>> parameters,
            bool uriEncodeParameters)
        {
            if (parameters == null)
                return string.Empty;

            var sortedParameters = parameters.OrderBy(kvp => kvp.Key, StringComparer.Ordinal).ToList();
            var canonicalQueryString = new StringBuilder();
            foreach (var param in sortedParameters)
            {
                var key = param.Key;
                var value = param.Value;

                if (canonicalQueryString.Length > 0)
                    canonicalQueryString.Append("&");
                if (uriEncodeParameters)
                {
                    if (string.IsNullOrEmpty(value))
                        canonicalQueryString.AppendFormat("{0}=", AWSSDKUtils.UrlEncode(key, false));
                    else
                        canonicalQueryString.AppendFormat("{0}={1}", AWSSDKUtils.UrlEncode(key, false), AWSSDKUtils.UrlEncode(value, false));
                }
                else
                {
                    if (string.IsNullOrEmpty(value))
                        canonicalQueryString.AppendFormat("{0}=", key);
                    else
                        canonicalQueryString.AppendFormat("{0}={1}", key, value);
                }
            }

            return canonicalQueryString.ToString();
        }

        #endregion
    }

    /// <summary>
    /// AWS4 protocol signer for Amazon S3 presigned urls.
    /// </summary>
    public class AWS4PreSignedUrlSigner : AWS4Signer
    {
        // 7 days is the maximum period for presigned url expiry with AWS4
        public const Int64 MaxAWS4PreSignedUrlExpiry = 7 * 24 * 60 * 60;

        public static readonly IEnumerable<string> ServicesUsingUnsignedPayload = new HashSet<string>()
        {
            "s3",
            "s3-object-lambda",
            "s3-outposts",
            "s3express"
        };


        /// <summary>
        /// Calculates and signs the specified request using the AWS4 signing protocol by using the
        /// AWS account credentials given in the method parameters. The resulting signature is added
        /// to the request headers as 'Authorization'.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4 protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Adding supporting data for the service call required by the signer (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="identity">
        /// The AWS credentials for the account making the service call.
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        public override void Sign(IRequest request,
                                  IClientConfig clientConfig,
                                  RequestMetrics metrics,
                                  BaseIdentity identity)
        {
            throw new InvalidOperationException("PreSignedUrl signature computation is not supported by this method; use SignRequest instead.");
        }

        /// <summary>
        /// Calculates the AWS4 signature for a presigned url.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4 protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing. If the Expires parameter
        /// is present, it is renamed to 'X-Amz-Expires' before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Adding supporting data for the service call required by the signer (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="awsAccessKeyId">
        /// The AWS public key for the account making the service call.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// The AWS secret key for the account making the call, in clear text
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        /// <remarks>
        /// Parameters passed as part of the resource path should be uri-encoded prior to
        /// entry to the signer. Parameters passed in the request.Parameters collection should
        /// be not be encoded; encoding will be done for these parameters as part of the 
        /// construction of the canonical request.
        /// </remarks>
        public new AWS4SigningResult SignRequest(IRequest request,
                                                 IClientConfig clientConfig,
                                                 RequestMetrics metrics,
                                                 string awsAccessKeyId,
                                                 string awsSecretAccessKey)
        {
            var service = "s3";
            if (!string.IsNullOrEmpty(request.OverrideSigningServiceName))
                service = request.OverrideSigningServiceName;
            return SignRequest(request, clientConfig, metrics, awsAccessKeyId, awsSecretAccessKey, service, null);
        }

        /// <summary>
        /// Calculates the AWS4 signature for a presigned url.
        /// </summary>
        /// <param name="request">
        /// The request to compute the signature for. Additional headers mandated by the AWS4 protocol 
        /// ('host' and 'x-amz-date') will be added to the request before signing. If the Expires parameter
        /// is present, it is renamed to 'X-Amz-Expires' before signing.
        /// </param>
        /// <param name="clientConfig">
        /// Adding supporting data for the service call required by the signer (notably authentication
        /// region, endpoint and service name).
        /// </param>
        /// <param name="metrics">
        /// Metrics for the request
        /// </param>
        /// <param name="awsAccessKeyId">
        /// The AWS public key for the account making the service call.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// The AWS secret key for the account making the call, in clear text
        /// </param>
        /// <param name="service">
        /// The service to sign for
        /// </param>
        /// <param name="overrideSigningRegion">
        /// The region to sign to, if null then the region the client is configured for will be used.
        /// </param>
        /// <exception cref="Amazon.Runtime.SignatureException">
        /// If any problems are encountered while signing the request.
        /// </exception>
        /// <remarks>
        /// Parameters passed as part of the resource path should be uri-encoded prior to
        /// entry to the signer. Parameters passed in the request.Parameters collection should
        /// be not be encoded; encoding will be done for these parameters as part of the 
        /// construction of the canonical request.
        ///
        /// The X-Amz-Content-SHA256 is cleared out of the request.
        /// If the request is for S3 then the UNSIGNED_PAYLOAD value is used to generate the canonical request.
        /// If the request isn't for S3 then the empty body SHA is used to generate the canonical request.
        /// </remarks>
        public static AWS4SigningResult SignRequest(IRequest request,
                                                 IClientConfig clientConfig,
                                                 RequestMetrics metrics,
                                                 string awsAccessKeyId,
                                                 string awsSecretAccessKey,
                                                 string service,
                                                 string overrideSigningRegion)
        {
            if (service == "s3" || service == "s3express")
            {
                // Older versions of the S3 package can be used with newer versions of Core, this guarantees no double encoding will be used.
                // The new behavior uses endpoint resolution rules, which are not present prior to 3.7.100
                request.UseDoubleEncoding = false;
            }

            // clean up any prior signature in the headers if resigning
            request.Headers.Remove(HeaderKeys.AuthorizationHeader);
            if (!request.Headers.ContainsKey(HeaderKeys.HostHeader))
            {
                var hostHeader = request.Endpoint.Host;
                if (!request.Endpoint.IsDefaultPort)
                    hostHeader += ":" + request.Endpoint.Port;
                request.Headers.Add(HeaderKeys.HostHeader, hostHeader);
            }

            var signedAt = CorrectClockSkew.GetCorrectedUtcNowForEndpoint(request.Endpoint.ToString());
            request.SignedAt = signedAt;
            var region = overrideSigningRegion ?? DetermineSigningRegion(clientConfig, clientConfig.RegionEndpointServiceName, request.AlternateEndpoint, request);

            // AWS4 presigned urls got S3 are expected to contain a 'UNSIGNED-PAYLOAD' magic string
            // during signing (other services use the empty-body sha)
            if (request.Headers.ContainsKey(HeaderKeys.XAmzContentSha256Header))
                request.Headers.Remove(HeaderKeys.XAmzContentSha256Header);

            var sortedHeaders = SortAndPruneHeaders(request.Headers);
            var canonicalizedHeaderNames = CanonicalizeHeaderNames(sortedHeaders);

            var parametersToCanonicalize = GetParametersToCanonicalize(request);
            parametersToCanonicalize.Add(new KeyValuePair<string,string>(HeaderKeys.XAmzAlgorithm, AWS4AlgorithmTag));
            var xAmzCredentialValue = string.Format(CultureInfo.InvariantCulture, "{0}/{1}/{2}/{3}/{4}",
                                                       awsAccessKeyId,
                                                       FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateFormat),
                                                       region,
                                                       service,
                                                       Terminator);
            parametersToCanonicalize.Add(new KeyValuePair<string,string>(HeaderKeys.XAmzCredential, xAmzCredentialValue));

            parametersToCanonicalize.Add(new KeyValuePair<string,string>(HeaderKeys.XAmzDateHeader, FormatDateTime(signedAt, AWSSDKUtils.ISO8601BasicDateTimeFormat)));
            parametersToCanonicalize.Add(new KeyValuePair<string,string>(HeaderKeys.XAmzSignedHeadersHeader, canonicalizedHeaderNames));

            var canonicalQueryParams = CanonicalizeQueryParameters(parametersToCanonicalize);

            var canonicalRequest = CanonicalizeRequest(request.Endpoint,
                                                       request.ResourcePath,
                                                       request.HttpMethod,
                                                       sortedHeaders,
                                                       canonicalQueryParams,
                                                       ServicesUsingUnsignedPayload.Contains(service) ? UnsignedPayload : EmptyBodySha256,
                                                       request.PathResources,
                                                       request.UseDoubleEncoding);
            if (metrics != null)
                metrics.AddProperty(Metric.CanonicalRequest, canonicalRequest);

            return ComputeSignature(awsAccessKeyId,
                                    awsSecretAccessKey,
                                    region,
                                    signedAt,
                                    service,
                                    canonicalizedHeaderNames,
                                    canonicalRequest,
                                    metrics);
        }
    }
}
