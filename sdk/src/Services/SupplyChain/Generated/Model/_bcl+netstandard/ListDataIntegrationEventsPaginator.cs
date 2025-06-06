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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// Base class for ListDataIntegrationEvents paginators.
    /// </summary>
    internal sealed partial class ListDataIntegrationEventsPaginator : IPaginator<ListDataIntegrationEventsResponse>, IListDataIntegrationEventsPaginator
    {
        private readonly IAmazonSupplyChain _client;
        private readonly ListDataIntegrationEventsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListDataIntegrationEventsResponse> Responses => new PaginatedResponse<ListDataIntegrationEventsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Events
        /// </summary>
        public IPaginatedEnumerable<DataIntegrationEvent> Events => 
            new PaginatedResultKeyResponse<ListDataIntegrationEventsResponse, DataIntegrationEvent>(this, (i) => i.Events ?? new List<DataIntegrationEvent>());

        internal ListDataIntegrationEventsPaginator(IAmazonSupplyChain client, ListDataIntegrationEventsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListDataIntegrationEventsResponse> IPaginator<ListDataIntegrationEventsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListDataIntegrationEventsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListDataIntegrationEvents(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListDataIntegrationEventsResponse> IPaginator<ListDataIntegrationEventsResponse>.PaginateAsync([System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListDataIntegrationEventsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListDataIntegrationEventsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}