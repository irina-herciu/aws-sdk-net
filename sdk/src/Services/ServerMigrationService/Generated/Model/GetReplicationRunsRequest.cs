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
 * Do not modify this file. This file is generated from the sms-2016-10-24.normal.json service model.
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
namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the GetReplicationRuns operation.
    /// Describes the replication runs for the specified replication job.
    /// </summary>
    public partial class GetReplicationRunsRequest : AmazonServerMigrationServiceRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _replicationJobId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call. The default value is 50.
        /// To retrieve the remaining results, make another call with the returned <c>NextToken</c>
        /// value.
        /// </para>
        /// </summary>
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
        /// The token for the next set of results.
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
        /// Gets and sets the property ReplicationJobId. 
        /// <para>
        /// The ID of the replication job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReplicationJobId
        {
            get { return this._replicationJobId; }
            set { this._replicationJobId = value; }
        }

        // Check to see if ReplicationJobId property is set
        internal bool IsSetReplicationJobId()
        {
            return this._replicationJobId != null;
        }

    }
}