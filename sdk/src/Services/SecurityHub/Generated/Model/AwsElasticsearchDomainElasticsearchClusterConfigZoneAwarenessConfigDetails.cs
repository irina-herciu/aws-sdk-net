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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Configuration options for zone awareness.
    /// </summary>
    public partial class AwsElasticsearchDomainElasticsearchClusterConfigZoneAwarenessConfigDetails
    {
        private int? _availabilityZoneCount;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneCount. 
        /// <para>
        /// he number of Availability Zones that the domain uses. Valid values are 2 and 3. The
        /// default is 2.
        /// </para>
        /// </summary>
        public int? AvailabilityZoneCount
        {
            get { return this._availabilityZoneCount; }
            set { this._availabilityZoneCount = value; }
        }

        // Check to see if AvailabilityZoneCount property is set
        internal bool IsSetAvailabilityZoneCount()
        {
            return this._availabilityZoneCount.HasValue; 
        }

    }
}