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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// Container for the parameters to the ListSearchJobResults operation.
    /// This operation returns a list of a specified search job.
    /// </summary>
    public partial class ListSearchJobResultsRequest : AmazonBackupSearchRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _searchJobIdentifier;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of resource list items to be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The next item following a partial list of returned search job results.
        /// </para>
        ///  
        /// <para>
        /// For example, if a request is made to return <c>MaxResults</c> number of search job
        /// results, <c>NextToken</c> allows you to return more items in your list starting at
        /// the location pointed to by the next token.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property SearchJobIdentifier. 
        /// <para>
        /// The unique string that specifies the search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SearchJobIdentifier
        {
            get { return this._searchJobIdentifier; }
            set { this._searchJobIdentifier = value; }
        }

        // Check to see if SearchJobIdentifier property is set
        internal bool IsSetSearchJobIdentifier()
        {
            return this._searchJobIdentifier != null;
        }

    }
}