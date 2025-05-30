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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRelationalDatabase operation.
    /// Allows the update of one or more attributes of a database in Amazon Lightsail.
    /// 
    ///  
    /// <para>
    /// Updates are applied immediately, or in cases where the updates could result in an
    /// outage, are applied during the database's predefined maintenance window.
    /// </para>
    ///  
    /// <para>
    /// The <c>update relational database</c> operation supports tag-based access control
    /// via resource tags applied to the resource identified by relationalDatabaseName. For
    /// more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class UpdateRelationalDatabaseRequest : AmazonLightsailRequest
    {
        private bool? _applyImmediately;
        private string _caCertificateIdentifier;
        private bool? _disableBackupRetention;
        private bool? _enableBackupRetention;
        private string _masterUserPassword;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _relationalDatabaseBlueprintId;
        private string _relationalDatabaseName;
        private bool? _rotateMasterUserPassword;

        /// <summary>
        /// Gets and sets the property ApplyImmediately. 
        /// <para>
        /// When <c>true</c>, applies changes immediately. When <c>false</c>, applies changes
        /// during the preferred maintenance window. Some changes may cause an outage.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? ApplyImmediately
        {
            get { return this._applyImmediately; }
            set { this._applyImmediately = value; }
        }

        // Check to see if ApplyImmediately property is set
        internal bool IsSetApplyImmediately()
        {
            return this._applyImmediately.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaCertificateIdentifier. 
        /// <para>
        /// Indicates the certificate that needs to be associated with the database.
        /// </para>
        /// </summary>
        public string CaCertificateIdentifier
        {
            get { return this._caCertificateIdentifier; }
            set { this._caCertificateIdentifier = value; }
        }

        // Check to see if CaCertificateIdentifier property is set
        internal bool IsSetCaCertificateIdentifier()
        {
            return this._caCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DisableBackupRetention. 
        /// <para>
        /// When <c>true</c>, disables automated backup retention for your database.
        /// </para>
        ///  
        /// <para>
        /// Disabling backup retention deletes all automated database backups. Before disabling
        /// this, you may want to create a snapshot of your database using the <c>create relational
        /// database snapshot</c> operation.
        /// </para>
        ///  
        /// <para>
        /// Updates are applied during the next maintenance window because this can result in
        /// an outage.
        /// </para>
        /// </summary>
        public bool? DisableBackupRetention
        {
            get { return this._disableBackupRetention; }
            set { this._disableBackupRetention = value; }
        }

        // Check to see if DisableBackupRetention property is set
        internal bool IsSetDisableBackupRetention()
        {
            return this._disableBackupRetention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableBackupRetention. 
        /// <para>
        /// When <c>true</c>, enables automated backup retention for your database.
        /// </para>
        ///  
        /// <para>
        /// Updates are applied during the next maintenance window because this can result in
        /// an outage.
        /// </para>
        /// </summary>
        public bool? EnableBackupRetention
        {
            get { return this._enableBackupRetention; }
            set { this._enableBackupRetention = value; }
        }

        // Check to see if EnableBackupRetention property is set
        internal bool IsSetEnableBackupRetention()
        {
            return this._enableBackupRetention.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The password for the master user. The password can include any printable ASCII character
        /// except "/", """, or "@".
        /// </para>
        ///  
        /// <para>
        /// My<b>SQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 41 characters.
        /// </para>
        ///  
        /// <para>
        ///  <b>PostgreSQL</b> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Must contain from 8 to 128 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string MasterUserPassword
        {
            get { return this._masterUserPassword; }
            set { this._masterUserPassword = value; }
        }

        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this._masterUserPassword != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created for your database
        /// if automated backups are enabled.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the <c>hh24:mi-hh24:mi</c> format.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>16:00-16:30</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must not conflict with the preferred maintenance window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this._preferredBackupWindow; }
            set { this._preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this._preferredBackupWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range during which system maintenance can occur on your database.
        /// </para>
        ///  
        /// <para>
        /// The default is a 30-minute window selected at random from an 8-hour block of time
        /// for each Amazon Web Services Region, occurring on a random day of the week.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be in the <c>ddd:hh24:mi-ddd:hh24:mi</c> format.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid days: Mon, Tue, Wed, Thu, Fri, Sat, Sun.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Must be at least 30 minutes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Example: <c>Tue:17:00-Tue:17:30</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies the accessibility options for your database. A value of <c>true</c> specifies
        /// a database that is available to resources outside of your Lightsail account. A value
        /// of <c>false</c> specifies a database that is available only to your Lightsail resources
        /// in the same region as your database.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseBlueprintId. 
        /// <para>
        /// This parameter is used to update the major version of the database. Enter the <c>blueprintId</c>
        /// for the major version that you want to update to.
        /// </para>
        ///  
        /// <para>
        /// Use the <a href="https://docs.aws.amazon.com/lightsail/2016-11-28/api-reference/API_GetRelationalDatabaseBlueprints.html">GetRelationalDatabaseBlueprints</a>
        /// action to get a list of available blueprint IDs.
        /// </para>
        /// </summary>
        public string RelationalDatabaseBlueprintId
        {
            get { return this._relationalDatabaseBlueprintId; }
            set { this._relationalDatabaseBlueprintId = value; }
        }

        // Check to see if RelationalDatabaseBlueprintId property is set
        internal bool IsSetRelationalDatabaseBlueprintId()
        {
            return this._relationalDatabaseBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of your Lightsail database resource to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelationalDatabaseName
        {
            get { return this._relationalDatabaseName; }
            set { this._relationalDatabaseName = value; }
        }

        // Check to see if RelationalDatabaseName property is set
        internal bool IsSetRelationalDatabaseName()
        {
            return this._relationalDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property RotateMasterUserPassword. 
        /// <para>
        /// When <c>true</c>, the master user password is changed to a new strong password generated
        /// by Lightsail.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>get relational database master user password</c> operation to get the new
        /// password.
        /// </para>
        /// </summary>
        public bool? RotateMasterUserPassword
        {
            get { return this._rotateMasterUserPassword; }
            set { this._rotateMasterUserPassword = value; }
        }

        // Check to see if RotateMasterUserPassword property is set
        internal bool IsSetRotateMasterUserPassword()
        {
            return this._rotateMasterUserPassword.HasValue; 
        }

    }
}