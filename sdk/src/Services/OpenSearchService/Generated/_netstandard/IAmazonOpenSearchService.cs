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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.OpenSearchService.Model;

#pragma warning disable CS1570
namespace Amazon.OpenSearchService
{
    /// <summary>
    /// <para>Interface for accessing OpenSearchService</para>
    ///
    /// Use the Amazon OpenSearch Service configuration API to create, configure, and manage
    /// OpenSearch Service domains. The endpoint for configuration service requests is Region
    /// specific: es.<i>region</i>.amazonaws.com. For example, es.us-east-1.amazonaws.com.
    /// For a current list of supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#service-regions">Amazon
    /// Web Services service endpoints</a>.
    /// </summary>
    public partial interface IAmazonOpenSearchService : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IOpenSearchServicePaginatorFactory Paginators { get; }
#endif
                
        #region  AcceptInboundConnection



        /// <summary>
        /// Allows the destination Amazon OpenSearch Service domain owner to accept an inbound
        /// cross-cluster search connection request. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AcceptInboundConnection">REST API Reference for AcceptInboundConnection Operation</seealso>
        Task<AcceptInboundConnectionResponse> AcceptInboundConnectionAsync(AcceptInboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddDataSource



        /// <summary>
        /// Creates a new direct-query data source to the specified domain. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-creating.html">Creating
        /// Amazon OpenSearch Service data source integrations with Amazon S3</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AddDataSource">REST API Reference for AddDataSource Operation</seealso>
        Task<AddDataSourceResponse> AddDataSourceAsync(AddDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddDirectQueryDataSource



        /// <summary>
        /// Adds a new data source in Amazon OpenSearch Service so that you can perform direct
        /// queries on external data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddDirectQueryDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddDirectQueryDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AddDirectQueryDataSource">REST API Reference for AddDirectQueryDataSource Operation</seealso>
        Task<AddDirectQueryDataSourceResponse> AddDirectQueryDataSourceAsync(AddDirectQueryDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AddTags



        /// <summary>
        /// Attaches tags to an existing Amazon OpenSearch Service domain, data source, or application.
        /// 
        /// 
        ///  
        /// <para>
        /// Tags are a set of case-sensitive key-value pairs. A domain, data source, or application
        /// can have up to 10 tags. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-awsresourcetagging.html">Tagging
        /// Amazon OpenSearch Service resources</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AddTags">REST API Reference for AddTags Operation</seealso>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociatePackage



        /// <summary>
        /// Associates a package with an Amazon OpenSearch Service domain. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AssociatePackage">REST API Reference for AssociatePackage Operation</seealso>
        Task<AssociatePackageResponse> AssociatePackageAsync(AssociatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AssociatePackages



        /// <summary>
        /// Operation in the Amazon OpenSearch Service API for associating multiple packages with
        /// a domain simultaneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociatePackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociatePackages service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AssociatePackages">REST API Reference for AssociatePackages Operation</seealso>
        Task<AssociatePackagesResponse> AssociatePackagesAsync(AssociatePackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AuthorizeVpcEndpointAccess



        /// <summary>
        /// Provides access to an Amazon OpenSearch Service domain through the use of an interface
        /// VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeVpcEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeVpcEndpointAccess service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/AuthorizeVpcEndpointAccess">REST API Reference for AuthorizeVpcEndpointAccess Operation</seealso>
        Task<AuthorizeVpcEndpointAccessResponse> AuthorizeVpcEndpointAccessAsync(AuthorizeVpcEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelDomainConfigChange



        /// <summary>
        /// Cancels a pending configuration change on an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelDomainConfigChange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelDomainConfigChange service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CancelDomainConfigChange">REST API Reference for CancelDomainConfigChange Operation</seealso>
        Task<CancelDomainConfigChangeResponse> CancelDomainConfigChangeAsync(CancelDomainConfigChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelServiceSoftwareUpdate



        /// <summary>
        /// Cancels a scheduled service software update for an Amazon OpenSearch Service domain.
        /// You can only perform this operation before the <c>AutomatedUpdateDate</c> and when
        /// the domain's <c>UpdateStatus</c> is <c>PENDING_UPDATE</c>. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">Service
        /// software updates in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelServiceSoftwareUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelServiceSoftwareUpdate service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CancelServiceSoftwareUpdate">REST API Reference for CancelServiceSoftwareUpdate Operation</seealso>
        Task<CancelServiceSoftwareUpdateResponse> CancelServiceSoftwareUpdateAsync(CancelServiceSoftwareUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateApplication



        /// <summary>
        /// Creates an OpenSearch UI application. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/application.html">Using
        /// the OpenSearch user interface in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApplication service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateDomain



        /// <summary>
        /// Creates an Amazon OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/createupdatedomains.html">Creating
        /// and managing Amazon OpenSearch Service domains</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access a sub-resource that's either invalid or
        /// not supported.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateDomain">REST API Reference for CreateDomain Operation</seealso>
        Task<CreateDomainResponse> CreateDomainAsync(CreateDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOutboundConnection



        /// <summary>
        /// Creates a new cross-cluster search connection from a source Amazon OpenSearch Service
        /// domain to a destination domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOutboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOutboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateOutboundConnection">REST API Reference for CreateOutboundConnection Operation</seealso>
        Task<CreateOutboundConnectionResponse> CreateOutboundConnectionAsync(CreateOutboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePackage



        /// <summary>
        /// Creates a package for use with Amazon OpenSearch Service domains. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access a sub-resource that's either invalid or
        /// not supported.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreatePackage">REST API Reference for CreatePackage Operation</seealso>
        Task<CreatePackageResponse> CreatePackageAsync(CreatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateVpcEndpoint



        /// <summary>
        /// Creates an Amazon OpenSearch Service-managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteApplication



        /// <summary>
        /// Deletes a specified OpenSearch application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApplication service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDataSource



        /// <summary>
        /// Deletes a direct-query data source. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-delete.html">Deleting
        /// an Amazon OpenSearch Service data source with Amazon S3</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteDataSource">REST API Reference for DeleteDataSource Operation</seealso>
        Task<DeleteDataSourceResponse> DeleteDataSourceAsync(DeleteDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDirectQueryDataSource



        /// <summary>
        /// Deletes a previously configured direct query data source from Amazon OpenSearch Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectQueryDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectQueryDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteDirectQueryDataSource">REST API Reference for DeleteDirectQueryDataSource Operation</seealso>
        Task<DeleteDirectQueryDataSourceResponse> DeleteDirectQueryDataSourceAsync(DeleteDirectQueryDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteDomain



        /// <summary>
        /// Deletes an Amazon OpenSearch Service domain and all of its data. You can't recover
        /// a domain after you delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteDomain">REST API Reference for DeleteDomain Operation</seealso>
        Task<DeleteDomainResponse> DeleteDomainAsync(DeleteDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteInboundConnection



        /// <summary>
        /// Allows the destination Amazon OpenSearch Service domain owner to delete an existing
        /// inbound cross-cluster search connection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteInboundConnection">REST API Reference for DeleteInboundConnection Operation</seealso>
        Task<DeleteInboundConnectionResponse> DeleteInboundConnectionAsync(DeleteInboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOutboundConnection



        /// <summary>
        /// Allows the source Amazon OpenSearch Service domain owner to delete an existing outbound
        /// cross-cluster search connection. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOutboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOutboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteOutboundConnection">REST API Reference for DeleteOutboundConnection Operation</seealso>
        Task<DeleteOutboundConnectionResponse> DeleteOutboundConnectionAsync(DeleteOutboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePackage



        /// <summary>
        /// Deletes an Amazon OpenSearch Service package. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeletePackage">REST API Reference for DeletePackage Operation</seealso>
        Task<DeletePackageResponse> DeletePackageAsync(DeletePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteVpcEndpoint



        /// <summary>
        /// Deletes an Amazon OpenSearch Service-managed interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoint service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DeleteVpcEndpoint">REST API Reference for DeleteVpcEndpoint Operation</seealso>
        Task<DeleteVpcEndpointResponse> DeleteVpcEndpointAsync(DeleteVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomain



        /// <summary>
        /// Describes the domain configuration for the specified Amazon OpenSearch Service domain,
        /// including the domain ID, domain service endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomain">REST API Reference for DescribeDomain Operation</seealso>
        Task<DescribeDomainResponse> DescribeDomainAsync(DescribeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomainAutoTunes



        /// <summary>
        /// Returns the list of optimizations that Auto-Tune has made to an Amazon OpenSearch
        /// Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html">Auto-Tune
        /// for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainAutoTunes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainAutoTunes service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainAutoTunes">REST API Reference for DescribeDomainAutoTunes Operation</seealso>
        Task<DescribeDomainAutoTunesResponse> DescribeDomainAutoTunesAsync(DescribeDomainAutoTunesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomainChangeProgress



        /// <summary>
        /// Returns information about the current blue/green deployment happening on an Amazon
        /// OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-configuration-changes.html">Making
        /// configuration changes in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainChangeProgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainChangeProgress service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainChangeProgress">REST API Reference for DescribeDomainChangeProgress Operation</seealso>
        Task<DescribeDomainChangeProgressResponse> DescribeDomainChangeProgressAsync(DescribeDomainChangeProgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomainConfig



        /// <summary>
        /// Returns the configuration of an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainConfig service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainConfig">REST API Reference for DescribeDomainConfig Operation</seealso>
        Task<DescribeDomainConfigResponse> DescribeDomainConfigAsync(DescribeDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomainHealth



        /// <summary>
        /// Returns information about domain and node health, the standby Availability Zone, number
        /// of nodes per Availability Zone, and shard count per node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainHealth service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainHealth">REST API Reference for DescribeDomainHealth Operation</seealso>
        Task<DescribeDomainHealthResponse> DescribeDomainHealthAsync(DescribeDomainHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomainNodes



        /// <summary>
        /// Returns information about domain and nodes, including data nodes, master nodes, ultrawarm
        /// nodes, Availability Zone(s), standby nodes, node configurations, and node states.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomainNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomainNodes service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomainNodes">REST API Reference for DescribeDomainNodes Operation</seealso>
        Task<DescribeDomainNodesResponse> DescribeDomainNodesAsync(DescribeDomainNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDomains



        /// <summary>
        /// Returns domain configuration information about the specified Amazon OpenSearch Service
        /// domains.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDomains service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDomains service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDomains">REST API Reference for DescribeDomains Operation</seealso>
        Task<DescribeDomainsResponse> DescribeDomainsAsync(DescribeDomainsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeDryRunProgress



        /// <summary>
        /// Describes the progress of a pre-update dry run analysis on an Amazon OpenSearch Service
        /// domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-configuration-changes#dryrun">Determining
        /// whether a change will cause a blue/green deployment</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDryRunProgress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDryRunProgress service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeDryRunProgress">REST API Reference for DescribeDryRunProgress Operation</seealso>
        Task<DescribeDryRunProgressResponse> DescribeDryRunProgressAsync(DescribeDryRunProgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInboundConnections



        /// <summary>
        /// Lists all the inbound cross-cluster search connections for a destination (remote)
        /// Amazon OpenSearch Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInboundConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInboundConnections service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// Request processing failed because you provided an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInboundConnections">REST API Reference for DescribeInboundConnections Operation</seealso>
        Task<DescribeInboundConnectionsResponse> DescribeInboundConnectionsAsync(DescribeInboundConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeInstanceTypeLimits



        /// <summary>
        /// Describes the instance count, storage, and master node limits for a given OpenSearch
        /// or Elasticsearch version and instance type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceTypeLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceTypeLimits service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access a sub-resource that's either invalid or
        /// not supported.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeInstanceTypeLimits">REST API Reference for DescribeInstanceTypeLimits Operation</seealso>
        Task<DescribeInstanceTypeLimitsResponse> DescribeInstanceTypeLimitsAsync(DescribeInstanceTypeLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOutboundConnections



        /// <summary>
        /// Lists all the outbound cross-cluster connections for a local (source) Amazon OpenSearch
        /// Service domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/cross-cluster-search.html">Cross-cluster
        /// search for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOutboundConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOutboundConnections service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// Request processing failed because you provided an invalid pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeOutboundConnections">REST API Reference for DescribeOutboundConnections Operation</seealso>
        Task<DescribeOutboundConnectionsResponse> DescribeOutboundConnectionsAsync(DescribeOutboundConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePackages



        /// <summary>
        /// Describes all packages available to OpenSearch Service. For more information, see
        /// <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePackages service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribePackages">REST API Reference for DescribePackages Operation</seealso>
        Task<DescribePackagesResponse> DescribePackagesAsync(DescribePackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstanceOfferings



        /// <summary>
        /// Describes the available Amazon OpenSearch Service Reserved Instance offerings for
        /// a given Region. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/ri.html">Reserved
        /// Instances in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstanceOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstanceOfferings service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstanceOfferings">REST API Reference for DescribeReservedInstanceOfferings Operation</seealso>
        Task<DescribeReservedInstanceOfferingsResponse> DescribeReservedInstanceOfferingsAsync(DescribeReservedInstanceOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeReservedInstances



        /// <summary>
        /// Describes the Amazon OpenSearch Service instances that you have reserved in a given
        /// Region. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/ri.html">Reserved
        /// Instances in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeVpcEndpoints



        /// <summary>
        /// Describes one or more Amazon OpenSearch Service-managed VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        Task<DescribeVpcEndpointsResponse> DescribeVpcEndpointsAsync(DescribeVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DissociatePackage



        /// <summary>
        /// Removes a package from the specified Amazon OpenSearch Service domain. The package
        /// can't be in use with any OpenSearch index for the dissociation to succeed. The package
        /// is still available in OpenSearch Service for association later. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DissociatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DissociatePackage">REST API Reference for DissociatePackage Operation</seealso>
        Task<DissociatePackageResponse> DissociatePackageAsync(DissociatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DissociatePackages



        /// <summary>
        /// Dissociates multiple packages from a domain simulatneously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DissociatePackages service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DissociatePackages service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/DissociatePackages">REST API Reference for DissociatePackages Operation</seealso>
        Task<DissociatePackagesResponse> DissociatePackagesAsync(DissociatePackagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetApplication



        /// <summary>
        /// Retrieves the configuration and status of an existing OpenSearch application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApplication service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetApplication">REST API Reference for GetApplication Operation</seealso>
        Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCompatibleVersions



        /// <summary>
        /// Returns a map of OpenSearch or Elasticsearch versions and the versions you can upgrade
        /// them to.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCompatibleVersions service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetCompatibleVersions">REST API Reference for GetCompatibleVersions Operation</seealso>
        Task<GetCompatibleVersionsResponse> GetCompatibleVersionsAsync(GetCompatibleVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDataSource



        /// <summary>
        /// Retrieves information about a direct query data source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetDataSource">REST API Reference for GetDataSource Operation</seealso>
        Task<GetDataSourceResponse> GetDataSourceAsync(GetDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDirectQueryDataSource



        /// <summary>
        /// Returns detailed configuration information for a specific direct query data source
        /// in Amazon OpenSearch Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDirectQueryDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDirectQueryDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetDirectQueryDataSource">REST API Reference for GetDirectQueryDataSource Operation</seealso>
        Task<GetDirectQueryDataSourceResponse> GetDirectQueryDataSourceAsync(GetDirectQueryDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDomainMaintenanceStatus



        /// <summary>
        /// The status of the maintenance action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDomainMaintenanceStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDomainMaintenanceStatus service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetDomainMaintenanceStatus">REST API Reference for GetDomainMaintenanceStatus Operation</seealso>
        Task<GetDomainMaintenanceStatusResponse> GetDomainMaintenanceStatusAsync(GetDomainMaintenanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetPackageVersionHistory



        /// <summary>
        /// Returns a list of Amazon OpenSearch Service package versions, along with their creation
        /// time, commit message, and plugin properties (if the package is a zip plugin package).
        /// For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPackageVersionHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPackageVersionHistory service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetPackageVersionHistory">REST API Reference for GetPackageVersionHistory Operation</seealso>
        Task<GetPackageVersionHistoryResponse> GetPackageVersionHistoryAsync(GetPackageVersionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUpgradeHistory



        /// <summary>
        /// Retrieves the complete history of the last 10 upgrades performed on an Amazon OpenSearch
        /// Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUpgradeHistory service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeHistory">REST API Reference for GetUpgradeHistory Operation</seealso>
        Task<GetUpgradeHistoryResponse> GetUpgradeHistoryAsync(GetUpgradeHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetUpgradeStatus



        /// <summary>
        /// Returns the most recent status of the last upgrade or upgrade eligibility check performed
        /// on an Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUpgradeStatus service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/GetUpgradeStatus">REST API Reference for GetUpgradeStatus Operation</seealso>
        Task<GetUpgradeStatusResponse> GetUpgradeStatusAsync(GetUpgradeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListApplications



        /// <summary>
        /// Lists all OpenSearch applications under your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApplications service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApplications service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListApplications">REST API Reference for ListApplications Operation</seealso>
        Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDataSources



        /// <summary>
        /// Lists direct-query data sources for a specific domain. For more information, see For
        /// more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3.html">Working
        /// with Amazon OpenSearch Service direct queries with Amazon S3</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDataSources service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDataSources">REST API Reference for ListDataSources Operation</seealso>
        Task<ListDataSourcesResponse> ListDataSourcesAsync(ListDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDirectQueryDataSources



        /// <summary>
        /// Lists an inventory of all the direct query data sources that you have configured
        /// within Amazon OpenSearch Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDirectQueryDataSources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDirectQueryDataSources service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDirectQueryDataSources">REST API Reference for ListDirectQueryDataSources Operation</seealso>
        Task<ListDirectQueryDataSourcesResponse> ListDirectQueryDataSourcesAsync(ListDirectQueryDataSourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomainMaintenances



        /// <summary>
        /// A list of maintenance actions for the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainMaintenances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainMaintenances service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainMaintenances">REST API Reference for ListDomainMaintenances Operation</seealso>
        Task<ListDomainMaintenancesResponse> ListDomainMaintenancesAsync(ListDomainMaintenancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomainNames



        /// <summary>
        /// Returns the names of all Amazon OpenSearch Service domains owned by the current user
        /// in the active Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainNames">REST API Reference for ListDomainNames Operation</seealso>
        Task<ListDomainNamesResponse> ListDomainNamesAsync(ListDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListDomainsForPackage



        /// <summary>
        /// Lists all Amazon OpenSearch Service domains associated with a given package. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainsForPackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDomainsForPackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListDomainsForPackage">REST API Reference for ListDomainsForPackage Operation</seealso>
        Task<ListDomainsForPackageResponse> ListDomainsForPackageAsync(ListDomainsForPackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListInstanceTypeDetails



        /// <summary>
        /// Lists all instance types and available features for a given OpenSearch or Elasticsearch
        /// version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceTypeDetails service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceTypeDetails service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListInstanceTypeDetails">REST API Reference for ListInstanceTypeDetails Operation</seealso>
        Task<ListInstanceTypeDetailsResponse> ListInstanceTypeDetailsAsync(ListInstanceTypeDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPackagesForDomain



        /// <summary>
        /// Lists all packages associated with an Amazon OpenSearch Service domain. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPackagesForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPackagesForDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListPackagesForDomain">REST API Reference for ListPackagesForDomain Operation</seealso>
        Task<ListPackagesForDomainResponse> ListPackagesForDomainAsync(ListPackagesForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListScheduledActions



        /// <summary>
        /// Retrieves a list of configuration changes that are scheduled for a domain. These changes
        /// can be <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">service
        /// software updates</a> or <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html#auto-tune-types">blue/green
        /// Auto-Tune enhancements</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduledActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduledActions service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidPaginationTokenException">
        /// Request processing failed because you provided an invalid pagination token.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListScheduledActions">REST API Reference for ListScheduledActions Operation</seealso>
        Task<ListScheduledActionsResponse> ListScheduledActionsAsync(ListScheduledActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags



        /// <summary>
        /// Returns all resource tags for an Amazon OpenSearch Service domain, data source, or
        /// application. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-awsresourcetagging.html">Tagging
        /// Amazon OpenSearch Service resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListTags">REST API Reference for ListTags Operation</seealso>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVersions



        /// <summary>
        /// Lists all versions of OpenSearch and Elasticsearch that Amazon OpenSearch Service
        /// supports.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVersions">REST API Reference for ListVersions Operation</seealso>
        Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVpcEndpointAccess



        /// <summary>
        /// Retrieves information about each Amazon Web Services principal that is allowed to
        /// access a given Amazon OpenSearch Service domain through the use of an interface VPC
        /// endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcEndpointAccess service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVpcEndpointAccess">REST API Reference for ListVpcEndpointAccess Operation</seealso>
        Task<ListVpcEndpointAccessResponse> ListVpcEndpointAccessAsync(ListVpcEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVpcEndpoints



        /// <summary>
        /// Retrieves all Amazon OpenSearch Service-managed VPC endpoints in the current Amazon
        /// Web Services account and Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcEndpoints service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVpcEndpoints">REST API Reference for ListVpcEndpoints Operation</seealso>
        Task<ListVpcEndpointsResponse> ListVpcEndpointsAsync(ListVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVpcEndpointsForDomain



        /// <summary>
        /// Retrieves all Amazon OpenSearch Service-managed VPC endpoints associated with a particular
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVpcEndpointsForDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVpcEndpointsForDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/ListVpcEndpointsForDomain">REST API Reference for ListVpcEndpointsForDomain Operation</seealso>
        Task<ListVpcEndpointsForDomainResponse> ListVpcEndpointsForDomainAsync(ListVpcEndpointsForDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PurchaseReservedInstanceOffering



        /// <summary>
        /// Allows you to purchase Amazon OpenSearch Service Reserved Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstanceOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedInstanceOffering service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/PurchaseReservedInstanceOffering">REST API Reference for PurchaseReservedInstanceOffering Operation</seealso>
        Task<PurchaseReservedInstanceOfferingResponse> PurchaseReservedInstanceOfferingAsync(PurchaseReservedInstanceOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RejectInboundConnection



        /// <summary>
        /// Allows the remote Amazon OpenSearch Service domain owner to reject an inbound cross-cluster
        /// connection request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectInboundConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectInboundConnection service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RejectInboundConnection">REST API Reference for RejectInboundConnection Operation</seealso>
        Task<RejectInboundConnectionResponse> RejectInboundConnectionAsync(RejectInboundConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTags



        /// <summary>
        /// Removes the specified set of tags from an Amazon OpenSearch Service domain, data source,
        /// or application. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains.html#managedomains-awsresorcetagging">
        /// Tagging Amazon OpenSearch Service resources</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RevokeVpcEndpointAccess



        /// <summary>
        /// Revokes access to an Amazon OpenSearch Service domain that was provided through an
        /// interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeVpcEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeVpcEndpointAccess service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/RevokeVpcEndpointAccess">REST API Reference for RevokeVpcEndpointAccess Operation</seealso>
        Task<RevokeVpcEndpointAccessResponse> RevokeVpcEndpointAccessAsync(RevokeVpcEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartDomainMaintenance



        /// <summary>
        /// Starts the node maintenance process on the data node. These processes can include
        /// a node reboot, an Opensearch or Elasticsearch process restart, or a Dashboard or Kibana
        /// restart.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartDomainMaintenance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartDomainMaintenance service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/StartDomainMaintenance">REST API Reference for StartDomainMaintenance Operation</seealso>
        Task<StartDomainMaintenanceResponse> StartDomainMaintenanceAsync(StartDomainMaintenanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartServiceSoftwareUpdate



        /// <summary>
        /// Schedules a service software update for an Amazon OpenSearch Service domain. For more
        /// information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">Service
        /// software updates in Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartServiceSoftwareUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartServiceSoftwareUpdate service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/StartServiceSoftwareUpdate">REST API Reference for StartServiceSoftwareUpdate Operation</seealso>
        Task<StartServiceSoftwareUpdateResponse> StartServiceSoftwareUpdateAsync(StartServiceSoftwareUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateApplication



        /// <summary>
        /// Updates the configuration and settings of an existing OpenSearch application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApplication service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDataSource



        /// <summary>
        /// Updates a direct-query data source. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/direct-query-s3-creating.html">Working
        /// with Amazon OpenSearch Service data source integrations with Amazon S3</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DependencyFailureException">
        /// An exception for when a failure in one of the dependencies results in the service
        /// being unable to fetch details about the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateDataSource">REST API Reference for UpdateDataSource Operation</seealso>
        Task<UpdateDataSourceResponse> UpdateDataSourceAsync(UpdateDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDirectQueryDataSource



        /// <summary>
        /// Updates the configuration or properties of an existing direct query data source in
        /// Amazon OpenSearch Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectQueryDataSource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDirectQueryDataSource service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateDirectQueryDataSource">REST API Reference for UpdateDirectQueryDataSource Operation</seealso>
        Task<UpdateDirectQueryDataSourceResponse> UpdateDirectQueryDataSourceAsync(UpdateDirectQueryDataSourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateDomainConfig



        /// <summary>
        /// Modifies the cluster configuration of the specified Amazon OpenSearch Service domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDomainConfig service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InvalidTypeException">
        /// An exception for trying to create or access a sub-resource that's either invalid or
        /// not supported.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateDomainConfig">REST API Reference for UpdateDomainConfig Operation</seealso>
        Task<UpdateDomainConfigResponse> UpdateDomainConfigAsync(UpdateDomainConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePackage



        /// <summary>
        /// Updates a package for use with Amazon OpenSearch Service domains. For more information,
        /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/custom-packages.html">Custom
        /// packages for Amazon OpenSearch Service</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePackage service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.AccessDeniedException">
        /// An error occurred because you don't have permissions to access the resource.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdatePackage">REST API Reference for UpdatePackage Operation</seealso>
        Task<UpdatePackageResponse> UpdatePackageAsync(UpdatePackageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePackageScope



        /// <summary>
        /// Updates the scope of a package. Scope of the package defines users who can view and
        /// associate a package.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePackageScope service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePackageScope service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdatePackageScope">REST API Reference for UpdatePackageScope Operation</seealso>
        Task<UpdatePackageScopeResponse> UpdatePackageScopeAsync(UpdatePackageScopeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateScheduledAction



        /// <summary>
        /// Reschedules a planned domain configuration change for a later time. This change can
        /// be a scheduled <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/service-software.html">service
        /// software update</a> or a <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/auto-tune.html#auto-tune-types">blue/green
        /// Auto-Tune enhancement</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScheduledAction service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.LimitExceededException">
        /// An exception for trying to create more than the allowed number of resources or sub-resources.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.SlotNotAvailableException">
        /// An exception for attempting to schedule a domain action during an unavailable time
        /// slot.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateScheduledAction">REST API Reference for UpdateScheduledAction Operation</seealso>
        Task<UpdateScheduledActionResponse> UpdateScheduledActionAsync(UpdateScheduledActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateVpcEndpoint



        /// <summary>
        /// Modifies an Amazon OpenSearch Service-managed interface VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcEndpoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVpcEndpoint service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ConflictException">
        /// An error occurred because the client attempts to remove a resource that is currently
        /// in use.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpdateVpcEndpoint">REST API Reference for UpdateVpcEndpoint Operation</seealso>
        Task<UpdateVpcEndpointResponse> UpdateVpcEndpointAsync(UpdateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpgradeDomain



        /// <summary>
        /// Allows you to either upgrade your Amazon OpenSearch Service domain or perform an upgrade
        /// eligibility check to a compatible version of OpenSearch or Elasticsearch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeDomain service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpgradeDomain service method, as returned by OpenSearchService.</returns>
        /// <exception cref="Amazon.OpenSearchService.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.DisabledOperationException">
        /// An error occured because the client wanted to access an unsupported operation.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.InternalException">
        /// Request processing failed because of an unknown error, exception, or internal failure.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.OpenSearchService.Model.ValidationException">
        /// An exception for accessing or deleting a resource that doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/opensearch-2021-01-01/UpgradeDomain">REST API Reference for UpgradeDomain Operation</seealso>
        Task<UpgradeDomainResponse> UpgradeDomainAsync(UpgradeDomainRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonOpenSearchServiceConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonOpenSearchServiceConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonOpenSearchServiceConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonOpenSearchServiceConfig to create AmazonOpenSearchServiceClient");
            }

            return awsCredentials == null ? 
                    new AmazonOpenSearchServiceClient(serviceClientConfig) :
                    new AmazonOpenSearchServiceClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}