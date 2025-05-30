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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
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
namespace Amazon.PrometheusService.Model
{
    /// <summary>
    /// Filtering criteria that determine which queries are logged.
    /// </summary>
    public partial class LoggingFilter
    {
        private long? _qspThreshold;

        /// <summary>
        /// Gets and sets the property QspThreshold. 
        /// <para>
        /// The Query Samples Processed (QSP) threshold above which queries will be logged. Queries
        /// processing more samples than this threshold will be captured in logs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public long? QspThreshold
        {
            get { return this._qspThreshold; }
            set { this._qspThreshold = value; }
        }

        // Check to see if QspThreshold property is set
        internal bool IsSetQspThreshold()
        {
            return this._qspThreshold.HasValue; 
        }

    }
}