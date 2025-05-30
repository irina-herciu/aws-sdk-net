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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
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
namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Contains the details for an SFTP connector connection.
    /// </summary>
    public partial class SftpConnectorConnectionDetails
    {
        private string _hostKey;

        /// <summary>
        /// Gets and sets the property HostKey. 
        /// <para>
        /// The SSH public key of the remote SFTP server. This is returned during the initial
        /// connection attempt when you call <c>TestConnection</c>. It allows you to retrieve
        /// the valid server host key to update the connector when you are unable to obtain it
        /// in advance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string HostKey
        {
            get { return this._hostKey; }
            set { this._hostKey = value; }
        }

        // Check to see if HostKey property is set
        internal bool IsSetHostKey()
        {
            return this._hostKey != null;
        }

    }
}