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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
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
namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a gateway route target.
    /// </summary>
    public partial class GatewayRouteTarget
    {
        private int? _port;
        private GatewayRouteVirtualService _virtualService;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number of the gateway route target.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=65535)]
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
        /// Gets and sets the property VirtualService. 
        /// <para>
        /// An object that represents a virtual service gateway route target.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public GatewayRouteVirtualService VirtualService
        {
            get { return this._virtualService; }
            set { this._virtualService = value; }
        }

        // Check to see if VirtualService property is set
        internal bool IsSetVirtualService()
        {
            return this._virtualService != null;
        }

    }
}