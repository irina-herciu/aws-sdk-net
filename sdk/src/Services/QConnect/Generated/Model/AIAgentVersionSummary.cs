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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// The summary of the AI Agent version.
    /// </summary>
    public partial class AIAgentVersionSummary
    {
        private AIAgentSummary _aiAgentSummary;
        private long? _versionNumber;

        /// <summary>
        /// Gets and sets the property AiAgentSummary. 
        /// <para>
        /// The data for the summary of the AI Agent version.
        /// </para>
        /// </summary>
        public AIAgentSummary AiAgentSummary
        {
            get { return this._aiAgentSummary; }
            set { this._aiAgentSummary = value; }
        }

        // Check to see if AiAgentSummary property is set
        internal bool IsSetAiAgentSummary()
        {
            return this._aiAgentSummary != null;
        }

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number for this AI Agent version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? VersionNumber
        {
            get { return this._versionNumber; }
            set { this._versionNumber = value; }
        }

        // Check to see if VersionNumber property is set
        internal bool IsSetVersionNumber()
        {
            return this._versionNumber.HasValue; 
        }

    }
}