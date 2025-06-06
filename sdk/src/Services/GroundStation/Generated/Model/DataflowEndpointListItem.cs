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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
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
namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// Item in a list of <c>DataflowEndpoint</c> groups.
    /// </summary>
    public partial class DataflowEndpointListItem
    {
        private string _dataflowEndpointGroupArn;
        private string _dataflowEndpointGroupId;

        /// <summary>
        /// Gets and sets the property DataflowEndpointGroupArn. 
        /// <para>
        /// ARN of a dataflow endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=97, Max=146)]
        public string DataflowEndpointGroupArn
        {
            get { return this._dataflowEndpointGroupArn; }
            set { this._dataflowEndpointGroupArn = value; }
        }

        // Check to see if DataflowEndpointGroupArn property is set
        internal bool IsSetDataflowEndpointGroupArn()
        {
            return this._dataflowEndpointGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataflowEndpointGroupId. 
        /// <para>
        /// UUID of a dataflow endpoint group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DataflowEndpointGroupId
        {
            get { return this._dataflowEndpointGroupId; }
            set { this._dataflowEndpointGroupId = value; }
        }

        // Check to see if DataflowEndpointGroupId property is set
        internal bool IsSetDataflowEndpointGroupId()
        {
            return this._dataflowEndpointGroupId != null;
        }

    }
}