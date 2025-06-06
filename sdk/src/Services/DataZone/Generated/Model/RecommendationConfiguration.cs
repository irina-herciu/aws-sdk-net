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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The recommendation to be updated as part of the <c>UpdateDataSource</c> action.
    /// </summary>
    public partial class RecommendationConfiguration
    {
        private bool? _enableBusinessNameGeneration;

        /// <summary>
        /// Gets and sets the property EnableBusinessNameGeneration. 
        /// <para>
        /// Specifies whether automatic business name generation is to be enabled or not as part
        /// of the recommendation configuration.
        /// </para>
        /// </summary>
        public bool? EnableBusinessNameGeneration
        {
            get { return this._enableBusinessNameGeneration; }
            set { this._enableBusinessNameGeneration = value; }
        }

        // Check to see if EnableBusinessNameGeneration property is set
        internal bool IsSetEnableBusinessNameGeneration()
        {
            return this._enableBusinessNameGeneration.HasValue; 
        }

    }
}