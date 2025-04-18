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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains details about the Managed Cluster configuration of the knowledge base in
    /// Amazon OpenSearch Service. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/knowledge-base-setup-osm.html">Create
    /// a vector index in OpenSearch Managed Cluster</a>.
    /// </summary>
    public partial class OpenSearchManagedClusterConfiguration
    {
        private string _domainArn;
        private string _domainEndpoint;
        private OpenSearchManagedClusterFieldMapping _fieldMapping;
        private string _vectorIndexName;

        /// <summary>
        /// Gets and sets the property DomainArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the OpenSearch domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string DomainArn
        {
            get { return this._domainArn; }
            set { this._domainArn = value; }
        }

        // Check to see if DomainArn property is set
        internal bool IsSetDomainArn()
        {
            return this._domainArn != null;
        }

        /// <summary>
        /// Gets and sets the property DomainEndpoint. 
        /// <para>
        /// The endpoint URL the OpenSearch domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string DomainEndpoint
        {
            get { return this._domainEndpoint; }
            set { this._domainEndpoint = value; }
        }

        // Check to see if DomainEndpoint property is set
        internal bool IsSetDomainEndpoint()
        {
            return this._domainEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property FieldMapping. 
        /// <para>
        /// Contains the names of the fields to which to map information about the vector store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OpenSearchManagedClusterFieldMapping FieldMapping
        {
            get { return this._fieldMapping; }
            set { this._fieldMapping = value; }
        }

        // Check to see if FieldMapping property is set
        internal bool IsSetFieldMapping()
        {
            return this._fieldMapping != null;
        }

        /// <summary>
        /// Gets and sets the property VectorIndexName. 
        /// <para>
        /// The name of the vector store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=2048)]
        public string VectorIndexName
        {
            get { return this._vectorIndexName; }
            set { this._vectorIndexName = value; }
        }

        // Check to see if VectorIndexName property is set
        internal bool IsSetVectorIndexName()
        {
            return this._vectorIndexName != null;
        }

    }
}