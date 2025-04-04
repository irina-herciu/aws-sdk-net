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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
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
namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The entity that provides configuration control over managed logs.
    /// </summary>
    public partial class ManagedLogs
    {
        private AllowAWSToRetainLogs _allowawsToRetainLogs;
        private string _encryptionKeyArn;

        /// <summary>
        /// Gets and sets the property AllowAWSToRetainLogs. 
        /// <para>
        /// Determines whether Amazon Web Services can retain logs.
        /// </para>
        /// </summary>
        public AllowAWSToRetainLogs AllowAWSToRetainLogs
        {
            get { return this._allowawsToRetainLogs; }
            set { this._allowawsToRetainLogs = value; }
        }

        // Check to see if AllowAWSToRetainLogs property is set
        internal bool IsSetAllowAWSToRetainLogs()
        {
            return this._allowawsToRetainLogs != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The Amazon resource name (ARN) of the encryption key for logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=2048)]
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

    }
}