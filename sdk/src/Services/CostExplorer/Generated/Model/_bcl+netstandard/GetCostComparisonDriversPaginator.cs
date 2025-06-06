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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Base class for GetCostComparisonDrivers paginators.
    /// </summary>
    internal sealed partial class GetCostComparisonDriversPaginator : IPaginator<GetCostComparisonDriversResponse>, IGetCostComparisonDriversPaginator
    {
        private readonly IAmazonCostExplorer _client;
        private readonly GetCostComparisonDriversRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<GetCostComparisonDriversResponse> Responses => new PaginatedResponse<GetCostComparisonDriversResponse>(this);

        /// <summary>
        /// Enumerable containing all of the CostComparisonDrivers
        /// </summary>
        public IPaginatedEnumerable<CostComparisonDriver> CostComparisonDrivers => 
            new PaginatedResultKeyResponse<GetCostComparisonDriversResponse, CostComparisonDriver>(this, (i) => i.CostComparisonDrivers ?? new List<CostComparisonDriver>());

        internal GetCostComparisonDriversPaginator(IAmazonCostExplorer client, GetCostComparisonDriversRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<GetCostComparisonDriversResponse> IPaginator<GetCostComparisonDriversResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextPageToken = _request.NextPageToken;
            GetCostComparisonDriversResponse response;
            do
            {
                _request.NextPageToken = nextPageToken;
                response = _client.GetCostComparisonDrivers(_request);
                nextPageToken = response.NextPageToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextPageToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<GetCostComparisonDriversResponse> IPaginator<GetCostComparisonDriversResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextPageToken = _request.NextPageToken;
            GetCostComparisonDriversResponse response;
            do
            {
                _request.NextPageToken = nextPageToken;
                response = await _client.GetCostComparisonDriversAsync(_request, cancellationToken).ConfigureAwait(false);
                nextPageToken = response.NextPageToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextPageToken));
        }
#endif
    }
}