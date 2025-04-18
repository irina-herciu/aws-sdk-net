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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Paginators for the QuickSight service
    ///</summary>
    public interface IQuickSightPaginatorFactory
    {

        /// <summary>
        /// Paginator for DescribeFolderPermissions operation
        ///</summary>
        IDescribeFolderPermissionsPaginator DescribeFolderPermissions(DescribeFolderPermissionsRequest request);

        /// <summary>
        /// Paginator for DescribeFolderResolvedPermissions operation
        ///</summary>
        IDescribeFolderResolvedPermissionsPaginator DescribeFolderResolvedPermissions(DescribeFolderResolvedPermissionsRequest request);

        /// <summary>
        /// Paginator for ListAnalyses operation
        ///</summary>
        IListAnalysesPaginator ListAnalyses(ListAnalysesRequest request);

        /// <summary>
        /// Paginator for ListAssetBundleExportJobs operation
        ///</summary>
        IListAssetBundleExportJobsPaginator ListAssetBundleExportJobs(ListAssetBundleExportJobsRequest request);

        /// <summary>
        /// Paginator for ListAssetBundleImportJobs operation
        ///</summary>
        IListAssetBundleImportJobsPaginator ListAssetBundleImportJobs(ListAssetBundleImportJobsRequest request);

        /// <summary>
        /// Paginator for ListBrands operation
        ///</summary>
        IListBrandsPaginator ListBrands(ListBrandsRequest request);

        /// <summary>
        /// Paginator for ListCustomPermissions operation
        ///</summary>
        IListCustomPermissionsPaginator ListCustomPermissions(ListCustomPermissionsRequest request);

        /// <summary>
        /// Paginator for ListDashboards operation
        ///</summary>
        IListDashboardsPaginator ListDashboards(ListDashboardsRequest request);

        /// <summary>
        /// Paginator for ListDashboardVersions operation
        ///</summary>
        IListDashboardVersionsPaginator ListDashboardVersions(ListDashboardVersionsRequest request);

        /// <summary>
        /// Paginator for ListDataSets operation
        ///</summary>
        IListDataSetsPaginator ListDataSets(ListDataSetsRequest request);

        /// <summary>
        /// Paginator for ListDataSources operation
        ///</summary>
        IListDataSourcesPaginator ListDataSources(ListDataSourcesRequest request);

        /// <summary>
        /// Paginator for ListFolderMembers operation
        ///</summary>
        IListFolderMembersPaginator ListFolderMembers(ListFolderMembersRequest request);

        /// <summary>
        /// Paginator for ListFolders operation
        ///</summary>
        IListFoldersPaginator ListFolders(ListFoldersRequest request);

        /// <summary>
        /// Paginator for ListFoldersForResource operation
        ///</summary>
        IListFoldersForResourcePaginator ListFoldersForResource(ListFoldersForResourceRequest request);

        /// <summary>
        /// Paginator for ListGroupMemberships operation
        ///</summary>
        IListGroupMembershipsPaginator ListGroupMemberships(ListGroupMembershipsRequest request);

        /// <summary>
        /// Paginator for ListGroups operation
        ///</summary>
        IListGroupsPaginator ListGroups(ListGroupsRequest request);

        /// <summary>
        /// Paginator for ListIAMPolicyAssignments operation
        ///</summary>
        IListIAMPolicyAssignmentsPaginator ListIAMPolicyAssignments(ListIAMPolicyAssignmentsRequest request);

        /// <summary>
        /// Paginator for ListIAMPolicyAssignmentsForUser operation
        ///</summary>
        IListIAMPolicyAssignmentsForUserPaginator ListIAMPolicyAssignmentsForUser(ListIAMPolicyAssignmentsForUserRequest request);

        /// <summary>
        /// Paginator for ListIngestions operation
        ///</summary>
        IListIngestionsPaginator ListIngestions(ListIngestionsRequest request);

        /// <summary>
        /// Paginator for ListNamespaces operation
        ///</summary>
        IListNamespacesPaginator ListNamespaces(ListNamespacesRequest request);

        /// <summary>
        /// Paginator for ListRoleMemberships operation
        ///</summary>
        IListRoleMembershipsPaginator ListRoleMemberships(ListRoleMembershipsRequest request);

        /// <summary>
        /// Paginator for ListTemplateAliases operation
        ///</summary>
        IListTemplateAliasesPaginator ListTemplateAliases(ListTemplateAliasesRequest request);

        /// <summary>
        /// Paginator for ListTemplates operation
        ///</summary>
        IListTemplatesPaginator ListTemplates(ListTemplatesRequest request);

        /// <summary>
        /// Paginator for ListTemplateVersions operation
        ///</summary>
        IListTemplateVersionsPaginator ListTemplateVersions(ListTemplateVersionsRequest request);

        /// <summary>
        /// Paginator for ListThemes operation
        ///</summary>
        IListThemesPaginator ListThemes(ListThemesRequest request);

        /// <summary>
        /// Paginator for ListThemeVersions operation
        ///</summary>
        IListThemeVersionsPaginator ListThemeVersions(ListThemeVersionsRequest request);

        /// <summary>
        /// Paginator for ListTopics operation
        ///</summary>
        IListTopicsPaginator ListTopics(ListTopicsRequest request);

        /// <summary>
        /// Paginator for ListUserGroups operation
        ///</summary>
        IListUserGroupsPaginator ListUserGroups(ListUserGroupsRequest request);

        /// <summary>
        /// Paginator for ListUsers operation
        ///</summary>
        IListUsersPaginator ListUsers(ListUsersRequest request);

        /// <summary>
        /// Paginator for ListVPCConnections operation
        ///</summary>
        IListVPCConnectionsPaginator ListVPCConnections(ListVPCConnectionsRequest request);

        /// <summary>
        /// Paginator for SearchAnalyses operation
        ///</summary>
        ISearchAnalysesPaginator SearchAnalyses(SearchAnalysesRequest request);

        /// <summary>
        /// Paginator for SearchDashboards operation
        ///</summary>
        ISearchDashboardsPaginator SearchDashboards(SearchDashboardsRequest request);

        /// <summary>
        /// Paginator for SearchDataSets operation
        ///</summary>
        ISearchDataSetsPaginator SearchDataSets(SearchDataSetsRequest request);

        /// <summary>
        /// Paginator for SearchDataSources operation
        ///</summary>
        ISearchDataSourcesPaginator SearchDataSources(SearchDataSourcesRequest request);

        /// <summary>
        /// Paginator for SearchFolders operation
        ///</summary>
        ISearchFoldersPaginator SearchFolders(SearchFoldersRequest request);

        /// <summary>
        /// Paginator for SearchGroups operation
        ///</summary>
        ISearchGroupsPaginator SearchGroups(SearchGroupsRequest request);

        /// <summary>
        /// Paginator for SearchTopics operation
        ///</summary>
        ISearchTopicsPaginator SearchTopics(SearchTopicsRequest request);
    }
}