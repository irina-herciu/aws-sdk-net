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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// The evaluator model used in knowledge base evaluation job or in model evaluation job
    /// that use a model as judge. This model computes all evaluation related metrics.
    /// </summary>
    public partial class BedrockEvaluatorModel
    {
        private string _modelIdentifier;

        /// <summary>
        /// Gets and sets the property ModelIdentifier. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the evaluator model used used in knowledge base
        /// evaluation job or in model evaluation job that use a model as judge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ModelIdentifier
        {
            get { return this._modelIdentifier; }
            set { this._modelIdentifier = value; }
        }

        // Check to see if ModelIdentifier property is set
        internal bool IsSetModelIdentifier()
        {
            return this._modelIdentifier != null;
        }

    }
}