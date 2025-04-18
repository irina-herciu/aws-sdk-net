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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Paginators for the Batch service
    ///</summary>
    public interface IBatchPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeComputeEnvironments operation
        ///</summary>
        IDescribeComputeEnvironmentsPaginator DescribeComputeEnvironments(DescribeComputeEnvironmentsRequest request);

        /// <summary>
        /// Paginator for DescribeJobDefinitions operation
        ///</summary>
        IDescribeJobDefinitionsPaginator DescribeJobDefinitions(DescribeJobDefinitionsRequest request);

        /// <summary>
        /// Paginator for DescribeJobQueues operation
        ///</summary>
        IDescribeJobQueuesPaginator DescribeJobQueues(DescribeJobQueuesRequest request);

        /// <summary>
        /// Paginator for ListConsumableResources operation
        ///</summary>
        IListConsumableResourcesPaginator ListConsumableResources(ListConsumableResourcesRequest request);

        /// <summary>
        /// Paginator for ListJobs operation
        ///</summary>
        IListJobsPaginator ListJobs(ListJobsRequest request);

        /// <summary>
        /// Paginator for ListJobsByConsumableResource operation
        ///</summary>
        IListJobsByConsumableResourcePaginator ListJobsByConsumableResource(ListJobsByConsumableResourceRequest request);

        /// <summary>
        /// Paginator for ListSchedulingPolicies operation
        ///</summary>
        IListSchedulingPoliciesPaginator ListSchedulingPolicies(ListSchedulingPoliciesRequest request);
    }
}