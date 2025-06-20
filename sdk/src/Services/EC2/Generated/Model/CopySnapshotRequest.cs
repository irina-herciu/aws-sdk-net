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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CopySnapshot operation.
    /// Copies a point-in-time snapshot of an EBS volume and stores it in Amazon S3. You can
    /// copy a snapshot within the same Region, from one Region to another, or from a Region
    /// to an Outpost. You can't copy a snapshot from an Outpost to a Region, from one Outpost
    /// to another, or within the same Outpost.
    /// 
    ///  
    /// <para>
    /// You can use the snapshot to create EBS volumes or Amazon Machine Images (AMIs).
    /// </para>
    ///  
    /// <para>
    /// When copying snapshots to a Region, copies of encrypted EBS snapshots remain encrypted.
    /// Copies of unencrypted snapshots remain unencrypted, unless you enable encryption for
    /// the snapshot copy operation. By default, encrypted snapshot copies use the default
    /// KMS key; however, you can specify a different KMS key. To copy an encrypted snapshot
    /// that has been shared from another account, you must have permissions for the KMS key
    /// used to encrypt the snapshot.
    /// </para>
    ///  
    /// <para>
    /// Snapshots copied to an Outpost are encrypted by default using the default encryption
    /// key for the Region, or a different key that you specify in the request using <b>KmsKeyId</b>.
    /// Outposts do not support unencrypted snapshots. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#ami">Amazon
    /// EBS local snapshots on Outposts</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Snapshots created by copying another snapshot have an arbitrary volume ID that should
    /// not be used for any purpose.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-copy-snapshot.html">Copy
    /// an Amazon EBS snapshot</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CopySnapshotRequest : AmazonEC2Request
    {
        private int? _completionDurationMinutes;
        private string _description;
        private string _destinationOutpostArn;
        private string _destinationRegion;
        private bool? _dryRun;
        private bool? _encrypted;
        private string _kmsKeyId;
        private string _presignedUrl;
        private string _sourceRegion;
        private string _sourceSnapshotId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Gets and sets the property CompletionDurationMinutes. 
        /// <para>
        /// Specify a completion duration, in 15 minute increments, to initiate a time-based snapshot
        /// copy. Time-based snapshot copy operations complete within the specified duration.
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/time-based-copies.html">
        /// Time-based copies</a>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify a value, the snapshot copy operation is completed on a best-effort
        /// basis.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2880)]
        public int? CompletionDurationMinutes
        {
            get { return this._completionDurationMinutes; }
            set { this._completionDurationMinutes = value; }
        }

        // Check to see if CompletionDurationMinutes property is set
        internal bool IsSetCompletionDurationMinutes()
        {
            return this._completionDurationMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the EBS snapshot.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationOutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost to which to copy the snapshot. Only
        /// specify this parameter when copying a snapshot from an Amazon Web Services Region
        /// to an Outpost. The snapshot must be in the Region for the destination Outpost. You
        /// cannot copy a snapshot from an Outpost to a Region, from one Outpost to another, or
        /// within the same Outpost.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html#copy-snapshots">
        /// Copy snapshots from an Amazon Web Services Region to an Outpost</a> in the <i>Amazon
        /// EBS User Guide</i>.
        /// </para>
        /// </summary>
        public string DestinationOutpostArn
        {
            get { return this._destinationOutpostArn; }
            set { this._destinationOutpostArn = value; }
        }

        // Check to see if DestinationOutpostArn property is set
        internal bool IsSetDestinationOutpostArn()
        {
            return this._destinationOutpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationRegion. 
        /// <para>
        /// The destination Region to use in the <c>PresignedUrl</c> parameter of a snapshot copy
        /// operation. This parameter is only valid for specifying the destination Region in a
        /// <c>PresignedUrl</c> parameter, where it is required.
        /// </para>
        ///  
        /// <para>
        /// The snapshot copy is sent to the regional endpoint that you sent the HTTP request
        /// to (for example, <c>ec2.us-east-1.amazonaws.com</c>). With the CLI, this is specified
        /// using the <c>--region</c> parameter or the default Region in your Amazon Web Services
        /// configuration file.
        /// </para>
        /// </summary>
        public string DestinationRegion
        {
            get { return this._destinationRegion; }
            set { this._destinationRegion = value; }
        }

        // Check to see if DestinationRegion property is set
        internal bool IsSetDestinationRegion()
        {
            return this._destinationRegion != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// To encrypt a copy of an unencrypted snapshot if encryption by default is not enabled,
        /// enable encryption using this parameter. Otherwise, omit this parameter. Encrypted
        /// snapshots are encrypted, even if you omit this parameter and encryption by default
        /// is not enabled. You cannot set this parameter to false. For more information, see
        /// <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-encryption.html">Amazon
        /// EBS encryption</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The identifier of the KMS key to use for Amazon EBS encryption. If this parameter
        /// is not specified, your KMS key for Amazon EBS is used. If <c>KmsKeyId</c> is specified,
        /// the encrypted state must be <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the KMS key using any of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID. For example, 1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key alias. For example, alias/ExampleAlias.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN. For example, arn:aws:kms:us-east-1:012345678910:key/1234abcd-12ab-34cd-56ef-1234567890ab.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN. For example, arn:aws:kms:us-east-1:012345678910:alias/ExampleAlias.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon Web Services authenticates the KMS key asynchronously. Therefore, if you specify
        /// an ID, alias, or ARN that is not valid, the action can appear to complete, but eventually
        /// fails.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property PresignedUrl. 
        /// <para>
        /// When you copy an encrypted source snapshot using the Amazon EC2 Query API, you must
        /// supply a pre-signed URL. This parameter is optional for unencrypted snapshots. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Query-Requests.html">Query
        /// requests</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>PresignedUrl</c> should use the snapshot source endpoint, the <c>CopySnapshot</c>
        /// action, and include the <c>SourceRegion</c>, <c>SourceSnapshotId</c>, and <c>DestinationRegion</c>
        /// parameters. The <c>PresignedUrl</c> must be signed using Amazon Web Services Signature
        /// Version 4. Because EBS snapshots are stored in Amazon S3, the signing algorithm for
        /// this parameter uses the same logic that is described in <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sigv4-query-string-auth.html">
        /// Authenticating Requests: Using Query Parameters (Amazon Web Services Signature Version
        /// 4)</a> in the <i>Amazon S3 API Reference</i>. An invalid or improperly signed <c>PresignedUrl</c>
        /// will cause the copy operation to fail asynchronously, and the snapshot will move to
        /// an <c>error</c> state.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        internal string PresignedUrl
        {
            get { return this._presignedUrl; }
            set { this._presignedUrl = value; }
        }

        // Check to see if PresignedUrl property is set
        internal bool IsSetPresignedUrl()
        {
            return this._presignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The ID of the Region that contains the snapshot to be copied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceRegion
        {
            get { return this._sourceRegion; }
            set { this._sourceRegion = value; }
        }

        // Check to see if SourceRegion property is set
        internal bool IsSetSourceRegion()
        {
            return this._sourceRegion != null;
        }

        /// <summary>
        /// Gets and sets the property SourceSnapshotId. 
        /// <para>
        /// The ID of the EBS snapshot to copy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceSnapshotId
        {
            get { return this._sourceSnapshotId; }
            set { this._sourceSnapshotId = value; }
        }

        // Check to see if SourceSnapshotId property is set
        internal bool IsSetSourceSnapshotId()
        {
            return this._sourceSnapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the new snapshot.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}