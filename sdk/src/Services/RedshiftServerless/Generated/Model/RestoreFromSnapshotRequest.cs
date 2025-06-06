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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
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
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreFromSnapshot operation.
    /// Restores a namespace from a snapshot.
    /// </summary>
    public partial class RestoreFromSnapshotRequest : AmazonRedshiftServerlessRequest
    {
        private string _adminPasswordSecretKmsKeyId;
        private bool? _manageAdminPassword;
        private string _namespaceName;
        private string _ownerAccount;
        private string _snapshotArn;
        private string _snapshotName;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property AdminPasswordSecretKmsKeyId. 
        /// <para>
        /// The ID of the Key Management Service (KMS) key used to encrypt and store the namespace's
        /// admin credentials secret.
        /// </para>
        /// </summary>
        public string AdminPasswordSecretKmsKeyId
        {
            get { return this._adminPasswordSecretKmsKeyId; }
            set { this._adminPasswordSecretKmsKeyId = value; }
        }

        // Check to see if AdminPasswordSecretKmsKeyId property is set
        internal bool IsSetAdminPasswordSecretKmsKeyId()
        {
            return this._adminPasswordSecretKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ManageAdminPassword. 
        /// <para>
        /// If <c>true</c>, Amazon Redshift uses Secrets Manager to manage the restored snapshot's
        /// admin credentials. If <c>MmanageAdminPassword</c> is false or not set, Amazon Redshift
        /// uses the admin credentials that the namespace or cluster had at the time the snapshot
        /// was taken.
        /// </para>
        /// </summary>
        public bool? ManageAdminPassword
        {
            get { return this._manageAdminPassword; }
            set { this._manageAdminPassword = value; }
        }

        // Check to see if ManageAdminPassword property is set
        internal bool IsSetManageAdminPassword()
        {
            return this._manageAdminPassword.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The name of the namespace to restore the snapshot to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The Amazon Web Services account that owns the snapshot.
        /// </para>
        /// </summary>
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the snapshot to restore from. Required if restoring
        /// from a provisioned cluster to Amazon Redshift Serverless. Must not be specified at
        /// the same time as <c>snapshotName</c>.
        /// </para>
        ///  
        /// <para>
        /// The format of the ARN is arn:aws:redshift:&lt;region&gt;:&lt;account_id&gt;:snapshot:&lt;cluster_identifier&gt;/&lt;snapshot_identifier&gt;.
        /// </para>
        /// </summary>
        public string SnapshotArn
        {
            get { return this._snapshotArn; }
            set { this._snapshotArn = value; }
        }

        // Check to see if SnapshotArn property is set
        internal bool IsSetSnapshotArn()
        {
            return this._snapshotArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotName. 
        /// <para>
        /// The name of the snapshot to restore from. Must not be specified at the same time as
        /// <c>snapshotArn</c>.
        /// </para>
        /// </summary>
        public string SnapshotName
        {
            get { return this._snapshotName; }
            set { this._snapshotName = value; }
        }

        // Check to see if SnapshotName property is set
        internal bool IsSetSnapshotName()
        {
            return this._snapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup used to restore the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=64)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}