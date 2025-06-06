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
 * Do not modify this file. This file is generated from the kinesisanalytics-2015-08-14.normal.json service model.
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
namespace Amazon.KinesisAnalytics.Model
{
    /// <summary>
    /// Provides updates to the parallelism count.
    /// </summary>
    public partial class InputParallelismUpdate
    {
        private int? _countUpdate;

        /// <summary>
        /// Gets and sets the property CountUpdate. 
        /// <para>
        /// Number of in-application streams to create for the specified streaming source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public int? CountUpdate
        {
            get { return this._countUpdate; }
            set { this._countUpdate = value; }
        }

        // Check to see if CountUpdate property is set
        internal bool IsSetCountUpdate()
        {
            return this._countUpdate.HasValue; 
        }

    }
}