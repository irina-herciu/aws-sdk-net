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
 * Do not modify this file. This file is generated from the codestar-notifications-2019-10-15.normal.json service model.
 */
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeStarNotifications.Model
{
    /// <summary>
    /// Paginators for the CodeStarNotifications service
    ///</summary>
    public interface ICodeStarNotificationsPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListEventTypes operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListEventTypesPaginator ListEventTypes(ListEventTypesRequest request);

        /// <summary>
        /// Paginator for ListNotificationRules operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListNotificationRulesPaginator ListNotificationRules(ListNotificationRulesRequest request);

        /// <summary>
        /// Paginator for ListTargets operation
        ///</summary>
        [AWSPaginator(
            InputToken = new[] { "NextToken" },
            LimitKey = "MaxResults",
            OutputToken = new[] { "NextToken" }
        )]
        IListTargetsPaginator ListTargets(ListTargetsRequest request);
    }
}