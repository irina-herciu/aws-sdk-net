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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the ModifyRouteServer operation.
    /// </summary>
    public partial class ModifyRouteServerResponse : AmazonWebServiceResponse
    {
        private RouteServer _routeServer;

        /// <summary>
        /// Gets and sets the property RouteServer. 
        /// <para>
        /// Information about the modified route server.
        /// </para>
        /// </summary>
        public RouteServer RouteServer
        {
            get { return this._routeServer; }
            set { this._routeServer = value; }
        }

        // Check to see if RouteServer property is set
        internal bool IsSetRouteServer()
        {
            return this._routeServer != null;
        }

    }
}