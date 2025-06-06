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
 * Do not modify this file. This file is generated from the grafana-2020-08-18.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.ManagedGrafana.Model;

#pragma warning disable CS1570
namespace Amazon.ManagedGrafana
{
    /// <summary>
    /// <para>Interface for accessing ManagedGrafana</para>
    ///
    /// Amazon Managed Grafana is a fully managed and secure data visualization service that
    /// you can use to instantly query, correlate, and visualize operational metrics, logs,
    /// and traces from multiple sources. Amazon Managed Grafana makes it easy to deploy,
    /// operate, and scale Grafana, a widely deployed data visualization tool that is popular
    /// for its extensible data support.
    /// 
    ///  
    /// <para>
    /// With Amazon Managed Grafana, you create logically isolated Grafana servers called
    /// <i>workspaces</i>. In a workspace, you can create Grafana dashboards and visualizations
    /// to analyze your metrics, logs, and traces without having to build, package, or deploy
    /// any hardware to run Grafana servers. 
    /// </para>
    /// </summary>
    public partial interface IAmazonManagedGrafana : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IManagedGrafanaPaginatorFactory Paginators { get; }
#endif
                
        #region  AssociateLicense



        /// <summary>
        /// Assigns a Grafana Enterprise license to a workspace. To upgrade, you must use <c>ENTERPRISE</c>
        /// for the <c>licenseType</c>, and pass in a valid Grafana Labs token for the <c>grafanaToken</c>.
        /// Upgrading to Grafana Enterprise incurs additional fees. For more information, see
        /// <a href="https://docs.aws.amazon.com/grafana/latest/userguide/upgrade-to-Grafana-Enterprise.html">Upgrade
        /// a workspace to Grafana Enterprise</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateLicense service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/AssociateLicense">REST API Reference for AssociateLicense Operation</seealso>
        Task<AssociateLicenseResponse> AssociateLicenseAsync(AssociateLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspace



        /// <summary>
        /// Creates a <i>workspace</i>. In a workspace, you can create Grafana dashboards and
        /// visualizations to analyze your metrics, logs, and traces. You don't have to build,
        /// package, or deploy any hardware to run the Grafana server.
        /// 
        ///  
        /// <para>
        /// Don't use <c>CreateWorkspace</c> to modify an existing workspace. Instead, use <a
        /// href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspace.html">UpdateWorkspace</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspaceApiKey



        /// <summary>
        /// Creates a Grafana API key for the workspace. This key can be used to authenticate
        /// requests sent to the workspace's HTTP API. See <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html</a>
        /// for available APIs and example requests.
        /// 
        ///  <note> 
        /// <para>
        /// In workspaces compatible with Grafana version 9 or above, use workspace service accounts
        /// instead of API keys. API keys will be removed in a future release.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspaceApiKey service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceApiKey">REST API Reference for CreateWorkspaceApiKey Operation</seealso>
        Task<CreateWorkspaceApiKeyResponse> CreateWorkspaceApiKeyAsync(CreateWorkspaceApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspaceServiceAccount



        /// <summary>
        /// Creates a service account for the workspace. A service account can be used to call
        /// Grafana HTTP APIs, and run automated workloads. After creating the service account
        /// with the correct <c>GrafanaRole</c> for your use case, use <c>CreateWorkspaceServiceAccountToken</c>
        /// to create a token that can be used to authenticate and authorize Grafana HTTP API
        /// calls.
        /// 
        ///  
        /// <para>
        /// You can only create service accounts for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        ///  <note> 
        /// <para>
        /// For more information about service accounts, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/service-accounts.html">Service
        /// accounts</a> in the <i>Amazon Managed Grafana User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the Grafana HTTP APIs, see <a href="https://docs.aws.amazon.com/grafana/latest/userguide/Using-Grafana-APIs.html">Using
        /// Grafana HTTP APIs</a> in the <i>Amazon Managed Grafana User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceServiceAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspaceServiceAccount service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceServiceAccount">REST API Reference for CreateWorkspaceServiceAccount Operation</seealso>
        Task<CreateWorkspaceServiceAccountResponse> CreateWorkspaceServiceAccountAsync(CreateWorkspaceServiceAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspaceServiceAccountToken



        /// <summary>
        /// Creates a token that can be used to authenticate and authorize Grafana HTTP API operations
        /// for the given <a href="https://docs.aws.amazon.com/grafana/latest/userguide/service-accounts.html">workspace
        /// service account</a>. The service account acts as a user for the API operations, and
        /// defines the permissions that are used by the API.
        /// 
        ///  <important> 
        /// <para>
        /// When you create the service account token, you will receive a key that is used when
        /// calling Grafana APIs. Do not lose this key, as it will not be retrievable again.
        /// </para>
        ///  
        /// <para>
        /// If you do lose the key, you can delete the token and recreate it to receive a new
        /// key. This will disable the initial key.
        /// </para>
        ///  </important> 
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaceServiceAccountToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspaceServiceAccountToken service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/CreateWorkspaceServiceAccountToken">REST API Reference for CreateWorkspaceServiceAccountToken Operation</seealso>
        Task<CreateWorkspaceServiceAccountTokenResponse> CreateWorkspaceServiceAccountTokenAsync(CreateWorkspaceServiceAccountTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkspace



        /// <summary>
        /// Deletes an Amazon Managed Grafana workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkspaceApiKey



        /// <summary>
        /// Deletes a Grafana API key for the workspace.
        /// 
        ///  <note> 
        /// <para>
        /// In workspaces compatible with Grafana version 9 or above, use workspace service accounts
        /// instead of API keys. API keys will be removed in a future release.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceApiKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspaceApiKey service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceApiKey">REST API Reference for DeleteWorkspaceApiKey Operation</seealso>
        Task<DeleteWorkspaceApiKeyResponse> DeleteWorkspaceApiKeyAsync(DeleteWorkspaceApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkspaceServiceAccount



        /// <summary>
        /// Deletes a workspace service account from the workspace.
        /// 
        ///  
        /// <para>
        /// This will delete any tokens created for the service account, as well. If the tokens
        /// are currently in use, the will fail to authenticate / authorize after they are deleted.
        /// </para>
        ///  
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceServiceAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspaceServiceAccount service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceServiceAccount">REST API Reference for DeleteWorkspaceServiceAccount Operation</seealso>
        Task<DeleteWorkspaceServiceAccountResponse> DeleteWorkspaceServiceAccountAsync(DeleteWorkspaceServiceAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkspaceServiceAccountToken



        /// <summary>
        /// Deletes a token for the workspace service account.
        /// 
        ///  
        /// <para>
        /// This will disable the key associated with the token. If any automation is currently
        /// using the key, it will no longer be authenticated or authorized to perform actions
        /// with the Grafana HTTP APIs.
        /// </para>
        ///  
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceServiceAccountToken service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspaceServiceAccountToken service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DeleteWorkspaceServiceAccountToken">REST API Reference for DeleteWorkspaceServiceAccountToken Operation</seealso>
        Task<DeleteWorkspaceServiceAccountTokenResponse> DeleteWorkspaceServiceAccountTokenAsync(DeleteWorkspaceServiceAccountTokenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspace



        /// <summary>
        /// Displays information about one Amazon Managed Grafana workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        Task<DescribeWorkspaceResponse> DescribeWorkspaceAsync(DescribeWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspaceAuthentication



        /// <summary>
        /// Displays information about the authentication methods used in one Amazon Managed Grafana
        /// workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceAuthentication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceAuthentication service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceAuthentication">REST API Reference for DescribeWorkspaceAuthentication Operation</seealso>
        Task<DescribeWorkspaceAuthenticationResponse> DescribeWorkspaceAuthenticationAsync(DescribeWorkspaceAuthenticationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspaceConfiguration



        /// <summary>
        /// Gets the current configuration string for the given workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceConfiguration service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        Task<DescribeWorkspaceConfigurationResponse> DescribeWorkspaceConfigurationAsync(DescribeWorkspaceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisassociateLicense



        /// <summary>
        /// Removes the Grafana Enterprise license from a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLicense service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateLicense service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/DisassociateLicense">REST API Reference for DisassociateLicense Operation</seealso>
        Task<DisassociateLicenseResponse> DisassociateLicenseAsync(DisassociateLicenseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPermissions



        /// <summary>
        /// Lists the users and groups who have the Grafana <c>Admin</c> and <c>Editor</c> roles
        /// in this workspace. If you use this operation without specifying <c>userId</c> or <c>groupId</c>,
        /// the operation returns the roles of all users and groups. If you specify a <c>userId</c>
        /// or a <c>groupId</c>, only the roles for that user or group are returned. If you do
        /// this, you can specify only one <c>userId</c> or one <c>groupId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPermissions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListPermissions">REST API Reference for ListPermissions Operation</seealso>
        Task<ListPermissionsResponse> ListPermissionsAsync(ListPermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// The <c>ListTagsForResource</c> operation returns the tags that are associated with
        /// the Amazon Managed Service for Grafana resource specified by the <c>resourceArn</c>.
        /// Currently, the only resource that can be tagged is a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVersions



        /// <summary>
        /// Lists available versions of Grafana. These are available when calling <c>CreateWorkspace</c>.
        /// Optionally, include a workspace to list the versions to which it can be upgraded.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListVersions">REST API Reference for ListVersions Operation</seealso>
        Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkspaces



        /// <summary>
        /// Returns a list of Amazon Managed Grafana workspaces in the account, with some information
        /// about each workspace. For more complete information about one workspace, use <a href="https://docs.aws.amazon.com/AAMG/latest/APIReference/API_DescribeWorkspace.html">DescribeWorkspace</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkspaceServiceAccounts



        /// <summary>
        /// Returns a list of service accounts for a workspace.
        /// 
        ///  
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceServiceAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaceServiceAccounts service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaceServiceAccounts">REST API Reference for ListWorkspaceServiceAccounts Operation</seealso>
        Task<ListWorkspaceServiceAccountsResponse> ListWorkspaceServiceAccountsAsync(ListWorkspaceServiceAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkspaceServiceAccountTokens



        /// <summary>
        /// Returns a list of tokens for a workspace service account.
        /// 
        ///  <note> 
        /// <para>
        /// This does not return the key for each token. You cannot access keys after they are
        /// created. To create a new key, delete the token and recreate it.
        /// </para>
        ///  </note> 
        /// <para>
        /// Service accounts are only available for workspaces that are compatible with Grafana
        /// version 9 and above.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaceServiceAccountTokens service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaceServiceAccountTokens service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/ListWorkspaceServiceAccountTokens">REST API Reference for ListWorkspaceServiceAccountTokens Operation</seealso>
        Task<ListWorkspaceServiceAccountTokensResponse> ListWorkspaceServiceAccountTokensAsync(ListWorkspaceServiceAccountTokensRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// The <c>TagResource</c> operation associates tags with an Amazon Managed Grafana resource.
        /// Currently, the only resource that can be tagged is workspaces. 
        /// 
        ///  
        /// <para>
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// The <c>UntagResource</c> operation removes the association of the tag with the Amazon
        /// Managed Grafana resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePermissions



        /// <summary>
        /// Updates which users in a workspace have the Grafana <c>Admin</c> or <c>Editor</c>
        /// roles.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePermissions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePermissions service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdatePermissions">REST API Reference for UpdatePermissions Operation</seealso>
        Task<UpdatePermissionsResponse> UpdatePermissionsAsync(UpdatePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkspace



        /// <summary>
        /// Modifies an existing Amazon Managed Grafana workspace. If you use this operation and
        /// omit any optional parameters, the existing values of those parameters are not changed.
        /// 
        ///  
        /// <para>
        /// To modify the user authentication methods that the workspace uses, such as SAML or
        /// IAM Identity Center, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdateWorkspaceAuthentication.html">UpdateWorkspaceAuthentication</a>.
        /// </para>
        ///  
        /// <para>
        /// To modify which users in the workspace have the <c>Admin</c> and <c>Editor</c> Grafana
        /// roles, use <a href="https://docs.aws.amazon.com/grafana/latest/APIReference/API_UpdatePermissions.html">UpdatePermissions</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspace service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspace">REST API Reference for UpdateWorkspace Operation</seealso>
        Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(UpdateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkspaceAuthentication



        /// <summary>
        /// Use this operation to define the identity provider (IdP) that this workspace authenticates
        /// users from, using SAML. You can also map SAML assertion attributes to workspace user
        /// information and define which groups in the assertion attribute are to have the <c>Admin</c>
        /// and <c>Editor</c> roles in the workspace.
        /// 
        ///  <note> 
        /// <para>
        /// Changes to the authentication method for a workspace may take a few minutes to take
        /// effect.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAuthentication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspaceAuthentication service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceAuthentication">REST API Reference for UpdateWorkspaceAuthentication Operation</seealso>
        Task<UpdateWorkspaceAuthenticationResponse> UpdateWorkspaceAuthenticationAsync(UpdateWorkspaceAuthenticationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkspaceConfiguration



        /// <summary>
        /// Updates the configuration string for the given workspace
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspaceConfiguration service method, as returned by ManagedGrafana.</returns>
        /// <exception cref="Amazon.ManagedGrafana.Model.AccessDeniedException">
        /// You do not have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ConflictException">
        /// A resource was in an inconsistent state during an update or a deletion.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.InternalServerException">
        /// Unexpected error while processing the request. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ThrottlingException">
        /// The request was denied because of request throttling. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.ManagedGrafana.Model.ValidationException">
        /// The value of a parameter in the request caused an error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/grafana-2020-08-18/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
        Task<UpdateWorkspaceConfigurationResponse> UpdateWorkspaceConfigurationAsync(UpdateWorkspaceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

        #region Static factory interface methods
#if NET8_0_OR_GREATER
// Warning CA1033 is issued when the child types can not call the method defined in parent types.
// In this use case the intended caller is only meant to be the interface as a factory
// method to create the child types. Given the SDK use case the warning can be ignored.
#pragma warning disable CA1033
        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonManagedGrafanaConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonManagedGrafanaConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonManagedGrafanaConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonManagedGrafanaConfig to create AmazonManagedGrafanaClient");
            }

            return awsCredentials == null ? 
                    new AmazonManagedGrafanaClient(serviceClientConfig) :
                    new AmazonManagedGrafanaClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}