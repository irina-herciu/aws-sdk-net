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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
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
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// This is the response object from the CreateLedger operation.
    /// </summary>
    public partial class CreateLedgerResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationDateTime;
        private bool? _deletionProtection;
        private string _kmsKeyArn;
        private string _name;
        private PermissionsMode _permissionsMode;
        private LedgerState _state;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1600)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The date and time, in epoch time format, when the ledger was created. (Epoch time
        /// format is the number of seconds elapsed since 12:00:00 AM January 1, 1970 UTC.)
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime
        {
            get { return this._creationDateTime; }
            set { this._creationDateTime = value; }
        }

        // Check to see if CreationDateTime property is set
        internal bool IsSetCreationDateTime()
        {
            return this._creationDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether the ledger is protected from being deleted by any user. If not defined
        /// during ledger creation, this feature is enabled (<c>true</c>) by default.
        /// </para>
        ///  
        /// <para>
        /// If deletion protection is enabled, you must first disable it before you can delete
        /// the ledger. You can disable it by calling the <c>UpdateLedger</c> operation to set
        /// this parameter to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the customer managed KMS key that the ledger uses for encryption at rest.
        /// If this parameter is undefined, the ledger uses an Amazon Web Services owned KMS key
        /// for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1600)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ledger.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PermissionsMode. 
        /// <para>
        /// The permissions mode of the ledger that you created.
        /// </para>
        /// </summary>
        public PermissionsMode PermissionsMode
        {
            get { return this._permissionsMode; }
            set { this._permissionsMode = value; }
        }

        // Check to see if PermissionsMode property is set
        internal bool IsSetPermissionsMode()
        {
            return this._permissionsMode != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current status of the ledger.
        /// </para>
        /// </summary>
        public LedgerState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}