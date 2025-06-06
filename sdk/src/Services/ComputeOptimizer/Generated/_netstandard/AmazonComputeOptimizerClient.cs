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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ComputeOptimizer.Model;
using Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations;
using Amazon.ComputeOptimizer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ComputeOptimizer
{
    /// <summary>
    /// <para>Implementation for accessing ComputeOptimizer</para>
    ///
    /// Compute Optimizer is a service that analyzes the configuration and utilization metrics
    /// of your Amazon Web Services compute resources, such as Amazon EC2 instances, Amazon
    /// EC2 Auto Scaling groups, Lambda functions, Amazon EBS volumes, and Amazon ECS services
    /// on Fargate. It reports whether your resources are optimal, and generates optimization
    /// recommendations to reduce the cost and improve the performance of your workloads.
    /// Compute Optimizer also provides recent utilization metric data, in addition to projected
    /// utilization metric data for the recommendations, which you can use to evaluate which
    /// recommendation provides the best price-performance trade-off. The analysis of your
    /// usage patterns can help you decide when to move or resize your running resources,
    /// and still meet your performance and capacity requirements. For more information about
    /// Compute Optimizer, including the required permissions to use the service, see the
    /// <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/">Compute Optimizer
    /// User Guide</a>.
    /// </summary>
    public partial class AmazonComputeOptimizerClient : AmazonServiceClient, IAmazonComputeOptimizer
    {
        private static IServiceMetadata serviceMetadata = new AmazonComputeOptimizerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonComputeOptimizerClient()
            : base(new AmazonComputeOptimizerConfig()) { }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerClient(RegionEndpoint region)
            : base(new AmazonComputeOptimizerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonComputeOptimizerClient Configuration Object</param>
        public AmazonComputeOptimizerClient(AmazonComputeOptimizerConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonComputeOptimizerClient(AWSCredentials credentials)
            : this(credentials, new AmazonComputeOptimizerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonComputeOptimizerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Credentials and an
        /// AmazonComputeOptimizerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerClient Configuration Object</param>
        public AmazonComputeOptimizerClient(AWSCredentials credentials, AmazonComputeOptimizerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComputeOptimizerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonComputeOptimizerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComputeOptimizerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerClient Configuration Object</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonComputeOptimizerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComputeOptimizerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonComputeOptimizerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonComputeOptimizerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonComputeOptimizerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonComputeOptimizerClient Configuration Object</param>
        public AmazonComputeOptimizerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonComputeOptimizerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IComputeOptimizerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IComputeOptimizerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ComputeOptimizerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonComputeOptimizerEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonComputeOptimizerAuthSchemeHandler());
        }

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  DeleteRecommendationPreferences

        internal virtual DeleteRecommendationPreferencesResponse DeleteRecommendationPreferences(DeleteRecommendationPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommendationPreferencesResponseUnmarshaller.Instance;

            return Invoke<DeleteRecommendationPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Deletes a recommendation preference, such as enhanced infrastructure metrics.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecommendationPreferences service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DeleteRecommendationPreferences">REST API Reference for DeleteRecommendationPreferences Operation</seealso>
        public virtual Task<DeleteRecommendationPreferencesResponse> DeleteRecommendationPreferencesAsync(DeleteRecommendationPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommendationPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRecommendationPreferencesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRecommendationExportJobs

        internal virtual DescribeRecommendationExportJobsResponse DescribeRecommendationExportJobs(DescribeRecommendationExportJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationExportJobsResponseUnmarshaller.Instance;

            return Invoke<DescribeRecommendationExportJobsResponse>(request, options);
        }



        /// <summary>
        /// Describes recommendation export jobs created in the last seven days.
        /// 
        ///  
        /// <para>
        /// Use the <a>ExportAutoScalingGroupRecommendations</a> or <a>ExportEC2InstanceRecommendations</a>
        /// actions to request an export of your recommendations. Then use the <a>DescribeRecommendationExportJobs</a>
        /// action to view your export jobs.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRecommendationExportJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRecommendationExportJobs service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/DescribeRecommendationExportJobs">REST API Reference for DescribeRecommendationExportJobs Operation</seealso>
        public virtual Task<DescribeRecommendationExportJobsResponse> DescribeRecommendationExportJobsAsync(DescribeRecommendationExportJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRecommendationExportJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRecommendationExportJobsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRecommendationExportJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportAutoScalingGroupRecommendations

        internal virtual ExportAutoScalingGroupRecommendationsResponse ExportAutoScalingGroupRecommendations(ExportAutoScalingGroupRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportAutoScalingGroupRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Exports optimization recommendations for Auto Scaling groups.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (JSON) (.json) file, to an existing Amazon Simple
        /// Storage Service (Amazon S3) bucket that you specify. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Auto Scaling group export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportAutoScalingGroupRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportAutoScalingGroupRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportAutoScalingGroupRecommendations">REST API Reference for ExportAutoScalingGroupRecommendations Operation</seealso>
        public virtual Task<ExportAutoScalingGroupRecommendationsResponse> ExportAutoScalingGroupRecommendationsAsync(ExportAutoScalingGroupRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportAutoScalingGroupRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportEBSVolumeRecommendations

        internal virtual ExportEBSVolumeRecommendationsResponse ExportEBSVolumeRecommendations(ExportEBSVolumeRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportEBSVolumeRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Exports optimization recommendations for Amazon EBS volumes.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (JSON) (.json) file, to an existing Amazon Simple
        /// Storage Service (Amazon S3) bucket that you specify. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Amazon EBS volume export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEBSVolumeRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportEBSVolumeRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEBSVolumeRecommendations">REST API Reference for ExportEBSVolumeRecommendations Operation</seealso>
        public virtual Task<ExportEBSVolumeRecommendationsResponse> ExportEBSVolumeRecommendationsAsync(ExportEBSVolumeRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportEBSVolumeRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportEC2InstanceRecommendations

        internal virtual ExportEC2InstanceRecommendationsResponse ExportEC2InstanceRecommendations(ExportEC2InstanceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportEC2InstanceRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Exports optimization recommendations for Amazon EC2 instances.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (JSON) (.json) file, to an existing Amazon Simple
        /// Storage Service (Amazon S3) bucket that you specify. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Amazon EC2 instance export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportEC2InstanceRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportEC2InstanceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportEC2InstanceRecommendations">REST API Reference for ExportEC2InstanceRecommendations Operation</seealso>
        public virtual Task<ExportEC2InstanceRecommendationsResponse> ExportEC2InstanceRecommendationsAsync(ExportEC2InstanceRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportEC2InstanceRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportECSServiceRecommendations

        internal virtual ExportECSServiceRecommendationsResponse ExportECSServiceRecommendations(ExportECSServiceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportECSServiceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportECSServiceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportECSServiceRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Exports optimization recommendations for Amazon ECS services on Fargate. 
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a CSV file, and its metadata in a JSON file, to an
        /// existing Amazon Simple Storage Service (Amazon S3) bucket that you specify. For more
        /// information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can only have one Amazon ECS service export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportECSServiceRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportECSServiceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportECSServiceRecommendations">REST API Reference for ExportECSServiceRecommendations Operation</seealso>
        public virtual Task<ExportECSServiceRecommendationsResponse> ExportECSServiceRecommendationsAsync(ExportECSServiceRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportECSServiceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportECSServiceRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportECSServiceRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportIdleRecommendations

        internal virtual ExportIdleRecommendationsResponse ExportIdleRecommendations(ExportIdleRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportIdleRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportIdleRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportIdleRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Export optimization recommendations for your idle resources. 
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (CSV) file, and its metadata
        /// in a JavaScript Object Notation (JSON) file, to an existing Amazon Simple Storage
        /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one idle resource export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportIdleRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportIdleRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportIdleRecommendations">REST API Reference for ExportIdleRecommendations Operation</seealso>
        public virtual Task<ExportIdleRecommendationsResponse> ExportIdleRecommendationsAsync(ExportIdleRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportIdleRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportIdleRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportIdleRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportLambdaFunctionRecommendations

        internal virtual ExportLambdaFunctionRecommendationsResponse ExportLambdaFunctionRecommendations(ExportLambdaFunctionRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportLambdaFunctionRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Exports optimization recommendations for Lambda functions.
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (.csv) file, and its metadata
        /// in a JavaScript Object Notation (JSON) (.json) file, to an existing Amazon Simple
        /// Storage Service (Amazon S3) bucket that you specify. For more information, see <a
        /// href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Lambda function export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportLambdaFunctionRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportLambdaFunctionRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportLambdaFunctionRecommendations">REST API Reference for ExportLambdaFunctionRecommendations Operation</seealso>
        public virtual Task<ExportLambdaFunctionRecommendationsResponse> ExportLambdaFunctionRecommendationsAsync(ExportLambdaFunctionRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportLambdaFunctionRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportLicenseRecommendations

        internal virtual ExportLicenseRecommendationsResponse ExportLicenseRecommendations(ExportLicenseRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportLicenseRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportLicenseRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportLicenseRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Export optimization recommendations for your licenses. 
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (CSV) file, and its metadata
        /// in a JavaScript Object Notation (JSON) file, to an existing Amazon Simple Storage
        /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one license export job in progress per Amazon Web Services Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportLicenseRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportLicenseRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportLicenseRecommendations">REST API Reference for ExportLicenseRecommendations Operation</seealso>
        public virtual Task<ExportLicenseRecommendationsResponse> ExportLicenseRecommendationsAsync(ExportLicenseRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportLicenseRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportLicenseRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportLicenseRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ExportRDSDatabaseRecommendations

        internal virtual ExportRDSDatabaseRecommendationsResponse ExportRDSDatabaseRecommendations(ExportRDSDatabaseRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportRDSDatabaseRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportRDSDatabaseRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ExportRDSDatabaseRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Export optimization recommendations for your Amazon Aurora and Amazon Relational
        /// Database Service (Amazon RDS) databases. 
        /// 
        ///  
        /// <para>
        /// Recommendations are exported in a comma-separated values (CSV) file, and its metadata
        /// in a JavaScript Object Notation (JSON) file, to an existing Amazon Simple Storage
        /// Service (Amazon S3) bucket that you specify. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/exporting-recommendations.html">Exporting
        /// Recommendations</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can have only one Amazon Aurora or RDS export job in progress per Amazon Web Services
        /// Region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExportRDSDatabaseRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExportRDSDatabaseRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/ExportRDSDatabaseRecommendations">REST API Reference for ExportRDSDatabaseRecommendations Operation</seealso>
        public virtual Task<ExportRDSDatabaseRecommendationsResponse> ExportRDSDatabaseRecommendationsAsync(ExportRDSDatabaseRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportRDSDatabaseRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportRDSDatabaseRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ExportRDSDatabaseRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAutoScalingGroupRecommendations

        internal virtual GetAutoScalingGroupRecommendationsResponse GetAutoScalingGroupRecommendations(GetAutoScalingGroupRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetAutoScalingGroupRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Auto Scaling group recommendations.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for Amazon EC2 Auto Scaling groups that
        /// meet a specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoScalingGroupRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutoScalingGroupRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetAutoScalingGroupRecommendations">REST API Reference for GetAutoScalingGroupRecommendations Operation</seealso>
        public virtual Task<GetAutoScalingGroupRecommendationsResponse> GetAutoScalingGroupRecommendationsAsync(GetAutoScalingGroupRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoScalingGroupRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoScalingGroupRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutoScalingGroupRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEBSVolumeRecommendations

        internal virtual GetEBSVolumeRecommendationsResponse GetEBSVolumeRecommendations(GetEBSVolumeRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetEBSVolumeRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Amazon Elastic Block Store (Amazon EBS) volume recommendations.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for Amazon EBS volumes that meet a specific
        /// set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEBSVolumeRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEBSVolumeRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEBSVolumeRecommendations">REST API Reference for GetEBSVolumeRecommendations Operation</seealso>
        public virtual Task<GetEBSVolumeRecommendationsResponse> GetEBSVolumeRecommendationsAsync(GetEBSVolumeRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEBSVolumeRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEBSVolumeRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEBSVolumeRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEC2InstanceRecommendations

        internal virtual GetEC2InstanceRecommendationsResponse GetEC2InstanceRecommendations(GetEC2InstanceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetEC2InstanceRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Amazon EC2 instance recommendations.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for Amazon Elastic Compute Cloud (Amazon
        /// EC2) instances that meet a specific set of requirements. For more information, see
        /// the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEC2InstanceRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEC2InstanceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2InstanceRecommendations">REST API Reference for GetEC2InstanceRecommendations Operation</seealso>
        public virtual Task<GetEC2InstanceRecommendationsResponse> GetEC2InstanceRecommendationsAsync(GetEC2InstanceRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2InstanceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2InstanceRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEC2InstanceRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEC2RecommendationProjectedMetrics

        internal virtual GetEC2RecommendationProjectedMetricsResponse GetEC2RecommendationProjectedMetrics(GetEC2RecommendationProjectedMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2RecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return Invoke<GetEC2RecommendationProjectedMetricsResponse>(request, options);
        }



        /// <summary>
        /// Returns the projected utilization metrics of Amazon EC2 instance recommendations.
        /// 
        ///  <note> 
        /// <para>
        /// The <c>Cpu</c> and <c>Memory</c> metrics are the only projected utilization metrics
        /// returned when you run this action. Additionally, the <c>Memory</c> metric is returned
        /// only for resources that have the unified CloudWatch agent installed on them. For more
        /// information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/metrics.html#cw-agent">Enabling
        /// Memory Utilization with the CloudWatch Agent</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEC2RecommendationProjectedMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEC2RecommendationProjectedMetrics service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEC2RecommendationProjectedMetrics">REST API Reference for GetEC2RecommendationProjectedMetrics Operation</seealso>
        public virtual Task<GetEC2RecommendationProjectedMetricsResponse> GetEC2RecommendationProjectedMetricsAsync(GetEC2RecommendationProjectedMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEC2RecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEC2RecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetEC2RecommendationProjectedMetricsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetECSServiceRecommendationProjectedMetrics

        internal virtual GetECSServiceRecommendationProjectedMetricsResponse GetECSServiceRecommendationProjectedMetrics(GetECSServiceRecommendationProjectedMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetECSServiceRecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetECSServiceRecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return Invoke<GetECSServiceRecommendationProjectedMetricsResponse>(request, options);
        }



        /// <summary>
        /// Returns the projected metrics of Amazon ECS service recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetECSServiceRecommendationProjectedMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetECSServiceRecommendationProjectedMetrics service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetECSServiceRecommendationProjectedMetrics">REST API Reference for GetECSServiceRecommendationProjectedMetrics Operation</seealso>
        public virtual Task<GetECSServiceRecommendationProjectedMetricsResponse> GetECSServiceRecommendationProjectedMetricsAsync(GetECSServiceRecommendationProjectedMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetECSServiceRecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetECSServiceRecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetECSServiceRecommendationProjectedMetricsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetECSServiceRecommendations

        internal virtual GetECSServiceRecommendationsResponse GetECSServiceRecommendations(GetECSServiceRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetECSServiceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetECSServiceRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetECSServiceRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Amazon ECS service recommendations. 
        /// 
        ///  
        /// <para>
        ///  Compute Optimizer generates recommendations for Amazon ECS services on Fargate that
        /// meet a specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetECSServiceRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetECSServiceRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetECSServiceRecommendations">REST API Reference for GetECSServiceRecommendations Operation</seealso>
        public virtual Task<GetECSServiceRecommendationsResponse> GetECSServiceRecommendationsAsync(GetECSServiceRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetECSServiceRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetECSServiceRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetECSServiceRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEffectiveRecommendationPreferences

        internal virtual GetEffectiveRecommendationPreferencesResponse GetEffectiveRecommendationPreferences(GetEffectiveRecommendationPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectiveRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectiveRecommendationPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetEffectiveRecommendationPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Returns the recommendation preferences that are in effect for a given resource, such
        /// as enhanced infrastructure metrics. Considers all applicable preferences that you
        /// might have set at the resource, account, and organization level.
        /// 
        ///  
        /// <para>
        /// When you create a recommendation preference, you can set its status to <c>Active</c>
        /// or <c>Inactive</c>. Use this action to view the recommendation preferences that are
        /// in effect, or <c>Active</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEffectiveRecommendationPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEffectiveRecommendationPreferences service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEffectiveRecommendationPreferences">REST API Reference for GetEffectiveRecommendationPreferences Operation</seealso>
        public virtual Task<GetEffectiveRecommendationPreferencesResponse> GetEffectiveRecommendationPreferencesAsync(GetEffectiveRecommendationPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEffectiveRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEffectiveRecommendationPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<GetEffectiveRecommendationPreferencesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnrollmentStatus

        internal virtual GetEnrollmentStatusResponse GetEnrollmentStatus(GetEnrollmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusResponseUnmarshaller.Instance;

            return Invoke<GetEnrollmentStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the enrollment (opt in) status of an account to the Compute Optimizer service.
        /// 
        ///  
        /// <para>
        /// If the account is the management account of an organization, this action also confirms
        /// the enrollment status of member accounts of the organization. Use the <a>GetEnrollmentStatusesForOrganization</a>
        /// action to get detailed information about the enrollment status of member accounts
        /// of an organization.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnrollmentStatus service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatus">REST API Reference for GetEnrollmentStatus Operation</seealso>
        public virtual Task<GetEnrollmentStatusResponse> GetEnrollmentStatusAsync(GetEnrollmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnrollmentStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetEnrollmentStatusesForOrganization

        internal virtual GetEnrollmentStatusesForOrganizationResponse GetEnrollmentStatusesForOrganization(GetEnrollmentStatusesForOrganizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusesForOrganizationResponseUnmarshaller.Instance;

            return Invoke<GetEnrollmentStatusesForOrganizationResponse>(request, options);
        }



        /// <summary>
        /// Returns the Compute Optimizer enrollment (opt-in) status of organization member accounts,
        /// if your account is an organization management account.
        /// 
        ///  
        /// <para>
        /// To get the enrollment status of standalone accounts, use the <a>GetEnrollmentStatus</a>
        /// action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnrollmentStatusesForOrganization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEnrollmentStatusesForOrganization service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetEnrollmentStatusesForOrganization">REST API Reference for GetEnrollmentStatusesForOrganization Operation</seealso>
        public virtual Task<GetEnrollmentStatusesForOrganizationResponse> GetEnrollmentStatusesForOrganizationAsync(GetEnrollmentStatusesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnrollmentStatusesForOrganizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnrollmentStatusesForOrganizationResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnrollmentStatusesForOrganizationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdleRecommendations

        internal virtual GetIdleRecommendationsResponse GetIdleRecommendations(GetIdleRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdleRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdleRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetIdleRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns idle resource recommendations. Compute Optimizer generates recommendations
        /// for idle resources that meet a specific set of requirements. For more information,
        /// see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Resource
        /// requirements</a> in the <i>Compute Optimizer User Guide</i>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdleRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdleRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetIdleRecommendations">REST API Reference for GetIdleRecommendations Operation</seealso>
        public virtual Task<GetIdleRecommendationsResponse> GetIdleRecommendationsAsync(GetIdleRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetIdleRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdleRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdleRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLambdaFunctionRecommendations

        internal virtual GetLambdaFunctionRecommendationsResponse GetLambdaFunctionRecommendations(GetLambdaFunctionRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetLambdaFunctionRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Lambda function recommendations.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for functions that meet a specific set
        /// of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLambdaFunctionRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLambdaFunctionRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.LimitExceededException">
        /// The request exceeds a limit of the service.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLambdaFunctionRecommendations">REST API Reference for GetLambdaFunctionRecommendations Operation</seealso>
        public virtual Task<GetLambdaFunctionRecommendationsResponse> GetLambdaFunctionRecommendationsAsync(GetLambdaFunctionRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLambdaFunctionRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLambdaFunctionRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetLambdaFunctionRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLicenseRecommendations

        internal virtual GetLicenseRecommendationsResponse GetLicenseRecommendations(GetLicenseRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetLicenseRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns license recommendations for Amazon EC2 instances that run on a specific license.
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for licenses that meet a specific set
        /// of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetLicenseRecommendations">REST API Reference for GetLicenseRecommendations Operation</seealso>
        public virtual Task<GetLicenseRecommendationsResponse> GetLicenseRecommendationsAsync(GetLicenseRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetLicenseRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRDSDatabaseRecommendationProjectedMetrics

        internal virtual GetRDSDatabaseRecommendationProjectedMetricsResponse GetRDSDatabaseRecommendationProjectedMetrics(GetRDSDatabaseRecommendationProjectedMetricsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRDSDatabaseRecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRDSDatabaseRecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return Invoke<GetRDSDatabaseRecommendationProjectedMetricsResponse>(request, options);
        }



        /// <summary>
        /// Returns the projected metrics of Aurora and RDS database recommendations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRDSDatabaseRecommendationProjectedMetrics service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRDSDatabaseRecommendationProjectedMetrics service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRDSDatabaseRecommendationProjectedMetrics">REST API Reference for GetRDSDatabaseRecommendationProjectedMetrics Operation</seealso>
        public virtual Task<GetRDSDatabaseRecommendationProjectedMetricsResponse> GetRDSDatabaseRecommendationProjectedMetricsAsync(GetRDSDatabaseRecommendationProjectedMetricsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRDSDatabaseRecommendationProjectedMetricsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRDSDatabaseRecommendationProjectedMetricsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRDSDatabaseRecommendationProjectedMetricsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRDSDatabaseRecommendations

        internal virtual GetRDSDatabaseRecommendationsResponse GetRDSDatabaseRecommendations(GetRDSDatabaseRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRDSDatabaseRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRDSDatabaseRecommendationsResponseUnmarshaller.Instance;

            return Invoke<GetRDSDatabaseRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Returns Amazon Aurora and RDS database recommendations. 
        /// 
        ///  
        /// <para>
        /// Compute Optimizer generates recommendations for Amazon Aurora and RDS databases that
        /// meet a specific set of requirements. For more information, see the <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/requirements.html">Supported
        /// resources and requirements</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRDSDatabaseRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRDSDatabaseRecommendations service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRDSDatabaseRecommendations">REST API Reference for GetRDSDatabaseRecommendations Operation</seealso>
        public virtual Task<GetRDSDatabaseRecommendationsResponse> GetRDSDatabaseRecommendationsAsync(GetRDSDatabaseRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRDSDatabaseRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRDSDatabaseRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRDSDatabaseRecommendationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRecommendationPreferences

        internal virtual GetRecommendationPreferencesResponse GetRecommendationPreferences(GetRecommendationPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Returns existing recommendation preferences, such as enhanced infrastructure metrics.
        /// 
        ///  
        /// <para>
        /// Use the <c>scope</c> parameter to specify which preferences to return. You can specify
        /// to return preferences for an organization, a specific account ID, or a specific EC2
        /// instance or Auto Scaling group Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendationPreferences service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationPreferences">REST API Reference for GetRecommendationPreferences Operation</seealso>
        public virtual Task<GetRecommendationPreferencesResponse> GetRecommendationPreferencesAsync(GetRecommendationPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecommendationPreferencesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetRecommendationSummaries

        internal virtual GetRecommendationSummariesResponse GetRecommendationSummaries(GetRecommendationSummariesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationSummariesResponseUnmarshaller.Instance;

            return Invoke<GetRecommendationSummariesResponse>(request, options);
        }



        /// <summary>
        /// Returns the optimization findings for an account.
        /// 
        ///  
        /// <para>
        /// It returns the number of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon EC2 instances in an account that are <c>Underprovisioned</c>, <c>Overprovisioned</c>,
        /// or <c>Optimized</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// EC2Auto Scaling groups in an account that are <c>NotOptimized</c>, or <c>Optimized</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon EBS volumes in an account that are <c>NotOptimized</c>, or <c>Optimized</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Lambda functions in an account that are <c>NotOptimized</c>, or <c>Optimized</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon ECS services in an account that are <c>Underprovisioned</c>, <c>Overprovisioned</c>,
        /// or <c>Optimized</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Commercial software licenses in an account that are <c>InsufficientMetrics</c>, <c>NotOptimized</c>
        /// or <c>Optimized</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Aurora and Amazon RDS databases in an account that are <c>Underprovisioned</c>,
        /// <c>Overprovisioned</c>, <c>Optimized</c>, or <c>NotOptimized</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecommendationSummaries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecommendationSummaries service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/GetRecommendationSummaries">REST API Reference for GetRecommendationSummaries Operation</seealso>
        public virtual Task<GetRecommendationSummariesResponse> GetRecommendationSummariesAsync(GetRecommendationSummariesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecommendationSummariesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecommendationSummariesResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecommendationSummariesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutRecommendationPreferences

        internal virtual PutRecommendationPreferencesResponse PutRecommendationPreferences(PutRecommendationPreferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecommendationPreferencesResponseUnmarshaller.Instance;

            return Invoke<PutRecommendationPreferencesResponse>(request, options);
        }



        /// <summary>
        /// Creates a new recommendation preference or updates an existing recommendation preference,
        /// such as enhanced infrastructure metrics.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
        /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRecommendationPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRecommendationPreferences service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.OptInRequiredException">
        /// The account is not opted in to Compute Optimizer.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ResourceNotFoundException">
        /// A resource that is required for the action doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/PutRecommendationPreferences">REST API Reference for PutRecommendationPreferences Operation</seealso>
        public virtual Task<PutRecommendationPreferencesResponse> PutRecommendationPreferencesAsync(PutRecommendationPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRecommendationPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRecommendationPreferencesResponseUnmarshaller.Instance;

            return InvokeAsync<PutRecommendationPreferencesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEnrollmentStatus

        internal virtual UpdateEnrollmentStatusResponse UpdateEnrollmentStatus(UpdateEnrollmentStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentStatusResponseUnmarshaller.Instance;

            return Invoke<UpdateEnrollmentStatusResponse>(request, options);
        }



        /// <summary>
        /// Updates the enrollment (opt in and opt out) status of an account to the Compute Optimizer
        /// service.
        /// 
        ///  
        /// <para>
        /// If the account is a management account of an organization, this action can also be
        /// used to enroll member accounts of the organization.
        /// </para>
        ///  
        /// <para>
        /// You must have the appropriate permissions to opt in to Compute Optimizer, to view
        /// its recommendations, and to opt out. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/security-iam.html">Controlling
        /// access with Amazon Web Services Identity and Access Management</a> in the <i>Compute
        /// Optimizer User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you opt in, Compute Optimizer automatically creates a service-linked role in
        /// your account to access its data. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/using-service-linked-roles.html">Using
        /// Service-Linked Roles for Compute Optimizer</a> in the <i>Compute Optimizer User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnrollmentStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEnrollmentStatus service method, as returned by ComputeOptimizer.</returns>
        /// <exception cref="Amazon.ComputeOptimizer.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InternalServerException">
        /// An internal error has occurred. Try your call again.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.InvalidParameterValueException">
        /// The value supplied for the input parameter is out of range or not valid.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.MissingAuthenticationTokenException">
        /// The request must contain either a valid (registered) Amazon Web Services access key
        /// ID or X.509 certificate.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the server.
        /// </exception>
        /// <exception cref="Amazon.ComputeOptimizer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/compute-optimizer-2019-11-01/UpdateEnrollmentStatus">REST API Reference for UpdateEnrollmentStatus Operation</seealso>
        public virtual Task<UpdateEnrollmentStatusResponse> UpdateEnrollmentStatusAsync(UpdateEnrollmentStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnrollmentStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnrollmentStatusResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnrollmentStatusResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}