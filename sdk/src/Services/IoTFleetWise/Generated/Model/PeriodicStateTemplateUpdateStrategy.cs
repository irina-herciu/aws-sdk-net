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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Vehicles associated with the state template will stream telemetry data during a specified
    /// time period.
    /// </summary>
    public partial class PeriodicStateTemplateUpdateStrategy
    {
        private TimePeriod _stateTemplateUpdateRate;

        /// <summary>
        /// Gets and sets the property StateTemplateUpdateRate.
        /// </summary>
        [AWSProperty(Required=true)]
        public TimePeriod StateTemplateUpdateRate
        {
            get { return this._stateTemplateUpdateRate; }
            set { this._stateTemplateUpdateRate = value; }
        }

        // Check to see if StateTemplateUpdateRate property is set
        internal bool IsSetStateTemplateUpdateRate()
        {
            return this._stateTemplateUpdateRate != null;
        }

    }
}