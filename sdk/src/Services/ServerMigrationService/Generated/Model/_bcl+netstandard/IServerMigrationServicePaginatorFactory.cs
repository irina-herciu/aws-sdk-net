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
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.ServerMigrationService.Model
{
    /// <summary>
    /// Paginators for the ServerMigrationService service
    ///</summary>
    public interface IServerMigrationServicePaginatorFactory
    {

        /// <summary>
        /// Paginator for GetConnectors operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetConnectorsPaginator GetConnectors(GetConnectorsRequest request);

        /// <summary>
        /// Paginator for GetReplicationJobs operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetReplicationJobsPaginator GetReplicationJobs(GetReplicationJobsRequest request);

        /// <summary>
        /// Paginator for GetReplicationRuns operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetReplicationRunsPaginator GetReplicationRuns(GetReplicationRunsRequest request);

        /// <summary>
        /// Paginator for GetServers operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IGetServersPaginator GetServers(GetServersRequest request);
    }
}