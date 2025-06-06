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
    /// Container for the parameters to the StopBackupJob operation.
    /// Attempts to cancel a job to create a one-time backup of a resource.
    /// 
    ///  
    /// <para>
    /// This action is not supported for the following services:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Aurora
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon DocumentDB (with MongoDB compatibility)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon FSx for Lustre
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon FSx for NetApp ONTAP
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon FSx for OpenZFS
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon FSx for Windows File Server
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Neptune
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// SAP HANA databases on Amazon EC2 instances
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon RDS
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StopBackupJobRequest : AmazonBackupRequest
    {
        private string _backupJobId;

        /// <summary>
        /// Gets and sets the property BackupJobId. 
        /// <para>
        /// Uniquely identifies a request to Backup to back up a resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BackupJobId
        {
            get { return this._backupJobId; }
            set { this._backupJobId = value; }
        }

        // Check to see if BackupJobId property is set
        internal bool IsSetBackupJobId()
        {
            return this._backupJobId != null;
        }

    }
}