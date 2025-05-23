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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the ListAdapters operation.
    /// Lists all adapters that match the specified filtration criteria.
    /// </summary>
    public partial class ListAdaptersRequest : AmazonTextractRequest
    {
        private DateTime? _afterCreationTime;
        private DateTime? _beforeCreationTime;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AfterCreationTime. 
        /// <para>
        /// Specifies the lower bound for the ListAdapters operation. Ensures ListAdapters returns
        /// only adapters created after the specified creation time.
        /// </para>
        /// </summary>
        public DateTime? AfterCreationTime
        {
            get { return this._afterCreationTime; }
            set { this._afterCreationTime = value; }
        }

        // Check to see if AfterCreationTime property is set
        internal bool IsSetAfterCreationTime()
        {
            return this._afterCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BeforeCreationTime. 
        /// <para>
        /// Specifies the upper bound for the ListAdapters operation. Ensures ListAdapters returns
        /// only adapters created before the specified creation time.
        /// </para>
        /// </summary>
        public DateTime? BeforeCreationTime
        {
            get { return this._beforeCreationTime; }
            set { this._beforeCreationTime = value; }
        }

        // Check to see if BeforeCreationTime property is set
        internal bool IsSetBeforeCreationTime()
        {
            return this._beforeCreationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return when listing adapters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Identifies the next page of results to return when listing adapters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}