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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines an IBM Db2 LUW endpoint.
    /// </summary>
    public partial class IBMDb2Settings
    {
        private string _currentLsn;
        private string _databaseName;
        private bool? _keepCsvFiles;
        private int? _loadTimeout;
        private int? _maxFileSize;
        private int? _maxKBytesPerRead;
        private string _password;
        private int? _port;
        private string _secretsManagerAccessRoleArn;
        private string _secretsManagerSecretId;
        private string _serverName;
        private bool? _setDataCaptureChanges;
        private string _username;
        private int? _writeBufferSize;

        /// <summary>
        /// Gets and sets the property CurrentLsn. 
        /// <para>
        /// For ongoing replication (CDC), use CurrentLSN to specify a log sequence number (LSN)
        /// where you want the replication to start.
        /// </para>
        /// </summary>
        public string CurrentLsn
        {
            get { return this._currentLsn; }
            set { this._currentLsn = value; }
        }

        // Check to see if CurrentLsn property is set
        internal bool IsSetCurrentLsn()
        {
            return this._currentLsn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// Database name for the endpoint.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property KeepCsvFiles. 
        /// <para>
        /// If true, DMS saves any .csv files to the Db2 LUW target that were used to replicate
        /// data. DMS uses these files for analysis and troubleshooting.
        /// </para>
        ///  
        /// <para>
        /// The default value is false. 
        /// </para>
        /// </summary>
        public bool? KeepCsvFiles
        {
            get { return this._keepCsvFiles; }
            set { this._keepCsvFiles = value; }
        }

        // Check to see if KeepCsvFiles property is set
        internal bool IsSetKeepCsvFiles()
        {
            return this._keepCsvFiles.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadTimeout. 
        /// <para>
        /// The amount of time (in milliseconds) before DMS times out operations performed by
        /// DMS on the Db2 target. The default value is 1200 (20 minutes).
        /// </para>
        /// </summary>
        public int? LoadTimeout
        {
            get { return this._loadTimeout; }
            set { this._loadTimeout = value; }
        }

        // Check to see if LoadTimeout property is set
        internal bool IsSetLoadTimeout()
        {
            return this._loadTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// Specifies the maximum size (in KB) of .csv files used to transfer data to Db2 LUW.
        /// </para>
        /// </summary>
        public int? MaxFileSize
        {
            get { return this._maxFileSize; }
            set { this._maxFileSize = value; }
        }

        // Check to see if MaxFileSize property is set
        internal bool IsSetMaxFileSize()
        {
            return this._maxFileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxKBytesPerRead. 
        /// <para>
        /// Maximum number of bytes per read, as a NUMBER value. The default is 64 KB.
        /// </para>
        /// </summary>
        public int? MaxKBytesPerRead
        {
            get { return this._maxKBytesPerRead; }
            set { this._maxKBytesPerRead = value; }
        }

        // Check to see if MaxKBytesPerRead property is set
        internal bool IsSetMaxKBytesPerRead()
        {
            return this._maxKBytesPerRead.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// Endpoint connection password.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// Endpoint TCP port. The default value is 50000.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerAccessRoleArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the IAM role that specifies DMS as the trusted
        /// entity and grants the required permissions to access the value in <c>SecretsManagerSecret</c>.
        /// The role must allow the <c>iam:PassRole</c> action. <c>SecretsManagerSecret</c> has
        /// the value of the Amazon Web Services Secrets Manager secret that allows access to
        /// the Db2 LUW endpoint. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify one of two sets of values for these permissions. You can specify the
        /// values for this setting and <c>SecretsManagerSecretId</c>. Or you can specify clear-text
        /// values for <c>UserName</c>, <c>Password</c>, <c>ServerName</c>, and <c>Port</c>. You
        /// can't specify both. For more information on creating this <c>SecretsManagerSecret</c>
        /// and the <c>SecretsManagerAccessRoleArn</c> and <c>SecretsManagerSecretId</c> required
        /// to access it, see <a href="https://docs.aws.amazon.com/dms/latest/userguide/CHAP_Security.html#security-iam-secretsmanager">Using
        /// secrets to access Database Migration Service resources</a> in the <i>Database Migration
        /// Service User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public string SecretsManagerAccessRoleArn
        {
            get { return this._secretsManagerAccessRoleArn; }
            set { this._secretsManagerAccessRoleArn = value; }
        }

        // Check to see if SecretsManagerAccessRoleArn property is set
        internal bool IsSetSecretsManagerAccessRoleArn()
        {
            return this._secretsManagerAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretId. 
        /// <para>
        /// The full ARN, partial ARN, or friendly name of the <c>SecretsManagerSecret</c> that
        /// contains the Db2 LUW endpoint connection details.
        /// </para>
        /// </summary>
        public string SecretsManagerSecretId
        {
            get { return this._secretsManagerSecretId; }
            set { this._secretsManagerSecretId = value; }
        }

        // Check to see if SecretsManagerSecretId property is set
        internal bool IsSetSecretsManagerSecretId()
        {
            return this._secretsManagerSecretId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// Fully qualified domain name of the endpoint.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property SetDataCaptureChanges. 
        /// <para>
        /// Enables ongoing replication (CDC) as a BOOLEAN value. The default is true.
        /// </para>
        /// </summary>
        public bool? SetDataCaptureChanges
        {
            get { return this._setDataCaptureChanges; }
            set { this._setDataCaptureChanges = value; }
        }

        // Check to see if SetDataCaptureChanges property is set
        internal bool IsSetSetDataCaptureChanges()
        {
            return this._setDataCaptureChanges.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// Endpoint connection user name.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property WriteBufferSize. 
        /// <para>
        /// The size (in KB) of the in-memory file write buffer used when generating .csv files
        /// on the local disk on the DMS replication instance. The default value is 1024 (1 MB).
        /// </para>
        /// </summary>
        public int? WriteBufferSize
        {
            get { return this._writeBufferSize; }
            set { this._writeBufferSize = value; }
        }

        // Check to see if WriteBufferSize property is set
        internal bool IsSetWriteBufferSize()
        {
            return this._writeBufferSize.HasValue; 
        }

    }
}