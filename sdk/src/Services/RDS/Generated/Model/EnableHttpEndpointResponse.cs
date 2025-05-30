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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This is the response object from the EnableHttpEndpoint operation.
    /// </summary>
    public partial class EnableHttpEndpointResponse : AmazonWebServiceResponse
    {
        private bool? _httpEndpointEnabled;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property HttpEndpointEnabled. 
        /// <para>
        /// Indicates whether the HTTP endpoint is enabled or disabled for the DB cluster.
        /// </para>
        /// </summary>
        public bool? HttpEndpointEnabled
        {
            get { return this._httpEndpointEnabled; }
            set { this._httpEndpointEnabled = value; }
        }

        // Check to see if HttpEndpointEnabled property is set
        internal bool IsSetHttpEndpointEnabled()
        {
            return this._httpEndpointEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the DB cluster.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}