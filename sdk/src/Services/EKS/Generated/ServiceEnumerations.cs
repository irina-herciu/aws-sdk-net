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

/*
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.EKS
{

    /// <summary>
    /// Constants used for properties of type AccessScopeType.
    /// </summary>
    public class AccessScopeType : ConstantClass
    {

        /// <summary>
        /// Constant Cluster for AccessScopeType
        /// </summary>
        public static readonly AccessScopeType Cluster = new AccessScopeType("cluster");
        /// <summary>
        /// Constant Namespace for AccessScopeType
        /// </summary>
        public static readonly AccessScopeType Namespace = new AccessScopeType("namespace");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AccessScopeType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AccessScopeType FindValue(string value)
        {
            return FindValue<AccessScopeType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AccessScopeType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AddonIssueCode.
    /// </summary>
    public class AddonIssueCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode AccessDenied = new AddonIssueCode("AccessDenied");
        /// <summary>
        /// Constant AddonPermissionFailure for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode AddonPermissionFailure = new AddonIssueCode("AddonPermissionFailure");
        /// <summary>
        /// Constant AddonSubscriptionNeeded for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode AddonSubscriptionNeeded = new AddonIssueCode("AddonSubscriptionNeeded");
        /// <summary>
        /// Constant AdmissionRequestDenied for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode AdmissionRequestDenied = new AddonIssueCode("AdmissionRequestDenied");
        /// <summary>
        /// Constant ClusterUnreachable for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode ClusterUnreachable = new AddonIssueCode("ClusterUnreachable");
        /// <summary>
        /// Constant ConfigurationConflict for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode ConfigurationConflict = new AddonIssueCode("ConfigurationConflict");
        /// <summary>
        /// Constant InsufficientNumberOfReplicas for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode InsufficientNumberOfReplicas = new AddonIssueCode("InsufficientNumberOfReplicas");
        /// <summary>
        /// Constant InternalFailure for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode InternalFailure = new AddonIssueCode("InternalFailure");
        /// <summary>
        /// Constant K8sResourceNotFound for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode K8sResourceNotFound = new AddonIssueCode("K8sResourceNotFound");
        /// <summary>
        /// Constant UnsupportedAddonModification for AddonIssueCode
        /// </summary>
        public static readonly AddonIssueCode UnsupportedAddonModification = new AddonIssueCode("UnsupportedAddonModification");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddonIssueCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddonIssueCode FindValue(string value)
        {
            return FindValue<AddonIssueCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddonIssueCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AddonStatus.
    /// </summary>
    public class AddonStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for AddonStatus
        /// </summary>
        public static readonly AddonStatus ACTIVE = new AddonStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for AddonStatus
        /// </summary>
        public static readonly AddonStatus CREATE_FAILED = new AddonStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for AddonStatus
        /// </summary>
        public static readonly AddonStatus CREATING = new AddonStatus("CREATING");
        /// <summary>
        /// Constant DEGRADED for AddonStatus
        /// </summary>
        public static readonly AddonStatus DEGRADED = new AddonStatus("DEGRADED");
        /// <summary>
        /// Constant DELETE_FAILED for AddonStatus
        /// </summary>
        public static readonly AddonStatus DELETE_FAILED = new AddonStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for AddonStatus
        /// </summary>
        public static readonly AddonStatus DELETING = new AddonStatus("DELETING");
        /// <summary>
        /// Constant UPDATE_FAILED for AddonStatus
        /// </summary>
        public static readonly AddonStatus UPDATE_FAILED = new AddonStatus("UPDATE_FAILED");
        /// <summary>
        /// Constant UPDATING for AddonStatus
        /// </summary>
        public static readonly AddonStatus UPDATING = new AddonStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AddonStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AddonStatus FindValue(string value)
        {
            return FindValue<AddonStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AddonStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AMITypes.
    /// </summary>
    public class AMITypes : ConstantClass
    {

        /// <summary>
        /// Constant AL2_ARM_64 for AMITypes
        /// </summary>
        public static readonly AMITypes AL2_ARM_64 = new AMITypes("AL2_ARM_64");
        /// <summary>
        /// Constant AL2_x86_64 for AMITypes
        /// </summary>
        public static readonly AMITypes AL2_x86_64 = new AMITypes("AL2_x86_64");
        /// <summary>
        /// Constant AL2_x86_64_GPU for AMITypes
        /// </summary>
        public static readonly AMITypes AL2_x86_64_GPU = new AMITypes("AL2_x86_64_GPU");
        /// <summary>
        /// Constant AL2023_ARM_64_NVIDIA for AMITypes
        /// </summary>
        public static readonly AMITypes AL2023_ARM_64_NVIDIA = new AMITypes("AL2023_ARM_64_NVIDIA");
        /// <summary>
        /// Constant AL2023_ARM_64_STANDARD for AMITypes
        /// </summary>
        public static readonly AMITypes AL2023_ARM_64_STANDARD = new AMITypes("AL2023_ARM_64_STANDARD");
        /// <summary>
        /// Constant AL2023_x86_64_NEURON for AMITypes
        /// </summary>
        public static readonly AMITypes AL2023_x86_64_NEURON = new AMITypes("AL2023_x86_64_NEURON");
        /// <summary>
        /// Constant AL2023_x86_64_NVIDIA for AMITypes
        /// </summary>
        public static readonly AMITypes AL2023_x86_64_NVIDIA = new AMITypes("AL2023_x86_64_NVIDIA");
        /// <summary>
        /// Constant AL2023_x86_64_STANDARD for AMITypes
        /// </summary>
        public static readonly AMITypes AL2023_x86_64_STANDARD = new AMITypes("AL2023_x86_64_STANDARD");
        /// <summary>
        /// Constant BOTTLEROCKET_ARM_64 for AMITypes
        /// </summary>
        public static readonly AMITypes BOTTLEROCKET_ARM_64 = new AMITypes("BOTTLEROCKET_ARM_64");
        /// <summary>
        /// Constant BOTTLEROCKET_ARM_64_FIPS for AMITypes
        /// </summary>
        public static readonly AMITypes BOTTLEROCKET_ARM_64_FIPS = new AMITypes("BOTTLEROCKET_ARM_64_FIPS");
        /// <summary>
        /// Constant BOTTLEROCKET_ARM_64_NVIDIA for AMITypes
        /// </summary>
        public static readonly AMITypes BOTTLEROCKET_ARM_64_NVIDIA = new AMITypes("BOTTLEROCKET_ARM_64_NVIDIA");
        /// <summary>
        /// Constant BOTTLEROCKET_x86_64 for AMITypes
        /// </summary>
        public static readonly AMITypes BOTTLEROCKET_x86_64 = new AMITypes("BOTTLEROCKET_x86_64");
        /// <summary>
        /// Constant BOTTLEROCKET_x86_64_FIPS for AMITypes
        /// </summary>
        public static readonly AMITypes BOTTLEROCKET_x86_64_FIPS = new AMITypes("BOTTLEROCKET_x86_64_FIPS");
        /// <summary>
        /// Constant BOTTLEROCKET_x86_64_NVIDIA for AMITypes
        /// </summary>
        public static readonly AMITypes BOTTLEROCKET_x86_64_NVIDIA = new AMITypes("BOTTLEROCKET_x86_64_NVIDIA");
        /// <summary>
        /// Constant CUSTOM for AMITypes
        /// </summary>
        public static readonly AMITypes CUSTOM = new AMITypes("CUSTOM");
        /// <summary>
        /// Constant WINDOWS_CORE_2019_x86_64 for AMITypes
        /// </summary>
        public static readonly AMITypes WINDOWS_CORE_2019_x86_64 = new AMITypes("WINDOWS_CORE_2019_x86_64");
        /// <summary>
        /// Constant WINDOWS_CORE_2022_x86_64 for AMITypes
        /// </summary>
        public static readonly AMITypes WINDOWS_CORE_2022_x86_64 = new AMITypes("WINDOWS_CORE_2022_x86_64");
        /// <summary>
        /// Constant WINDOWS_FULL_2019_x86_64 for AMITypes
        /// </summary>
        public static readonly AMITypes WINDOWS_FULL_2019_x86_64 = new AMITypes("WINDOWS_FULL_2019_x86_64");
        /// <summary>
        /// Constant WINDOWS_FULL_2022_x86_64 for AMITypes
        /// </summary>
        public static readonly AMITypes WINDOWS_FULL_2022_x86_64 = new AMITypes("WINDOWS_FULL_2022_x86_64");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AMITypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AMITypes FindValue(string value)
        {
            return FindValue<AMITypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AMITypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AuthenticationMode.
    /// </summary>
    public class AuthenticationMode : ConstantClass
    {

        /// <summary>
        /// Constant API for AuthenticationMode
        /// </summary>
        public static readonly AuthenticationMode API = new AuthenticationMode("API");
        /// <summary>
        /// Constant API_AND_CONFIG_MAP for AuthenticationMode
        /// </summary>
        public static readonly AuthenticationMode API_AND_CONFIG_MAP = new AuthenticationMode("API_AND_CONFIG_MAP");
        /// <summary>
        /// Constant CONFIG_MAP for AuthenticationMode
        /// </summary>
        public static readonly AuthenticationMode CONFIG_MAP = new AuthenticationMode("CONFIG_MAP");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AuthenticationMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AuthenticationMode FindValue(string value)
        {
            return FindValue<AuthenticationMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AuthenticationMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CapacityTypes.
    /// </summary>
    public class CapacityTypes : ConstantClass
    {

        /// <summary>
        /// Constant CAPACITY_BLOCK for CapacityTypes
        /// </summary>
        public static readonly CapacityTypes CAPACITY_BLOCK = new CapacityTypes("CAPACITY_BLOCK");
        /// <summary>
        /// Constant ON_DEMAND for CapacityTypes
        /// </summary>
        public static readonly CapacityTypes ON_DEMAND = new CapacityTypes("ON_DEMAND");
        /// <summary>
        /// Constant SPOT for CapacityTypes
        /// </summary>
        public static readonly CapacityTypes SPOT = new CapacityTypes("SPOT");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CapacityTypes(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CapacityTypes FindValue(string value)
        {
            return FindValue<CapacityTypes>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CapacityTypes(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Category.
    /// </summary>
    public class Category : ConstantClass
    {

        /// <summary>
        /// Constant MISCONFIGURATION for Category
        /// </summary>
        public static readonly Category MISCONFIGURATION = new Category("MISCONFIGURATION");
        /// <summary>
        /// Constant UPGRADE_READINESS for Category
        /// </summary>
        public static readonly Category UPGRADE_READINESS = new Category("UPGRADE_READINESS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Category(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Category FindValue(string value)
        {
            return FindValue<Category>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Category(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterIssueCode.
    /// </summary>
    public class ClusterIssueCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode AccessDenied = new ClusterIssueCode("AccessDenied");
        /// <summary>
        /// Constant ClusterUnreachable for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode ClusterUnreachable = new ClusterIssueCode("ClusterUnreachable");
        /// <summary>
        /// Constant ConfigurationConflict for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode ConfigurationConflict = new ClusterIssueCode("ConfigurationConflict");
        /// <summary>
        /// Constant Ec2SecurityGroupNotFound for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode Ec2SecurityGroupNotFound = new ClusterIssueCode("Ec2SecurityGroupNotFound");
        /// <summary>
        /// Constant Ec2ServiceNotSubscribed for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode Ec2ServiceNotSubscribed = new ClusterIssueCode("Ec2ServiceNotSubscribed");
        /// <summary>
        /// Constant Ec2SubnetNotFound for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode Ec2SubnetNotFound = new ClusterIssueCode("Ec2SubnetNotFound");
        /// <summary>
        /// Constant IamRoleNotFound for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode IamRoleNotFound = new ClusterIssueCode("IamRoleNotFound");
        /// <summary>
        /// Constant InsufficientFreeAddresses for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode InsufficientFreeAddresses = new ClusterIssueCode("InsufficientFreeAddresses");
        /// <summary>
        /// Constant InternalFailure for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode InternalFailure = new ClusterIssueCode("InternalFailure");
        /// <summary>
        /// Constant KmsGrantRevoked for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode KmsGrantRevoked = new ClusterIssueCode("KmsGrantRevoked");
        /// <summary>
        /// Constant KmsKeyDisabled for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode KmsKeyDisabled = new ClusterIssueCode("KmsKeyDisabled");
        /// <summary>
        /// Constant KmsKeyMarkedForDeletion for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode KmsKeyMarkedForDeletion = new ClusterIssueCode("KmsKeyMarkedForDeletion");
        /// <summary>
        /// Constant KmsKeyNotFound for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode KmsKeyNotFound = new ClusterIssueCode("KmsKeyNotFound");
        /// <summary>
        /// Constant Other for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode Other = new ClusterIssueCode("Other");
        /// <summary>
        /// Constant ResourceLimitExceeded for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode ResourceLimitExceeded = new ClusterIssueCode("ResourceLimitExceeded");
        /// <summary>
        /// Constant ResourceNotFound for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode ResourceNotFound = new ClusterIssueCode("ResourceNotFound");
        /// <summary>
        /// Constant StsRegionalEndpointDisabled for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode StsRegionalEndpointDisabled = new ClusterIssueCode("StsRegionalEndpointDisabled");
        /// <summary>
        /// Constant UnsupportedVersion for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode UnsupportedVersion = new ClusterIssueCode("UnsupportedVersion");
        /// <summary>
        /// Constant VpcNotFound for ClusterIssueCode
        /// </summary>
        public static readonly ClusterIssueCode VpcNotFound = new ClusterIssueCode("VpcNotFound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterIssueCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterIssueCode FindValue(string value)
        {
            return FindValue<ClusterIssueCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterIssueCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterStatus.
    /// </summary>
    public class ClusterStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus ACTIVE = new ClusterStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus CREATING = new ClusterStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus DELETING = new ClusterStatus("DELETING");
        /// <summary>
        /// Constant FAILED for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus FAILED = new ClusterStatus("FAILED");
        /// <summary>
        /// Constant PENDING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus PENDING = new ClusterStatus("PENDING");
        /// <summary>
        /// Constant UPDATING for ClusterStatus
        /// </summary>
        public static readonly ClusterStatus UPDATING = new ClusterStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterStatus FindValue(string value)
        {
            return FindValue<ClusterStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ClusterVersionStatus.
    /// </summary>
    public class ClusterVersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ExtendedSupport for ClusterVersionStatus
        /// </summary>
        public static readonly ClusterVersionStatus ExtendedSupport = new ClusterVersionStatus("extended-support");
        /// <summary>
        /// Constant StandardSupport for ClusterVersionStatus
        /// </summary>
        public static readonly ClusterVersionStatus StandardSupport = new ClusterVersionStatus("standard-support");
        /// <summary>
        /// Constant Unsupported for ClusterVersionStatus
        /// </summary>
        public static readonly ClusterVersionStatus Unsupported = new ClusterVersionStatus("unsupported");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ClusterVersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ClusterVersionStatus FindValue(string value)
        {
            return FindValue<ClusterVersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ClusterVersionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConfigStatus.
    /// </summary>
    public class ConfigStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for ConfigStatus
        /// </summary>
        public static readonly ConfigStatus ACTIVE = new ConfigStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for ConfigStatus
        /// </summary>
        public static readonly ConfigStatus CREATING = new ConfigStatus("CREATING");
        /// <summary>
        /// Constant DELETING for ConfigStatus
        /// </summary>
        public static readonly ConfigStatus DELETING = new ConfigStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConfigStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConfigStatus FindValue(string value)
        {
            return FindValue<ConfigStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConfigStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ConnectorConfigProvider.
    /// </summary>
    public class ConnectorConfigProvider : ConstantClass
    {

        /// <summary>
        /// Constant AKS for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider AKS = new ConnectorConfigProvider("AKS");
        /// <summary>
        /// Constant ANTHOS for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider ANTHOS = new ConnectorConfigProvider("ANTHOS");
        /// <summary>
        /// Constant EC2 for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider EC2 = new ConnectorConfigProvider("EC2");
        /// <summary>
        /// Constant EKS_ANYWHERE for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider EKS_ANYWHERE = new ConnectorConfigProvider("EKS_ANYWHERE");
        /// <summary>
        /// Constant GKE for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider GKE = new ConnectorConfigProvider("GKE");
        /// <summary>
        /// Constant OPENSHIFT for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider OPENSHIFT = new ConnectorConfigProvider("OPENSHIFT");
        /// <summary>
        /// Constant OTHER for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider OTHER = new ConnectorConfigProvider("OTHER");
        /// <summary>
        /// Constant RANCHER for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider RANCHER = new ConnectorConfigProvider("RANCHER");
        /// <summary>
        /// Constant TANZU for ConnectorConfigProvider
        /// </summary>
        public static readonly ConnectorConfigProvider TANZU = new ConnectorConfigProvider("TANZU");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ConnectorConfigProvider(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ConnectorConfigProvider FindValue(string value)
        {
            return FindValue<ConnectorConfigProvider>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ConnectorConfigProvider(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EksAnywhereSubscriptionLicenseType.
    /// </summary>
    public class EksAnywhereSubscriptionLicenseType : ConstantClass
    {

        /// <summary>
        /// Constant Cluster for EksAnywhereSubscriptionLicenseType
        /// </summary>
        public static readonly EksAnywhereSubscriptionLicenseType Cluster = new EksAnywhereSubscriptionLicenseType("Cluster");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EksAnywhereSubscriptionLicenseType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EksAnywhereSubscriptionLicenseType FindValue(string value)
        {
            return FindValue<EksAnywhereSubscriptionLicenseType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EksAnywhereSubscriptionLicenseType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EksAnywhereSubscriptionStatus.
    /// </summary>
    public class EksAnywhereSubscriptionStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for EksAnywhereSubscriptionStatus
        /// </summary>
        public static readonly EksAnywhereSubscriptionStatus ACTIVE = new EksAnywhereSubscriptionStatus("ACTIVE");
        /// <summary>
        /// Constant CREATING for EksAnywhereSubscriptionStatus
        /// </summary>
        public static readonly EksAnywhereSubscriptionStatus CREATING = new EksAnywhereSubscriptionStatus("CREATING");
        /// <summary>
        /// Constant DELETING for EksAnywhereSubscriptionStatus
        /// </summary>
        public static readonly EksAnywhereSubscriptionStatus DELETING = new EksAnywhereSubscriptionStatus("DELETING");
        /// <summary>
        /// Constant EXPIRED for EksAnywhereSubscriptionStatus
        /// </summary>
        public static readonly EksAnywhereSubscriptionStatus EXPIRED = new EksAnywhereSubscriptionStatus("EXPIRED");
        /// <summary>
        /// Constant EXPIRING for EksAnywhereSubscriptionStatus
        /// </summary>
        public static readonly EksAnywhereSubscriptionStatus EXPIRING = new EksAnywhereSubscriptionStatus("EXPIRING");
        /// <summary>
        /// Constant UPDATING for EksAnywhereSubscriptionStatus
        /// </summary>
        public static readonly EksAnywhereSubscriptionStatus UPDATING = new EksAnywhereSubscriptionStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EksAnywhereSubscriptionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EksAnywhereSubscriptionStatus FindValue(string value)
        {
            return FindValue<EksAnywhereSubscriptionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EksAnywhereSubscriptionStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EksAnywhereSubscriptionTermUnit.
    /// </summary>
    public class EksAnywhereSubscriptionTermUnit : ConstantClass
    {

        /// <summary>
        /// Constant MONTHS for EksAnywhereSubscriptionTermUnit
        /// </summary>
        public static readonly EksAnywhereSubscriptionTermUnit MONTHS = new EksAnywhereSubscriptionTermUnit("MONTHS");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EksAnywhereSubscriptionTermUnit(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EksAnywhereSubscriptionTermUnit FindValue(string value)
        {
            return FindValue<EksAnywhereSubscriptionTermUnit>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EksAnywhereSubscriptionTermUnit(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ErrorCode.
    /// </summary>
    public class ErrorCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for ErrorCode
        /// </summary>
        public static readonly ErrorCode AccessDenied = new ErrorCode("AccessDenied");
        /// <summary>
        /// Constant AdmissionRequestDenied for ErrorCode
        /// </summary>
        public static readonly ErrorCode AdmissionRequestDenied = new ErrorCode("AdmissionRequestDenied");
        /// <summary>
        /// Constant ClusterUnreachable for ErrorCode
        /// </summary>
        public static readonly ErrorCode ClusterUnreachable = new ErrorCode("ClusterUnreachable");
        /// <summary>
        /// Constant ConfigurationConflict for ErrorCode
        /// </summary>
        public static readonly ErrorCode ConfigurationConflict = new ErrorCode("ConfigurationConflict");
        /// <summary>
        /// Constant EniLimitReached for ErrorCode
        /// </summary>
        public static readonly ErrorCode EniLimitReached = new ErrorCode("EniLimitReached");
        /// <summary>
        /// Constant InsufficientFreeAddresses for ErrorCode
        /// </summary>
        public static readonly ErrorCode InsufficientFreeAddresses = new ErrorCode("InsufficientFreeAddresses");
        /// <summary>
        /// Constant InsufficientNumberOfReplicas for ErrorCode
        /// </summary>
        public static readonly ErrorCode InsufficientNumberOfReplicas = new ErrorCode("InsufficientNumberOfReplicas");
        /// <summary>
        /// Constant IpNotAvailable for ErrorCode
        /// </summary>
        public static readonly ErrorCode IpNotAvailable = new ErrorCode("IpNotAvailable");
        /// <summary>
        /// Constant K8sResourceNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode K8sResourceNotFound = new ErrorCode("K8sResourceNotFound");
        /// <summary>
        /// Constant NodeCreationFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode NodeCreationFailure = new ErrorCode("NodeCreationFailure");
        /// <summary>
        /// Constant OperationNotPermitted for ErrorCode
        /// </summary>
        public static readonly ErrorCode OperationNotPermitted = new ErrorCode("OperationNotPermitted");
        /// <summary>
        /// Constant PodEvictionFailure for ErrorCode
        /// </summary>
        public static readonly ErrorCode PodEvictionFailure = new ErrorCode("PodEvictionFailure");
        /// <summary>
        /// Constant SecurityGroupNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode SecurityGroupNotFound = new ErrorCode("SecurityGroupNotFound");
        /// <summary>
        /// Constant SubnetNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode SubnetNotFound = new ErrorCode("SubnetNotFound");
        /// <summary>
        /// Constant Unknown for ErrorCode
        /// </summary>
        public static readonly ErrorCode Unknown = new ErrorCode("Unknown");
        /// <summary>
        /// Constant UnsupportedAddonModification for ErrorCode
        /// </summary>
        public static readonly ErrorCode UnsupportedAddonModification = new ErrorCode("UnsupportedAddonModification");
        /// <summary>
        /// Constant VpcIdNotFound for ErrorCode
        /// </summary>
        public static readonly ErrorCode VpcIdNotFound = new ErrorCode("VpcIdNotFound");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ErrorCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ErrorCode FindValue(string value)
        {
            return FindValue<ErrorCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ErrorCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FargateProfileIssueCode.
    /// </summary>
    public class FargateProfileIssueCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for FargateProfileIssueCode
        /// </summary>
        public static readonly FargateProfileIssueCode AccessDenied = new FargateProfileIssueCode("AccessDenied");
        /// <summary>
        /// Constant ClusterUnreachable for FargateProfileIssueCode
        /// </summary>
        public static readonly FargateProfileIssueCode ClusterUnreachable = new FargateProfileIssueCode("ClusterUnreachable");
        /// <summary>
        /// Constant InternalFailure for FargateProfileIssueCode
        /// </summary>
        public static readonly FargateProfileIssueCode InternalFailure = new FargateProfileIssueCode("InternalFailure");
        /// <summary>
        /// Constant PodExecutionRoleAlreadyInUse for FargateProfileIssueCode
        /// </summary>
        public static readonly FargateProfileIssueCode PodExecutionRoleAlreadyInUse = new FargateProfileIssueCode("PodExecutionRoleAlreadyInUse");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FargateProfileIssueCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FargateProfileIssueCode FindValue(string value)
        {
            return FindValue<FargateProfileIssueCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FargateProfileIssueCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FargateProfileStatus.
    /// </summary>
    public class FargateProfileStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus ACTIVE = new FargateProfileStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus CREATE_FAILED = new FargateProfileStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus CREATING = new FargateProfileStatus("CREATING");
        /// <summary>
        /// Constant DELETE_FAILED for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus DELETE_FAILED = new FargateProfileStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for FargateProfileStatus
        /// </summary>
        public static readonly FargateProfileStatus DELETING = new FargateProfileStatus("DELETING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FargateProfileStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FargateProfileStatus FindValue(string value)
        {
            return FindValue<FargateProfileStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FargateProfileStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InsightStatusValue.
    /// </summary>
    public class InsightStatusValue : ConstantClass
    {

        /// <summary>
        /// Constant ERROR for InsightStatusValue
        /// </summary>
        public static readonly InsightStatusValue ERROR = new InsightStatusValue("ERROR");
        /// <summary>
        /// Constant PASSING for InsightStatusValue
        /// </summary>
        public static readonly InsightStatusValue PASSING = new InsightStatusValue("PASSING");
        /// <summary>
        /// Constant UNKNOWN for InsightStatusValue
        /// </summary>
        public static readonly InsightStatusValue UNKNOWN = new InsightStatusValue("UNKNOWN");
        /// <summary>
        /// Constant WARNING for InsightStatusValue
        /// </summary>
        public static readonly InsightStatusValue WARNING = new InsightStatusValue("WARNING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InsightStatusValue(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InsightStatusValue FindValue(string value)
        {
            return FindValue<InsightStatusValue>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InsightStatusValue(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type IpFamily.
    /// </summary>
    public class IpFamily : ConstantClass
    {

        /// <summary>
        /// Constant Ipv4 for IpFamily
        /// </summary>
        public static readonly IpFamily Ipv4 = new IpFamily("ipv4");
        /// <summary>
        /// Constant Ipv6 for IpFamily
        /// </summary>
        public static readonly IpFamily Ipv6 = new IpFamily("ipv6");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public IpFamily(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static IpFamily FindValue(string value)
        {
            return FindValue<IpFamily>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator IpFamily(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LogType.
    /// </summary>
    public class LogType : ConstantClass
    {

        /// <summary>
        /// Constant Api for LogType
        /// </summary>
        public static readonly LogType Api = new LogType("api");
        /// <summary>
        /// Constant Audit for LogType
        /// </summary>
        public static readonly LogType Audit = new LogType("audit");
        /// <summary>
        /// Constant Authenticator for LogType
        /// </summary>
        public static readonly LogType Authenticator = new LogType("authenticator");
        /// <summary>
        /// Constant ControllerManager for LogType
        /// </summary>
        public static readonly LogType ControllerManager = new LogType("controllerManager");
        /// <summary>
        /// Constant Scheduler for LogType
        /// </summary>
        public static readonly LogType Scheduler = new LogType("scheduler");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LogType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LogType FindValue(string value)
        {
            return FindValue<LogType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LogType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodegroupIssueCode.
    /// </summary>
    public class NodegroupIssueCode : ConstantClass
    {

        /// <summary>
        /// Constant AccessDenied for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AccessDenied = new NodegroupIssueCode("AccessDenied");
        /// <summary>
        /// Constant AmiIdNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AmiIdNotFound = new NodegroupIssueCode("AmiIdNotFound");
        /// <summary>
        /// Constant AsgInstanceLaunchFailures for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AsgInstanceLaunchFailures = new NodegroupIssueCode("AsgInstanceLaunchFailures");
        /// <summary>
        /// Constant AutoScalingGroupInstanceRefreshActive for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AutoScalingGroupInstanceRefreshActive = new NodegroupIssueCode("AutoScalingGroupInstanceRefreshActive");
        /// <summary>
        /// Constant AutoScalingGroupInvalidConfiguration for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AutoScalingGroupInvalidConfiguration = new NodegroupIssueCode("AutoScalingGroupInvalidConfiguration");
        /// <summary>
        /// Constant AutoScalingGroupNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AutoScalingGroupNotFound = new NodegroupIssueCode("AutoScalingGroupNotFound");
        /// <summary>
        /// Constant AutoScalingGroupOptInRequired for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AutoScalingGroupOptInRequired = new NodegroupIssueCode("AutoScalingGroupOptInRequired");
        /// <summary>
        /// Constant AutoScalingGroupRateLimitExceeded for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode AutoScalingGroupRateLimitExceeded = new NodegroupIssueCode("AutoScalingGroupRateLimitExceeded");
        /// <summary>
        /// Constant ClusterUnreachable for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode ClusterUnreachable = new NodegroupIssueCode("ClusterUnreachable");
        /// <summary>
        /// Constant Ec2InstanceTypeDoesNotExist for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2InstanceTypeDoesNotExist = new NodegroupIssueCode("Ec2InstanceTypeDoesNotExist");
        /// <summary>
        /// Constant Ec2LaunchTemplateDeletionFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2LaunchTemplateDeletionFailure = new NodegroupIssueCode("Ec2LaunchTemplateDeletionFailure");
        /// <summary>
        /// Constant Ec2LaunchTemplateInvalidConfiguration for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2LaunchTemplateInvalidConfiguration = new NodegroupIssueCode("Ec2LaunchTemplateInvalidConfiguration");
        /// <summary>
        /// Constant Ec2LaunchTemplateMaxLimitExceeded for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2LaunchTemplateMaxLimitExceeded = new NodegroupIssueCode("Ec2LaunchTemplateMaxLimitExceeded");
        /// <summary>
        /// Constant Ec2LaunchTemplateNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2LaunchTemplateNotFound = new NodegroupIssueCode("Ec2LaunchTemplateNotFound");
        /// <summary>
        /// Constant Ec2LaunchTemplateVersionMaxLimitExceeded for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2LaunchTemplateVersionMaxLimitExceeded = new NodegroupIssueCode("Ec2LaunchTemplateVersionMaxLimitExceeded");
        /// <summary>
        /// Constant Ec2LaunchTemplateVersionMismatch for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2LaunchTemplateVersionMismatch = new NodegroupIssueCode("Ec2LaunchTemplateVersionMismatch");
        /// <summary>
        /// Constant Ec2SecurityGroupDeletionFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SecurityGroupDeletionFailure = new NodegroupIssueCode("Ec2SecurityGroupDeletionFailure");
        /// <summary>
        /// Constant Ec2SecurityGroupNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SecurityGroupNotFound = new NodegroupIssueCode("Ec2SecurityGroupNotFound");
        /// <summary>
        /// Constant Ec2SubnetInvalidConfiguration for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SubnetInvalidConfiguration = new NodegroupIssueCode("Ec2SubnetInvalidConfiguration");
        /// <summary>
        /// Constant Ec2SubnetListTooLong for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SubnetListTooLong = new NodegroupIssueCode("Ec2SubnetListTooLong");
        /// <summary>
        /// Constant Ec2SubnetMissingIpv6Assignment for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SubnetMissingIpv6Assignment = new NodegroupIssueCode("Ec2SubnetMissingIpv6Assignment");
        /// <summary>
        /// Constant Ec2SubnetNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Ec2SubnetNotFound = new NodegroupIssueCode("Ec2SubnetNotFound");
        /// <summary>
        /// Constant IamInstanceProfileNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode IamInstanceProfileNotFound = new NodegroupIssueCode("IamInstanceProfileNotFound");
        /// <summary>
        /// Constant IamLimitExceeded for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode IamLimitExceeded = new NodegroupIssueCode("IamLimitExceeded");
        /// <summary>
        /// Constant IamNodeRoleNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode IamNodeRoleNotFound = new NodegroupIssueCode("IamNodeRoleNotFound");
        /// <summary>
        /// Constant IamThrottling for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode IamThrottling = new NodegroupIssueCode("IamThrottling");
        /// <summary>
        /// Constant InstanceLimitExceeded for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode InstanceLimitExceeded = new NodegroupIssueCode("InstanceLimitExceeded");
        /// <summary>
        /// Constant InsufficientFreeAddresses for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode InsufficientFreeAddresses = new NodegroupIssueCode("InsufficientFreeAddresses");
        /// <summary>
        /// Constant InternalFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode InternalFailure = new NodegroupIssueCode("InternalFailure");
        /// <summary>
        /// Constant KubernetesLabelInvalid for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode KubernetesLabelInvalid = new NodegroupIssueCode("KubernetesLabelInvalid");
        /// <summary>
        /// Constant LimitExceeded for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode LimitExceeded = new NodegroupIssueCode("LimitExceeded");
        /// <summary>
        /// Constant NodeCreationFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode NodeCreationFailure = new NodegroupIssueCode("NodeCreationFailure");
        /// <summary>
        /// Constant NodeTerminationFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode NodeTerminationFailure = new NodegroupIssueCode("NodeTerminationFailure");
        /// <summary>
        /// Constant PodEvictionFailure for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode PodEvictionFailure = new NodegroupIssueCode("PodEvictionFailure");
        /// <summary>
        /// Constant SourceEc2LaunchTemplateNotFound for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode SourceEc2LaunchTemplateNotFound = new NodegroupIssueCode("SourceEc2LaunchTemplateNotFound");
        /// <summary>
        /// Constant Unknown for NodegroupIssueCode
        /// </summary>
        public static readonly NodegroupIssueCode Unknown = new NodegroupIssueCode("Unknown");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodegroupIssueCode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodegroupIssueCode FindValue(string value)
        {
            return FindValue<NodegroupIssueCode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodegroupIssueCode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodegroupStatus.
    /// </summary>
    public class NodegroupStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus ACTIVE = new NodegroupStatus("ACTIVE");
        /// <summary>
        /// Constant CREATE_FAILED for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus CREATE_FAILED = new NodegroupStatus("CREATE_FAILED");
        /// <summary>
        /// Constant CREATING for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus CREATING = new NodegroupStatus("CREATING");
        /// <summary>
        /// Constant DEGRADED for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus DEGRADED = new NodegroupStatus("DEGRADED");
        /// <summary>
        /// Constant DELETE_FAILED for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus DELETE_FAILED = new NodegroupStatus("DELETE_FAILED");
        /// <summary>
        /// Constant DELETING for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus DELETING = new NodegroupStatus("DELETING");
        /// <summary>
        /// Constant UPDATING for NodegroupStatus
        /// </summary>
        public static readonly NodegroupStatus UPDATING = new NodegroupStatus("UPDATING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodegroupStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodegroupStatus FindValue(string value)
        {
            return FindValue<NodegroupStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodegroupStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NodegroupUpdateStrategies.
    /// </summary>
    public class NodegroupUpdateStrategies : ConstantClass
    {

        /// <summary>
        /// Constant DEFAULT for NodegroupUpdateStrategies
        /// </summary>
        public static readonly NodegroupUpdateStrategies DEFAULT = new NodegroupUpdateStrategies("DEFAULT");
        /// <summary>
        /// Constant MINIMAL for NodegroupUpdateStrategies
        /// </summary>
        public static readonly NodegroupUpdateStrategies MINIMAL = new NodegroupUpdateStrategies("MINIMAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NodegroupUpdateStrategies(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NodegroupUpdateStrategies FindValue(string value)
        {
            return FindValue<NodegroupUpdateStrategies>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NodegroupUpdateStrategies(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResolveConflicts.
    /// </summary>
    public class ResolveConflicts : ConstantClass
    {

        /// <summary>
        /// Constant NONE for ResolveConflicts
        /// </summary>
        public static readonly ResolveConflicts NONE = new ResolveConflicts("NONE");
        /// <summary>
        /// Constant OVERWRITE for ResolveConflicts
        /// </summary>
        public static readonly ResolveConflicts OVERWRITE = new ResolveConflicts("OVERWRITE");
        /// <summary>
        /// Constant PRESERVE for ResolveConflicts
        /// </summary>
        public static readonly ResolveConflicts PRESERVE = new ResolveConflicts("PRESERVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResolveConflicts(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResolveConflicts FindValue(string value)
        {
            return FindValue<ResolveConflicts>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResolveConflicts(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SupportType.
    /// </summary>
    public class SupportType : ConstantClass
    {

        /// <summary>
        /// Constant EXTENDED for SupportType
        /// </summary>
        public static readonly SupportType EXTENDED = new SupportType("EXTENDED");
        /// <summary>
        /// Constant STANDARD for SupportType
        /// </summary>
        public static readonly SupportType STANDARD = new SupportType("STANDARD");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SupportType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SupportType FindValue(string value)
        {
            return FindValue<SupportType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SupportType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TaintEffect.
    /// </summary>
    public class TaintEffect : ConstantClass
    {

        /// <summary>
        /// Constant NO_EXECUTE for TaintEffect
        /// </summary>
        public static readonly TaintEffect NO_EXECUTE = new TaintEffect("NO_EXECUTE");
        /// <summary>
        /// Constant NO_SCHEDULE for TaintEffect
        /// </summary>
        public static readonly TaintEffect NO_SCHEDULE = new TaintEffect("NO_SCHEDULE");
        /// <summary>
        /// Constant PREFER_NO_SCHEDULE for TaintEffect
        /// </summary>
        public static readonly TaintEffect PREFER_NO_SCHEDULE = new TaintEffect("PREFER_NO_SCHEDULE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TaintEffect(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TaintEffect FindValue(string value)
        {
            return FindValue<TaintEffect>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TaintEffect(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateParamType.
    /// </summary>
    public class UpdateParamType : ConstantClass
    {

        /// <summary>
        /// Constant AddonVersion for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType AddonVersion = new UpdateParamType("AddonVersion");
        /// <summary>
        /// Constant AuthenticationMode for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType AuthenticationMode = new UpdateParamType("AuthenticationMode");
        /// <summary>
        /// Constant ClusterLogging for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ClusterLogging = new UpdateParamType("ClusterLogging");
        /// <summary>
        /// Constant ComputeConfig for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ComputeConfig = new UpdateParamType("ComputeConfig");
        /// <summary>
        /// Constant ConfigurationValues for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ConfigurationValues = new UpdateParamType("ConfigurationValues");
        /// <summary>
        /// Constant DesiredSize for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType DesiredSize = new UpdateParamType("DesiredSize");
        /// <summary>
        /// Constant EncryptionConfig for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType EncryptionConfig = new UpdateParamType("EncryptionConfig");
        /// <summary>
        /// Constant EndpointPrivateAccess for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType EndpointPrivateAccess = new UpdateParamType("EndpointPrivateAccess");
        /// <summary>
        /// Constant EndpointPublicAccess for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType EndpointPublicAccess = new UpdateParamType("EndpointPublicAccess");
        /// <summary>
        /// Constant IdentityProviderConfig for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType IdentityProviderConfig = new UpdateParamType("IdentityProviderConfig");
        /// <summary>
        /// Constant KubernetesNetworkConfig for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType KubernetesNetworkConfig = new UpdateParamType("KubernetesNetworkConfig");
        /// <summary>
        /// Constant LabelsToAdd for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType LabelsToAdd = new UpdateParamType("LabelsToAdd");
        /// <summary>
        /// Constant LabelsToRemove for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType LabelsToRemove = new UpdateParamType("LabelsToRemove");
        /// <summary>
        /// Constant LaunchTemplateName for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType LaunchTemplateName = new UpdateParamType("LaunchTemplateName");
        /// <summary>
        /// Constant LaunchTemplateVersion for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType LaunchTemplateVersion = new UpdateParamType("LaunchTemplateVersion");
        /// <summary>
        /// Constant MaxSize for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType MaxSize = new UpdateParamType("MaxSize");
        /// <summary>
        /// Constant MaxUnavailable for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType MaxUnavailable = new UpdateParamType("MaxUnavailable");
        /// <summary>
        /// Constant MaxUnavailablePercentage for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType MaxUnavailablePercentage = new UpdateParamType("MaxUnavailablePercentage");
        /// <summary>
        /// Constant MinSize for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType MinSize = new UpdateParamType("MinSize");
        /// <summary>
        /// Constant NodeRepairEnabled for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType NodeRepairEnabled = new UpdateParamType("NodeRepairEnabled");
        /// <summary>
        /// Constant PlatformVersion for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType PlatformVersion = new UpdateParamType("PlatformVersion");
        /// <summary>
        /// Constant PodIdentityAssociations for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType PodIdentityAssociations = new UpdateParamType("PodIdentityAssociations");
        /// <summary>
        /// Constant PublicAccessCidrs for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType PublicAccessCidrs = new UpdateParamType("PublicAccessCidrs");
        /// <summary>
        /// Constant ReleaseVersion for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ReleaseVersion = new UpdateParamType("ReleaseVersion");
        /// <summary>
        /// Constant RemoteNetworkConfig for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType RemoteNetworkConfig = new UpdateParamType("RemoteNetworkConfig");
        /// <summary>
        /// Constant ResolveConflicts for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ResolveConflicts = new UpdateParamType("ResolveConflicts");
        /// <summary>
        /// Constant SecurityGroups for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType SecurityGroups = new UpdateParamType("SecurityGroups");
        /// <summary>
        /// Constant ServiceAccountRoleArn for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ServiceAccountRoleArn = new UpdateParamType("ServiceAccountRoleArn");
        /// <summary>
        /// Constant StorageConfig for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType StorageConfig = new UpdateParamType("StorageConfig");
        /// <summary>
        /// Constant Subnets for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType Subnets = new UpdateParamType("Subnets");
        /// <summary>
        /// Constant TaintsToAdd for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType TaintsToAdd = new UpdateParamType("TaintsToAdd");
        /// <summary>
        /// Constant TaintsToRemove for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType TaintsToRemove = new UpdateParamType("TaintsToRemove");
        /// <summary>
        /// Constant UpdateStrategy for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType UpdateStrategy = new UpdateParamType("UpdateStrategy");
        /// <summary>
        /// Constant UpgradePolicy for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType UpgradePolicy = new UpdateParamType("UpgradePolicy");
        /// <summary>
        /// Constant Version for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType Version = new UpdateParamType("Version");
        /// <summary>
        /// Constant ZonalShiftConfig for UpdateParamType
        /// </summary>
        public static readonly UpdateParamType ZonalShiftConfig = new UpdateParamType("ZonalShiftConfig");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateParamType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateParamType FindValue(string value)
        {
            return FindValue<UpdateParamType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateParamType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateStatus.
    /// </summary>
    public class UpdateStatus : ConstantClass
    {

        /// <summary>
        /// Constant Cancelled for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus Cancelled = new UpdateStatus("Cancelled");
        /// <summary>
        /// Constant Failed for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus Failed = new UpdateStatus("Failed");
        /// <summary>
        /// Constant InProgress for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus InProgress = new UpdateStatus("InProgress");
        /// <summary>
        /// Constant Successful for UpdateStatus
        /// </summary>
        public static readonly UpdateStatus Successful = new UpdateStatus("Successful");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateStatus FindValue(string value)
        {
            return FindValue<UpdateStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type UpdateType.
    /// </summary>
    public class UpdateType : ConstantClass
    {

        /// <summary>
        /// Constant AccessConfigUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType AccessConfigUpdate = new UpdateType("AccessConfigUpdate");
        /// <summary>
        /// Constant AddonUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType AddonUpdate = new UpdateType("AddonUpdate");
        /// <summary>
        /// Constant AssociateEncryptionConfig for UpdateType
        /// </summary>
        public static readonly UpdateType AssociateEncryptionConfig = new UpdateType("AssociateEncryptionConfig");
        /// <summary>
        /// Constant AssociateIdentityProviderConfig for UpdateType
        /// </summary>
        public static readonly UpdateType AssociateIdentityProviderConfig = new UpdateType("AssociateIdentityProviderConfig");
        /// <summary>
        /// Constant AutoModeUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType AutoModeUpdate = new UpdateType("AutoModeUpdate");
        /// <summary>
        /// Constant ConfigUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType ConfigUpdate = new UpdateType("ConfigUpdate");
        /// <summary>
        /// Constant DisassociateIdentityProviderConfig for UpdateType
        /// </summary>
        public static readonly UpdateType DisassociateIdentityProviderConfig = new UpdateType("DisassociateIdentityProviderConfig");
        /// <summary>
        /// Constant EndpointAccessUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType EndpointAccessUpdate = new UpdateType("EndpointAccessUpdate");
        /// <summary>
        /// Constant LoggingUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType LoggingUpdate = new UpdateType("LoggingUpdate");
        /// <summary>
        /// Constant RemoteNetworkConfigUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType RemoteNetworkConfigUpdate = new UpdateType("RemoteNetworkConfigUpdate");
        /// <summary>
        /// Constant UpgradePolicyUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType UpgradePolicyUpdate = new UpdateType("UpgradePolicyUpdate");
        /// <summary>
        /// Constant VersionUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType VersionUpdate = new UpdateType("VersionUpdate");
        /// <summary>
        /// Constant VpcConfigUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType VpcConfigUpdate = new UpdateType("VpcConfigUpdate");
        /// <summary>
        /// Constant ZonalShiftConfigUpdate for UpdateType
        /// </summary>
        public static readonly UpdateType ZonalShiftConfigUpdate = new UpdateType("ZonalShiftConfigUpdate");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public UpdateType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static UpdateType FindValue(string value)
        {
            return FindValue<UpdateType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator UpdateType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type VersionStatus.
    /// </summary>
    public class VersionStatus : ConstantClass
    {

        /// <summary>
        /// Constant EXTENDED_SUPPORT for VersionStatus
        /// </summary>
        public static readonly VersionStatus EXTENDED_SUPPORT = new VersionStatus("EXTENDED_SUPPORT");
        /// <summary>
        /// Constant STANDARD_SUPPORT for VersionStatus
        /// </summary>
        public static readonly VersionStatus STANDARD_SUPPORT = new VersionStatus("STANDARD_SUPPORT");
        /// <summary>
        /// Constant UNSUPPORTED for VersionStatus
        /// </summary>
        public static readonly VersionStatus UNSUPPORTED = new VersionStatus("UNSUPPORTED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public VersionStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static VersionStatus FindValue(string value)
        {
            return FindValue<VersionStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator VersionStatus(string value)
        {
            return FindValue(value);
        }
    }

}