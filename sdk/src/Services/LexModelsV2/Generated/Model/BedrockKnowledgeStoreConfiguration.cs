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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Contains details about the configuration of a Amazon Bedrock knowledge base.
    /// </summary>
    public partial class BedrockKnowledgeStoreConfiguration
    {
        private string _bedrockKnowledgeBaseArn;
        private bool? _exactResponse;
        private BedrockKnowledgeStoreExactResponseFields _exactResponseFields;

        /// <summary>
        /// Gets and sets the property BedrockKnowledgeBaseArn. 
        /// <para>
        /// The base ARN of the knowledge base used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string BedrockKnowledgeBaseArn
        {
            get { return this._bedrockKnowledgeBaseArn; }
            set { this._bedrockKnowledgeBaseArn = value; }
        }

        // Check to see if BedrockKnowledgeBaseArn property is set
        internal bool IsSetBedrockKnowledgeBaseArn()
        {
            return this._bedrockKnowledgeBaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExactResponse. 
        /// <para>
        /// Specifies whether to return an exact response, or to return an answer generated by
        /// the model, using the fields you specify from the database.
        /// </para>
        /// </summary>
        public bool? ExactResponse
        {
            get { return this._exactResponse; }
            set { this._exactResponse = value; }
        }

        // Check to see if ExactResponse property is set
        internal bool IsSetExactResponse()
        {
            return this._exactResponse.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExactResponseFields. 
        /// <para>
        /// Contains the names of the fields used for an exact response to the user.
        /// </para>
        /// </summary>
        public BedrockKnowledgeStoreExactResponseFields ExactResponseFields
        {
            get { return this._exactResponseFields; }
            set { this._exactResponseFields = value; }
        }

        // Check to see if ExactResponseFields property is set
        internal bool IsSetExactResponseFields()
        {
            return this._exactResponseFields != null;
        }

    }
}