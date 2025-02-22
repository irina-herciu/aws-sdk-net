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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.DocDBElastic
{

    /// <summary>
    /// Constants used for properties of type Auth.
    /// </summary>
    public class Auth : ConstantClass
    {

        /// <summary>
        /// Constant PLAIN_TEXT for Auth
        /// </summary>
        public static readonly Auth PLAIN_TEXT = new Auth("PLAIN_TEXT");
        /// <summary>
        /// Constant SECRET_ARN for Auth
        /// </summary>
        public static readonly Auth SECRET_ARN = new Auth("SECRET_ARN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Auth(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Auth FindValue(string value)
        {
            return FindValue<Auth>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Auth(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OptInType.
    /// </summary>
    public class OptInType : ConstantClass
    {

        /// <summary>
        /// Constant APPLY_ON for OptInType
        /// </summary>
        public static readonly OptInType APPLY_ON = new OptInType("APPLY_ON");
        /// <summary>
        /// Constant IMMEDIATE for OptInType
        /// </summary>
        public static readonly OptInType IMMEDIATE = new OptInType("IMMEDIATE");
        /// <summary>
        /// Constant NEXT_MAINTENANCE for OptInType
        /// </summary>
        public static readonly OptInType NEXT_MAINTENANCE = new OptInType("NEXT_MAINTENANCE");
        /// <summary>
        /// Constant UNDO_OPT_IN for OptInType
        /// </summary>
        public static readonly OptInType UNDO_OPT_IN = new OptInType("UNDO_OPT_IN");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OptInType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OptInType FindValue(string value)
        {
            return FindValue<OptInType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OptInType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SnapshotType.
    /// </summary>
    public class SnapshotType : ConstantClass
    {

        /// <summary>
        /// Constant AUTOMATED for SnapshotType
        /// </summary>
        public static readonly SnapshotType AUTOMATED = new SnapshotType("AUTOMATED");
        /// <summary>
        /// Constant MANUAL for SnapshotType
        /// </summary>
        public static readonly SnapshotType MANUAL = new SnapshotType("MANUAL");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SnapshotType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SnapshotType FindValue(string value)
        {
            return FindValue<SnapshotType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SnapshotType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Status.
    /// </summary>
    public class Status : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVE for Status
        /// </summary>
        public static readonly Status ACTIVE = new Status("ACTIVE");
        /// <summary>
        /// Constant COPYING for Status
        /// </summary>
        public static readonly Status COPYING = new Status("COPYING");
        /// <summary>
        /// Constant CREATING for Status
        /// </summary>
        public static readonly Status CREATING = new Status("CREATING");
        /// <summary>
        /// Constant DELETING for Status
        /// </summary>
        public static readonly Status DELETING = new Status("DELETING");
        /// <summary>
        /// Constant INACCESSIBLE_ENCRYPTION_CREDENTIALS_RECOVERABLE for Status
        /// </summary>
        public static readonly Status INACCESSIBLE_ENCRYPTION_CREDENTIALS_RECOVERABLE = new Status("INACCESSIBLE_ENCRYPTION_CREDENTIALS_RECOVERABLE");
        /// <summary>
        /// Constant INACCESSIBLE_ENCRYPTION_CREDS for Status
        /// </summary>
        public static readonly Status INACCESSIBLE_ENCRYPTION_CREDS = new Status("INACCESSIBLE_ENCRYPTION_CREDS");
        /// <summary>
        /// Constant INACCESSIBLE_SECRET_ARN for Status
        /// </summary>
        public static readonly Status INACCESSIBLE_SECRET_ARN = new Status("INACCESSIBLE_SECRET_ARN");
        /// <summary>
        /// Constant INACCESSIBLE_VPC_ENDPOINT for Status
        /// </summary>
        public static readonly Status INACCESSIBLE_VPC_ENDPOINT = new Status("INACCESSIBLE_VPC_ENDPOINT");
        /// <summary>
        /// Constant INCOMPATIBLE_NETWORK for Status
        /// </summary>
        public static readonly Status INCOMPATIBLE_NETWORK = new Status("INCOMPATIBLE_NETWORK");
        /// <summary>
        /// Constant INVALID_SECURITY_GROUP_ID for Status
        /// </summary>
        public static readonly Status INVALID_SECURITY_GROUP_ID = new Status("INVALID_SECURITY_GROUP_ID");
        /// <summary>
        /// Constant INVALID_SUBNET_ID for Status
        /// </summary>
        public static readonly Status INVALID_SUBNET_ID = new Status("INVALID_SUBNET_ID");
        /// <summary>
        /// Constant IP_ADDRESS_LIMIT_EXCEEDED for Status
        /// </summary>
        public static readonly Status IP_ADDRESS_LIMIT_EXCEEDED = new Status("IP_ADDRESS_LIMIT_EXCEEDED");
        /// <summary>
        /// Constant MAINTENANCE for Status
        /// </summary>
        public static readonly Status MAINTENANCE = new Status("MAINTENANCE");
        /// <summary>
        /// Constant MERGING for Status
        /// </summary>
        public static readonly Status MERGING = new Status("MERGING");
        /// <summary>
        /// Constant MODIFYING for Status
        /// </summary>
        public static readonly Status MODIFYING = new Status("MODIFYING");
        /// <summary>
        /// Constant SPLITTING for Status
        /// </summary>
        public static readonly Status SPLITTING = new Status("SPLITTING");
        /// <summary>
        /// Constant STARTING for Status
        /// </summary>
        public static readonly Status STARTING = new Status("STARTING");
        /// <summary>
        /// Constant STOPPED for Status
        /// </summary>
        public static readonly Status STOPPED = new Status("STOPPED");
        /// <summary>
        /// Constant STOPPING for Status
        /// </summary>
        public static readonly Status STOPPING = new Status("STOPPING");
        /// <summary>
        /// Constant UPDATING for Status
        /// </summary>
        public static readonly Status UPDATING = new Status("UPDATING");
        /// <summary>
        /// Constant VPC_ENDPOINT_LIMIT_EXCEEDED for Status
        /// </summary>
        public static readonly Status VPC_ENDPOINT_LIMIT_EXCEEDED = new Status("VPC_ENDPOINT_LIMIT_EXCEEDED");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Status(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Status FindValue(string value)
        {
            return FindValue<Status>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Status(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ValidationExceptionReason.
    /// </summary>
    public class ValidationExceptionReason : ConstantClass
    {

        /// <summary>
        /// Constant CannotParse for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason CannotParse = new ValidationExceptionReason("cannotParse");
        /// <summary>
        /// Constant FieldValidationFailed for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason FieldValidationFailed = new ValidationExceptionReason("fieldValidationFailed");
        /// <summary>
        /// Constant Other for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason Other = new ValidationExceptionReason("other");
        /// <summary>
        /// Constant UnknownOperation for ValidationExceptionReason
        /// </summary>
        public static readonly ValidationExceptionReason UnknownOperation = new ValidationExceptionReason("unknownOperation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ValidationExceptionReason(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ValidationExceptionReason FindValue(string value)
        {
            return FindValue<ValidationExceptionReason>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ValidationExceptionReason(string value)
        {
            return FindValue(value);
        }
    }

}