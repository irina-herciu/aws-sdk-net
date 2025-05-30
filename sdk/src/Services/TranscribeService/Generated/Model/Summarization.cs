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
 * Do not modify this file. This file is generated from the transcribe-2017-10-26.normal.json service model.
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
namespace Amazon.TranscribeService.Model
{
    /// <summary>
    /// Contains <c>GenerateAbstractiveSummary</c>, which is a required parameter if you want
    /// to enable Generative call summarization in your Call Analytics request.
    /// </summary>
    public partial class Summarization
    {
        private bool? _generateAbstractiveSummary;

        /// <summary>
        /// Gets and sets the property GenerateAbstractiveSummary. 
        /// <para>
        /// Enables Generative call summarization in your Call Analytics request
        /// </para>
        ///  
        /// <para>
        /// Generative call summarization provides a summary of the transcript including important
        /// components discussed in the conversation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/transcribe/latest/dg/tca-enable-summarization.html">Enabling
        /// generative call summarization</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? GenerateAbstractiveSummary
        {
            get { return this._generateAbstractiveSummary; }
            set { this._generateAbstractiveSummary = value; }
        }

        // Check to see if GenerateAbstractiveSummary property is set
        internal bool IsSetGenerateAbstractiveSummary()
        {
            return this._generateAbstractiveSummary.HasValue; 
        }

    }
}