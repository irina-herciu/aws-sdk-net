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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
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
namespace Amazon.MediaLive.Model
{
    /// <summary>
    /// Placeholder documentation for DeleteSdiSourceResponse
    /// </summary>
    public partial class DeleteSdiSourceResponse : AmazonWebServiceResponse
    {
        private SdiSource _sdiSource;

        /// <summary>
        /// Gets and sets the property SdiSource. Settings for the SDI source.
        /// </summary>
        public SdiSource SdiSource
        {
            get { return this._sdiSource; }
            set { this._sdiSource = value; }
        }

        // Check to see if SdiSource property is set
        internal bool IsSetSdiSource()
        {
            return this._sdiSource != null;
        }

    }
}