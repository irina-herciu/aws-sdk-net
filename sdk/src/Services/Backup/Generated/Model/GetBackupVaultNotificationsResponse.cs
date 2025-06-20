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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the GetBackupVaultNotifications operation.
    /// </summary>
    public partial class GetBackupVaultNotificationsResponse : AmazonWebServiceResponse
    {
        private string _backupVaultArn;
        private List<string> _backupVaultEvents = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _backupVaultName;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property BackupVaultArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a backup vault; for example,
        /// <c>arn:aws:backup:us-east-1:123456789012:backup-vault:aBackupVault</c>.
        /// </para>
        /// </summary>
        public string BackupVaultArn
        {
            get { return this._backupVaultArn; }
            set { this._backupVaultArn = value; }
        }

        // Check to see if BackupVaultArn property is set
        internal bool IsSetBackupVaultArn()
        {
            return this._backupVaultArn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupVaultEvents. 
        /// <para>
        /// An array of events that indicate the status of jobs to back up resources to the backup
        /// vault.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BackupVaultEvents
        {
            get { return this._backupVaultEvents; }
            set { this._backupVaultEvents = value; }
        }

        // Check to see if BackupVaultEvents property is set
        internal bool IsSetBackupVaultEvents()
        {
            return this._backupVaultEvents != null && (this._backupVaultEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BackupVaultName. 
        /// <para>
        /// The name of a logical container where backups are stored. Backup vaults are identified
        /// by names that are unique to the account used to create them and the Region where they
        /// are created.
        /// </para>
        /// </summary>
        public string BackupVaultName
        {
            get { return this._backupVaultName; }
            set { this._backupVaultName = value; }
        }

        // Check to see if BackupVaultName property is set
        internal bool IsSetBackupVaultName()
        {
            return this._backupVaultName != null;
        }

        /// <summary>
        /// Gets and sets the property SNSTopicArn. 
        /// <para>
        /// An ARN that uniquely identifies an Amazon Simple Notification Service (Amazon SNS)
        /// topic; for example, <c>arn:aws:sns:us-west-2:111122223333:MyTopic</c>.
        /// </para>
        /// </summary>
        public string SNSTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SNSTopicArn property is set
        internal bool IsSetSNSTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}