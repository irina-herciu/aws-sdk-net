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
 * Do not modify this file. This file is generated from the amp-2020-08-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.PrometheusService.Model;

#pragma warning disable CS1570
namespace Amazon.PrometheusService
{
    /// <summary>
    /// <para>Interface for accessing PrometheusService</para>
    ///
    /// Amazon Managed Service for Prometheus is a serverless, Prometheus-compatible monitoring
    /// service for container metrics that makes it easier to securely monitor container environments
    /// at scale. With Amazon Managed Service for Prometheus, you can use the same open-source
    /// Prometheus data model and query language that you use today to monitor the performance
    /// of your containerized workloads, and also enjoy improved scalability, availability,
    /// and security without having to manage the underlying infrastructure.
    /// 
    ///  
    /// <para>
    /// For more information about Amazon Managed Service for Prometheus, see the <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/what-is-Amazon-Managed-Service-Prometheus.html">Amazon
    /// Managed Service for Prometheus</a> User Guide.
    /// </para>
    ///  
    /// <para>
    /// Amazon Managed Service for Prometheus includes two APIs.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the Amazon Web Services API described in this guide to manage Amazon Managed Service
    /// for Prometheus resources, such as workspaces, rule groups, and alert managers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-APIReference.html#AMP-APIReference-Prometheus-Compatible-Apis">Prometheus-compatible
    /// API</a> to work within your Prometheus workspace.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonPrometheusService : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IPrometheusServicePaginatorFactory Paginators { get; }
#endif
                
        #region  CreateAlertManagerDefinition



        /// <summary>
        /// The <c>CreateAlertManagerDefinition</c> operation creates the alert manager definition
        /// in a workspace. If a workspace already has an alert manager definition, don't use
        /// this operation to update it. Instead, use <c>PutAlertManagerDefinition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlertManagerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateAlertManagerDefinition">REST API Reference for CreateAlertManagerDefinition Operation</seealso>
        Task<CreateAlertManagerDefinitionResponse> CreateAlertManagerDefinitionAsync(CreateAlertManagerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateLoggingConfiguration



        /// <summary>
        /// The <c>CreateLoggingConfiguration</c> operation creates rules and alerting logging
        /// configuration for the workspace. Use this operation to set the CloudWatch log group
        /// to which the logs will be published to.
        /// 
        ///  <note> 
        /// <para>
        /// These logging configurations are only for rules and alerting logs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateLoggingConfiguration">REST API Reference for CreateLoggingConfiguration Operation</seealso>
        Task<CreateLoggingConfigurationResponse> CreateLoggingConfigurationAsync(CreateLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateQueryLoggingConfiguration



        /// <summary>
        /// Creates a query logging configuration for the specified workspace. This operation
        /// enables logging of queries that exceed the specified QSP threshold.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueryLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueryLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateQueryLoggingConfiguration">REST API Reference for CreateQueryLoggingConfiguration Operation</seealso>
        Task<CreateQueryLoggingConfigurationResponse> CreateQueryLoggingConfigurationAsync(CreateQueryLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateRuleGroupsNamespace



        /// <summary>
        /// The <c>CreateRuleGroupsNamespace</c> operation creates a rule groups namespace within
        /// a workspace. A rule groups namespace is associated with exactly one rules file. A
        /// workspace can have multiple rule groups namespaces.
        /// 
        ///  
        /// <para>
        /// Use this operation only to create new rule groups namespaces. To update an existing
        /// rule groups namespace, use <c>PutRuleGroupsNamespace</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRuleGroupsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateRuleGroupsNamespace">REST API Reference for CreateRuleGroupsNamespace Operation</seealso>
        Task<CreateRuleGroupsNamespaceResponse> CreateRuleGroupsNamespaceAsync(CreateRuleGroupsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateScraper



        /// <summary>
        /// The <c>CreateScraper</c> operation creates a scraper to collect metrics. A scraper
        /// pulls metrics from Prometheus-compatible sources within an Amazon EKS cluster, and
        /// sends them to your Amazon Managed Service for Prometheus workspace. Scrapers are flexible,
        /// and can be configured to control what metrics are collected, the frequency of collection,
        /// what transformations are applied to the metrics, and more.
        /// 
        ///  
        /// <para>
        /// An IAM role will be created for you that Amazon Managed Service for Prometheus uses
        /// to access the metrics in your cluster. You must configure this role with a policy
        /// that allows it to scrape metrics from your cluster. For more information, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html#AMP-collector-eks-setup">Configuring
        /// your Amazon EKS cluster</a> in the <i>Amazon Managed Service for Prometheus User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The <c>scrapeConfiguration</c> parameter contains the base-64 encoded YAML configuration
        /// for the scraper.
        /// </para>
        ///  
        /// <para>
        /// When creating a scraper, the service creates a <c>Network Interface</c> in each <b>Availability
        /// Zone</b> that are passed into <c>CreateScraper</c> through subnets. These network
        /// interfaces are used to connect to the Amazon EKS cluster within the VPC for scraping
        /// metrics.
        /// </para>
        ///  <note> 
        /// <para>
        /// For more information about collectors, including what metrics are collected, and how
        /// to configure the scraper, see <a href="https://docs.aws.amazon.com/prometheus/latest/userguide/AMP-collector-how-to.html">Using
        /// an Amazon Web Services managed collector</a> in the <i>Amazon Managed Service for
        /// Prometheus User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScraper service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScraper service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateScraper">REST API Reference for CreateScraper Operation</seealso>
        Task<CreateScraperResponse> CreateScraperAsync(CreateScraperRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateWorkspace



        /// <summary>
        /// Creates a Prometheus workspace. A workspace is a logical space dedicated to the storage
        /// and querying of Prometheus metrics. You can have one or more workspaces in each Region
        /// in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/CreateWorkspace">REST API Reference for CreateWorkspace Operation</seealso>
        Task<CreateWorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteAlertManagerDefinition



        /// <summary>
        /// Deletes the alert manager definition from a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlertManagerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteAlertManagerDefinition">REST API Reference for DeleteAlertManagerDefinition Operation</seealso>
        Task<DeleteAlertManagerDefinitionResponse> DeleteAlertManagerDefinitionAsync(DeleteAlertManagerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLoggingConfiguration



        /// <summary>
        /// Deletes the rules and alerting logging configuration for a workspace.
        /// 
        ///  <note> 
        /// <para>
        /// These logging configurations are only for rules and alerting logs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteLoggingConfiguration">REST API Reference for DeleteLoggingConfiguration Operation</seealso>
        Task<DeleteLoggingConfigurationResponse> DeleteLoggingConfigurationAsync(DeleteLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteQueryLoggingConfiguration



        /// <summary>
        /// Deletes the query logging configuration for the specified workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueryLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueryLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteQueryLoggingConfiguration">REST API Reference for DeleteQueryLoggingConfiguration Operation</seealso>
        Task<DeleteQueryLoggingConfigurationResponse> DeleteQueryLoggingConfigurationAsync(DeleteQueryLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteRuleGroupsNamespace



        /// <summary>
        /// Deletes one rule groups namespace and its associated rule groups definition.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRuleGroupsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteRuleGroupsNamespace">REST API Reference for DeleteRuleGroupsNamespace Operation</seealso>
        Task<DeleteRuleGroupsNamespaceResponse> DeleteRuleGroupsNamespaceAsync(DeleteRuleGroupsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteScraper



        /// <summary>
        /// The <c>DeleteScraper</c> operation deletes one scraper, and stops any metrics collection
        /// that the scraper performs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScraper service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScraper service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteScraper">REST API Reference for DeleteScraper Operation</seealso>
        Task<DeleteScraperResponse> DeleteScraperAsync(DeleteScraperRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteWorkspace



        /// <summary>
        /// Deletes an existing workspace. 
        /// 
        ///  <note> 
        /// <para>
        /// When you delete a workspace, the data that has been ingested into it is not immediately
        /// deleted. It will be permanently deleted within one month.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DeleteWorkspace">REST API Reference for DeleteWorkspace Operation</seealso>
        Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(DeleteWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAlertManagerDefinition



        /// <summary>
        /// Retrieves the full information about the alert manager definition for a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlertManagerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeAlertManagerDefinition">REST API Reference for DescribeAlertManagerDefinition Operation</seealso>
        Task<DescribeAlertManagerDefinitionResponse> DescribeAlertManagerDefinitionAsync(DescribeAlertManagerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeLoggingConfiguration



        /// <summary>
        /// Returns complete information about the current rules and alerting logging configuration
        /// of the workspace.
        /// 
        ///  <note> 
        /// <para>
        /// These logging configurations are only for rules and alerting logs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeLoggingConfiguration">REST API Reference for DescribeLoggingConfiguration Operation</seealso>
        Task<DescribeLoggingConfigurationResponse> DescribeLoggingConfigurationAsync(DescribeLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeQueryLoggingConfiguration



        /// <summary>
        /// Retrieves the details of the query logging configuration for the specified workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueryLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQueryLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeQueryLoggingConfiguration">REST API Reference for DescribeQueryLoggingConfiguration Operation</seealso>
        Task<DescribeQueryLoggingConfigurationResponse> DescribeQueryLoggingConfigurationAsync(DescribeQueryLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeRuleGroupsNamespace



        /// <summary>
        /// Returns complete information about one rule groups namespace. To retrieve a list of
        /// rule groups namespaces, use <c>ListRuleGroupsNamespaces</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuleGroupsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeRuleGroupsNamespace">REST API Reference for DescribeRuleGroupsNamespace Operation</seealso>
        Task<DescribeRuleGroupsNamespaceResponse> DescribeRuleGroupsNamespaceAsync(DescribeRuleGroupsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeScraper



        /// <summary>
        /// The <c>DescribeScraper</c> operation displays information about an existing scraper.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScraper service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScraper service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeScraper">REST API Reference for DescribeScraper Operation</seealso>
        Task<DescribeScraperResponse> DescribeScraperAsync(DescribeScraperRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspace



        /// <summary>
        /// Returns information about an existing workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspace">REST API Reference for DescribeWorkspace Operation</seealso>
        Task<DescribeWorkspaceResponse> DescribeWorkspaceAsync(DescribeWorkspaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeWorkspaceConfiguration



        /// <summary>
        /// Use this operation to return information about the configuration of a workspace. The
        /// configuration details returned include workspace configuration status, label set limits,
        /// and retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/DescribeWorkspaceConfiguration">REST API Reference for DescribeWorkspaceConfiguration Operation</seealso>
        Task<DescribeWorkspaceConfigurationResponse> DescribeWorkspaceConfigurationAsync(DescribeWorkspaceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetDefaultScraperConfiguration



        /// <summary>
        /// The <c>GetDefaultScraperConfiguration</c> operation returns the default scraper configuration
        /// used when Amazon EKS creates a scraper for you.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDefaultScraperConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDefaultScraperConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/GetDefaultScraperConfiguration">REST API Reference for GetDefaultScraperConfiguration Operation</seealso>
        Task<GetDefaultScraperConfigurationResponse> GetDefaultScraperConfigurationAsync(GetDefaultScraperConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRuleGroupsNamespaces



        /// <summary>
        /// Returns a list of rule groups namespaces in a workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRuleGroupsNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRuleGroupsNamespaces service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListRuleGroupsNamespaces">REST API Reference for ListRuleGroupsNamespaces Operation</seealso>
        Task<ListRuleGroupsNamespacesResponse> ListRuleGroupsNamespacesAsync(ListRuleGroupsNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListScrapers



        /// <summary>
        /// The <c>ListScrapers</c> operation lists all of the scrapers in your account. This
        /// includes scrapers being created or deleted. You can optionally filter the returned
        /// list.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScrapers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScrapers service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListScrapers">REST API Reference for ListScrapers Operation</seealso>
        Task<ListScrapersResponse> ListScrapersAsync(ListScrapersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// The <c>ListTagsForResource</c> operation returns the tags that are associated with
        /// an Amazon Managed Service for Prometheus resource. Currently, the only resources that
        /// can be tagged are scrapers, workspaces, and rule groups namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListWorkspaces



        /// <summary>
        /// Lists all of the Amazon Managed Service for Prometheus workspaces in your account.
        /// This includes workspaces being created or deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkspaces service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/ListWorkspaces">REST API Reference for ListWorkspaces Operation</seealso>
        Task<ListWorkspacesResponse> ListWorkspacesAsync(ListWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutAlertManagerDefinition



        /// <summary>
        /// Updates an existing alert manager definition in a workspace. If the workspace does
        /// not already have an alert manager definition, don't use this operation to create it.
        /// Instead, use <c>CreateAlertManagerDefinition</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlertManagerDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAlertManagerDefinition service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutAlertManagerDefinition">REST API Reference for PutAlertManagerDefinition Operation</seealso>
        Task<PutAlertManagerDefinitionResponse> PutAlertManagerDefinitionAsync(PutAlertManagerDefinitionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutRuleGroupsNamespace



        /// <summary>
        /// Updates an existing rule groups namespace within a workspace. A rule groups namespace
        /// is associated with exactly one rules file. A workspace can have multiple rule groups
        /// namespaces.
        /// 
        ///  
        /// <para>
        /// Use this operation only to update existing rule groups namespaces. To create a new
        /// rule groups namespace, use <c>CreateRuleGroupsNamespace</c>.
        /// </para>
        ///  
        /// <para>
        /// You can't use this operation to add tags to an existing rule groups namespace. Instead,
        /// use <c>TagResource</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRuleGroupsNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRuleGroupsNamespace service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/PutRuleGroupsNamespace">REST API Reference for PutRuleGroupsNamespace Operation</seealso>
        Task<PutRuleGroupsNamespaceResponse> PutRuleGroupsNamespaceAsync(PutRuleGroupsNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// The <c>TagResource</c> operation associates tags with an Amazon Managed Service for
        /// Prometheus resource. The only resources that can be tagged are rule groups namespaces,
        /// scrapers, and workspaces.
        /// 
        ///  
        /// <para>
        /// If you specify a new tag key for the resource, this tag is appended to the list of
        /// tags associated with the resource. If you specify a tag key that is already associated
        /// with the resource, the new tag value that you specify replaces the previous value
        /// for that tag. To remove a tag, use <c>UntagResource</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes the specified tags from an Amazon Managed Service for Prometheus resource.
        /// The only resources that can be tagged are rule groups namespaces, scrapers, and workspaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateLoggingConfiguration



        /// <summary>
        /// Updates the log group ARN or the workspace ID of the current rules and alerting logging
        /// configuration.
        /// 
        ///  <note> 
        /// <para>
        /// These logging configurations are only for rules and alerting logs.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateLoggingConfiguration">REST API Reference for UpdateLoggingConfiguration Operation</seealso>
        Task<UpdateLoggingConfigurationResponse> UpdateLoggingConfigurationAsync(UpdateLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateQueryLoggingConfiguration



        /// <summary>
        /// Updates the query logging configuration for the specified workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateQueryLoggingConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateQueryLoggingConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateQueryLoggingConfiguration">REST API Reference for UpdateQueryLoggingConfiguration Operation</seealso>
        Task<UpdateQueryLoggingConfigurationResponse> UpdateQueryLoggingConfigurationAsync(UpdateQueryLoggingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateScraper



        /// <summary>
        /// Updates an existing scraper.
        /// 
        ///  
        /// <para>
        /// You can't use this function to update the source from which the scraper is collecting
        /// metrics. To change the source, delete the scraper and create a new one.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateScraper service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateScraper service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateScraper">REST API Reference for UpdateScraper Operation</seealso>
        Task<UpdateScraperResponse> UpdateScraperAsync(UpdateScraperRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkspaceAlias



        /// <summary>
        /// Updates the alias of an existing workspace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspaceAlias service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceAlias">REST API Reference for UpdateWorkspaceAlias Operation</seealso>
        Task<UpdateWorkspaceAliasResponse> UpdateWorkspaceAliasAsync(UpdateWorkspaceAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateWorkspaceConfiguration



        /// <summary>
        /// Use this operation to create or update the label sets, label set limits, and retention
        /// period of a workspace.
        /// 
        ///  
        /// <para>
        /// You must specify at least one of <c>limitsPerLabelSet</c> or <c>retentionPeriodInDays</c>
        /// for the request to be valid.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkspaceConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkspaceConfiguration service method, as returned by PrometheusService.</returns>
        /// <exception cref="Amazon.PrometheusService.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ConflictException">
        /// The request would cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ResourceNotFoundException">
        /// The request references a resources that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ServiceQuotaExceededException">
        /// Completing the request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.PrometheusService.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/amp-2020-08-01/UpdateWorkspaceConfiguration">REST API Reference for UpdateWorkspaceConfiguration Operation</seealso>
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
        [System.Diagnostics.CodeAnalysis.DynamicDependency(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicProperties, typeof(AmazonPrometheusServiceConfig))]
        static ClientConfig IAmazonService.CreateDefaultClientConfig() => new AmazonPrometheusServiceConfig();

        /// <inheritdoc/>
        [System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage("AssemblyLoadTrimming", "IL2026:RequiresUnreferencedCode",
    Justification = "This suppression is here to ignore the warnings caused by CognitoSync. See justification in IAmazonService.")]
        static IAmazonService IAmazonService.CreateDefaultServiceClient(AWSCredentials awsCredentials, ClientConfig clientConfig)
        {
            var serviceClientConfig = clientConfig as AmazonPrometheusServiceConfig;
            if (serviceClientConfig == null)
            {
                throw new AmazonClientException("ClientConfig is not of type AmazonPrometheusServiceConfig to create AmazonPrometheusServiceClient");
            }

            return awsCredentials == null ? 
                    new AmazonPrometheusServiceClient(serviceClientConfig) :
                    new AmazonPrometheusServiceClient(awsCredentials, serviceClientConfig);
        }
#pragma warning restore CA1033
#endif
        #endregion
    }
}