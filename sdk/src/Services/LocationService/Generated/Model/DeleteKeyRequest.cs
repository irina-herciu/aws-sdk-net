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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
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
namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteKey operation.
    /// Deletes the specified API key. The API key must have been deactivated more than 90
    /// days previously.
    /// </summary>
    public partial class DeleteKeyRequest : AmazonLocationServiceRequest
    {
        private bool? _forceDelete;
        private string _keyName;

        /// <summary>
        /// Gets and sets the property ForceDelete. 
        /// <para>
        /// ForceDelete bypasses an API key's expiry conditions and deletes the key. Set the parameter
        /// <c>true</c> to delete the key or to <c>false</c> to not preemptively delete the API
        /// key.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>true</c>, or <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// Required: No
        /// </para>
        ///  <note> 
        /// <para>
        /// This action is irreversible. Only use ForceDelete if you are certain the key is no
        /// longer in use.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ForceDelete
        {
            get { return this._forceDelete; }
            set { this._forceDelete = value; }
        }

        // Check to see if ForceDelete property is set
        internal bool IsSetForceDelete()
        {
            return this._forceDelete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the API key to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

    }
}