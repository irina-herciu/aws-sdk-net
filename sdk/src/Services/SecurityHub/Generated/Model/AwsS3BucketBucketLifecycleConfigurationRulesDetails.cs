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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Configuration for a lifecycle rule.
    /// </summary>
    public partial class AwsS3BucketBucketLifecycleConfigurationRulesDetails
    {
        private AwsS3BucketBucketLifecycleConfigurationRulesAbortIncompleteMultipartUploadDetails _abortIncompleteMultipartUpload;
        private string _expirationDate;
        private int? _expirationInDays;
        private bool? _expiredObjectDeleteMarker;
        private AwsS3BucketBucketLifecycleConfigurationRulesFilterDetails _filter;
        private string _id;
        private int? _noncurrentVersionExpirationInDays;
        private List<AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetails> _noncurrentVersionTransitions = AWSConfigs.InitializeCollections ? new List<AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetails>() : null;
        private string _prefix;
        private string _status;
        private List<AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetails> _transitions = AWSConfigs.InitializeCollections ? new List<AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetails>() : null;

        /// <summary>
        /// Gets and sets the property AbortIncompleteMultipartUpload. 
        /// <para>
        /// How Amazon S3 responds when a multipart upload is incomplete. Specifically, provides
        /// a number of days before Amazon S3 cancels the entire upload.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationRulesAbortIncompleteMultipartUploadDetails AbortIncompleteMultipartUpload
        {
            get { return this._abortIncompleteMultipartUpload; }
            set { this._abortIncompleteMultipartUpload = value; }
        }

        // Check to see if AbortIncompleteMultipartUpload property is set
        internal bool IsSetAbortIncompleteMultipartUpload()
        {
            return this._abortIncompleteMultipartUpload != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date when objects are moved or deleted.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string ExpirationDate
        {
            get { return this._expirationDate; }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationInDays. 
        /// <para>
        /// The length in days of the lifetime for objects that are subject to the rule.
        /// </para>
        /// </summary>
        public int? ExpirationInDays
        {
            get { return this._expirationInDays; }
            set { this._expirationInDays = value; }
        }

        // Check to see if ExpirationInDays property is set
        internal bool IsSetExpirationInDays()
        {
            return this._expirationInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpiredObjectDeleteMarker. 
        /// <para>
        /// Whether Amazon S3 removes a delete marker that has no noncurrent versions. If set
        /// to <c>true</c>, the delete marker is expired. If set to <c>false</c>, the policy takes
        /// no action.
        /// </para>
        ///  
        /// <para>
        /// If you provide <c>ExpiredObjectDeleteMarker</c>, you cannot provide <c>ExpirationInDays</c>
        /// or <c>ExpirationDate</c>.
        /// </para>
        /// </summary>
        public bool? ExpiredObjectDeleteMarker
        {
            get { return this._expiredObjectDeleteMarker; }
            set { this._expiredObjectDeleteMarker = value; }
        }

        // Check to see if ExpiredObjectDeleteMarker property is set
        internal bool IsSetExpiredObjectDeleteMarker()
        {
            return this._expiredObjectDeleteMarker.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Identifies the objects that a rule applies to.
        /// </para>
        /// </summary>
        public AwsS3BucketBucketLifecycleConfigurationRulesFilterDetails Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property ID. 
        /// <para>
        /// The unique identifier of the rule.
        /// </para>
        /// </summary>
        public string ID
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if ID property is set
        internal bool IsSetID()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property NoncurrentVersionExpirationInDays. 
        /// <para>
        /// The number of days that an object is noncurrent before Amazon S3 can perform the associated
        /// action.
        /// </para>
        /// </summary>
        public int? NoncurrentVersionExpirationInDays
        {
            get { return this._noncurrentVersionExpirationInDays; }
            set { this._noncurrentVersionExpirationInDays = value; }
        }

        // Check to see if NoncurrentVersionExpirationInDays property is set
        internal bool IsSetNoncurrentVersionExpirationInDays()
        {
            return this._noncurrentVersionExpirationInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoncurrentVersionTransitions. 
        /// <para>
        /// Transition rules that describe when noncurrent objects transition to a specified storage
        /// class.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsS3BucketBucketLifecycleConfigurationRulesNoncurrentVersionTransitionsDetails> NoncurrentVersionTransitions
        {
            get { return this._noncurrentVersionTransitions; }
            set { this._noncurrentVersionTransitions = value; }
        }

        // Check to see if NoncurrentVersionTransitions property is set
        internal bool IsSetNoncurrentVersionTransitions()
        {
            return this._noncurrentVersionTransitions != null && (this._noncurrentVersionTransitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// A prefix that identifies one or more objects that the rule applies to.
        /// </para>
        /// </summary>
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the rule. Indicates whether the rule is currently being applied.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Transitions. 
        /// <para>
        /// Transition rules that indicate when objects transition to a specified storage class.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsS3BucketBucketLifecycleConfigurationRulesTransitionsDetails> Transitions
        {
            get { return this._transitions; }
            set { this._transitions = value; }
        }

        // Check to see if Transitions property is set
        internal bool IsSetTransitions()
        {
            return this._transitions != null && (this._transitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}