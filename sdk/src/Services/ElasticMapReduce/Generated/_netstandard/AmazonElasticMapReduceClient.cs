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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticMapReduce.Model;
using Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations;
using Amazon.ElasticMapReduce.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// <para>Implementation for accessing ElasticMapReduce</para>
    ///
    /// Amazon EMR is a web service that makes it easier to process large amounts of data
    /// efficiently. Amazon EMR uses Hadoop processing combined with several Amazon Web Services
    /// services to do tasks such as web indexing, data mining, log file analysis, machine
    /// learning, scientific simulation, and data warehouse management.
    /// </summary>
    public partial class AmazonElasticMapReduceClient : AmazonServiceClient, IAmazonElasticMapReduce
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticMapReduceMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
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
        public AmazonElasticMapReduceClient()
            : base(new AmazonElasticMapReduceConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
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
        public AmazonElasticMapReduceClient(RegionEndpoint region)
            : base(new AmazonElasticMapReduceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(AmazonElasticMapReduceConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticMapReduceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Credentials and an
        /// AmazonElasticMapReduceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(AWSCredentials credentials, AmazonElasticMapReduceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticMapReduceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticMapReduceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticMapReduceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticMapReduceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticMapReduceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticMapReduceClient Configuration Object</param>
        public AmazonElasticMapReduceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticMapReduceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IElasticMapReducePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElasticMapReducePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElasticMapReducePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticMapReduceEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticMapReduceAuthSchemeHandler());
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


        #region  AddInstanceFleet

        internal virtual AddInstanceFleetResponse AddInstanceFleet(AddInstanceFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceFleetResponseUnmarshaller.Instance;

            return Invoke<AddInstanceFleetResponse>(request, options);
        }



        /// <summary>
        /// Adds an instance fleet to a running cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceFleet">REST API Reference for AddInstanceFleet Operation</seealso>
        public virtual Task<AddInstanceFleetResponse> AddInstanceFleetAsync(AddInstanceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<AddInstanceFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddInstanceGroups

        internal virtual AddInstanceGroupsResponse AddInstanceGroups(AddInstanceGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<AddInstanceGroupsResponse>(request, options);
        }



        /// <summary>
        /// Adds one or more instance groups to a running cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddInstanceGroups">REST API Reference for AddInstanceGroups Operation</seealso>
        public virtual Task<AddInstanceGroupsResponse> AddInstanceGroupsAsync(AddInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<AddInstanceGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddJobFlowSteps

        internal virtual AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddJobFlowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return Invoke<AddJobFlowStepsResponse>(request, options);
        }



        /// <summary>
        /// AddJobFlowSteps adds new steps to a running cluster. A maximum of 256 steps are allowed
        /// in each job flow.
        /// 
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using SSH to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// </para>
        ///  
        /// <para>
        /// A step specifies the location of a JAR file stored either on the master node of the
        /// cluster or in Amazon S3. Each step is performed by the main function of the main class
        /// of the JAR file. The main class can be specified either in the manifest of the JAR
        /// or by using the MainFunction parameter of the step.
        /// </para>
        ///  
        /// <para>
        /// Amazon EMR executes each step in the order listed. For a step to be considered complete,
        /// the main function must exit with a zero exit code and all Hadoop jobs started while
        /// the step was running must have completed and run successfully.
        /// </para>
        ///  
        /// <para>
        /// You can only add steps to a cluster that is in one of the following states: STARTING,
        /// BOOTSTRAPPING, RUNNING, or WAITING.
        /// </para>
        ///  <note> 
        /// <para>
        /// The string values passed into <c>HadoopJarStep</c> object cannot exceed a total of
        /// 10240 characters.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddJobFlowSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddJobFlowSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddJobFlowSteps">REST API Reference for AddJobFlowSteps Operation</seealso>
        public virtual Task<AddJobFlowStepsResponse> AddJobFlowStepsAsync(AddJobFlowStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddJobFlowStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddJobFlowStepsResponseUnmarshaller.Instance;

            return InvokeAsync<AddJobFlowStepsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }



        /// <summary>
        /// Adds tags to an Amazon EMR resource, such as a cluster or an Amazon EMR Studio. Tags
        /// make it easier to associate resources in various ways, such as grouping clusters to
        /// track your Amazon EMR resource allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CancelSteps

        internal virtual CancelStepsResponse CancelSteps(CancelStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelStepsResponseUnmarshaller.Instance;

            return Invoke<CancelStepsResponse>(request, options);
        }



        /// <summary>
        /// Cancels a pending step or steps in a running cluster. Available only in Amazon EMR
        /// versions 4.8.0 and later, excluding version 5.0.0. A maximum of 256 steps are allowed
        /// in each CancelSteps request. CancelSteps is idempotent but asynchronous; it does not
        /// guarantee that a step will be canceled, even if the request is successfully submitted.
        /// When you use Amazon EMR releases 5.28.0 and later, you can cancel steps that are in
        /// a <c>PENDING</c> or <c>RUNNING</c> state. In earlier versions of Amazon EMR, you can
        /// only cancel steps that are in a <c>PENDING</c> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CancelSteps">REST API Reference for CancelSteps Operation</seealso>
        public virtual Task<CancelStepsResponse> CancelStepsAsync(CancelStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelStepsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelStepsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePersistentAppUI

        internal virtual CreatePersistentAppUIResponse CreatePersistentAppUI(CreatePersistentAppUIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePersistentAppUIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePersistentAppUIResponseUnmarshaller.Instance;

            return Invoke<CreatePersistentAppUIResponse>(request, options);
        }



        /// <summary>
        /// Creates a persistent application user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePersistentAppUI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePersistentAppUI service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreatePersistentAppUI">REST API Reference for CreatePersistentAppUI Operation</seealso>
        public virtual Task<CreatePersistentAppUIResponse> CreatePersistentAppUIAsync(CreatePersistentAppUIRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePersistentAppUIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePersistentAppUIResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePersistentAppUIResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateSecurityConfiguration

        internal virtual CreateSecurityConfigurationResponse CreateSecurityConfiguration(CreateSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a security configuration, which is stored in the service and can be specified
        /// when a cluster is created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateSecurityConfiguration">REST API Reference for CreateSecurityConfiguration Operation</seealso>
        public virtual Task<CreateSecurityConfigurationResponse> CreateSecurityConfigurationAsync(CreateSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStudio

        internal virtual CreateStudioResponse CreateStudio(CreateStudioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioResponseUnmarshaller.Instance;

            return Invoke<CreateStudioResponse>(request, options);
        }



        /// <summary>
        /// Creates a new Amazon EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudio">REST API Reference for CreateStudio Operation</seealso>
        public virtual Task<CreateStudioResponse> CreateStudioAsync(CreateStudioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStudioResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateStudioSessionMapping

        internal virtual CreateStudioSessionMappingResponse CreateStudioSessionMapping(CreateStudioSessionMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioSessionMappingResponseUnmarshaller.Instance;

            return Invoke<CreateStudioSessionMappingResponse>(request, options);
        }



        /// <summary>
        /// Maps a user or group to the Amazon EMR Studio specified by <c>StudioId</c>, and applies
        /// a session policy to refine Studio permissions for that user or group. Use <c>CreateStudioSessionMapping</c>
        /// to assign users to a Studio when you use IAM Identity Center authentication. For instructions
        /// on how to assign users to a Studio when you use IAM authentication, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-studio-manage-users.html#emr-studio-assign-users-groups">Assign
        /// a user or group to your EMR Studio</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStudioSessionMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/CreateStudioSessionMapping">REST API Reference for CreateStudioSessionMapping Operation</seealso>
        public virtual Task<CreateStudioSessionMappingResponse> CreateStudioSessionMappingAsync(CreateStudioSessionMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStudioSessionMappingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStudioSessionMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteSecurityConfiguration

        internal virtual DeleteSecurityConfigurationResponse DeleteSecurityConfiguration(DeleteSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a security configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteSecurityConfiguration">REST API Reference for DeleteSecurityConfiguration Operation</seealso>
        public virtual Task<DeleteSecurityConfigurationResponse> DeleteSecurityConfigurationAsync(DeleteSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStudio

        internal virtual DeleteStudioResponse DeleteStudio(DeleteStudioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioResponseUnmarshaller.Instance;

            return Invoke<DeleteStudioResponse>(request, options);
        }



        /// <summary>
        /// Removes an Amazon EMR Studio from the Studio metadata store.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudio">REST API Reference for DeleteStudio Operation</seealso>
        public virtual Task<DeleteStudioResponse> DeleteStudioAsync(DeleteStudioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStudioResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteStudioSessionMapping

        internal virtual DeleteStudioSessionMappingResponse DeleteStudioSessionMapping(DeleteStudioSessionMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioSessionMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteStudioSessionMappingResponse>(request, options);
        }



        /// <summary>
        /// Removes a user or group from an Amazon EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStudioSessionMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DeleteStudioSessionMapping">REST API Reference for DeleteStudioSessionMapping Operation</seealso>
        public virtual Task<DeleteStudioSessionMappingResponse> DeleteStudioSessionMappingAsync(DeleteStudioSessionMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteStudioSessionMappingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStudioSessionMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeCluster

        internal virtual DescribeClusterResponse DescribeCluster()
        {
            return DescribeCluster(new DescribeClusterRequest());
        }
        internal virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }


        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeClusterAsync(new DescribeClusterRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides cluster-level details including status, hardware and software configuration,
        /// VPC settings, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeJobFlows

        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        internal virtual DescribeJobFlowsResponse DescribeJobFlows()
        {
            return DescribeJobFlows(new DescribeJobFlowsRequest());
        }
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        internal virtual DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return Invoke<DescribeJobFlowsResponse>(request, options);
        }


        /// <summary>
        /// This API is no longer supported and will eventually be removed. We recommend you use
        /// <a>ListClusters</a>, <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a>
        /// and <a>ListBootstrapActions</a> instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <c>RUNNING</c>, <c>WAITING</c>, <c>SHUTTING_DOWN</c>, <c>STARTING</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeJobFlowsAsync(new DescribeJobFlowsRequest(), cancellationToken);
        }



        /// <summary>
        /// This API is no longer supported and will eventually be removed. We recommend you use
        /// <a>ListClusters</a>, <a>DescribeCluster</a>, <a>ListSteps</a>, <a>ListInstanceGroups</a>
        /// and <a>ListBootstrapActions</a> instead.
        /// 
        ///  
        /// <para>
        /// DescribeJobFlows returns a list of job flows that match all of the supplied parameters.
        /// The parameters can include a list of job flow IDs, job flow states, and restrictions
        /// on job flow creation date and time.
        /// </para>
        ///  
        /// <para>
        /// Regardless of supplied parameters, only job flows created within the last two months
        /// are returned.
        /// </para>
        ///  
        /// <para>
        /// If no parameters are supplied, then job flows matching either of the following criteria
        /// are returned:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Job flows created and completed in the last two weeks
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Job flows created within the last two months that are in one of the following states:
        /// <c>RUNNING</c>, <c>WAITING</c>, <c>SHUTTING_DOWN</c>, <c>STARTING</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Amazon EMR can return a maximum of 512 job flow descriptions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJobFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeJobFlows">REST API Reference for DescribeJobFlows Operation</seealso>
        [Obsolete("This API is deprecated and will eventually be removed. We recommend that you use ListClusters, DescribeCluster, ListSteps, ListInstanceGroups and ListBootstrapActions instead.")]
        public virtual Task<DescribeJobFlowsResponse> DescribeJobFlowsAsync(DescribeJobFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeJobFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeJobFlowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeNotebookExecution

        internal virtual DescribeNotebookExecutionResponse DescribeNotebookExecution(DescribeNotebookExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookExecutionResponseUnmarshaller.Instance;

            return Invoke<DescribeNotebookExecutionResponse>(request, options);
        }



        /// <summary>
        /// Provides details of a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeNotebookExecution">REST API Reference for DescribeNotebookExecution Operation</seealso>
        public virtual Task<DescribeNotebookExecutionResponse> DescribeNotebookExecutionAsync(DescribeNotebookExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNotebookExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNotebookExecutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePersistentAppUI

        internal virtual DescribePersistentAppUIResponse DescribePersistentAppUI(DescribePersistentAppUIRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePersistentAppUIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePersistentAppUIResponseUnmarshaller.Instance;

            return Invoke<DescribePersistentAppUIResponse>(request, options);
        }



        /// <summary>
        /// Describes a persistent application user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePersistentAppUI service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePersistentAppUI service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribePersistentAppUI">REST API Reference for DescribePersistentAppUI Operation</seealso>
        public virtual Task<DescribePersistentAppUIResponse> DescribePersistentAppUIAsync(DescribePersistentAppUIRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePersistentAppUIRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePersistentAppUIResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePersistentAppUIResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeReleaseLabel

        internal virtual DescribeReleaseLabelResponse DescribeReleaseLabel(DescribeReleaseLabelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReleaseLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReleaseLabelResponseUnmarshaller.Instance;

            return Invoke<DescribeReleaseLabelResponse>(request, options);
        }



        /// <summary>
        /// Provides Amazon EMR release label details, such as the releases available the Region
        /// where the API request is run, and the available applications for a specific Amazon
        /// EMR release label. Can also list Amazon EMR releases that support a specified version
        /// of Spark.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReleaseLabel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReleaseLabel service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeReleaseLabel">REST API Reference for DescribeReleaseLabel Operation</seealso>
        public virtual Task<DescribeReleaseLabelResponse> DescribeReleaseLabelAsync(DescribeReleaseLabelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReleaseLabelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReleaseLabelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReleaseLabelResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSecurityConfiguration

        internal virtual DescribeSecurityConfigurationResponse DescribeSecurityConfiguration(DescribeSecurityConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Provides the details of a security configuration by returning the configuration JSON.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeSecurityConfiguration">REST API Reference for DescribeSecurityConfiguration Operation</seealso>
        public virtual Task<DescribeSecurityConfigurationResponse> DescribeSecurityConfigurationAsync(DescribeSecurityConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStep

        internal virtual DescribeStepResponse DescribeStep()
        {
            return DescribeStep(new DescribeStepRequest());
        }
        internal virtual DescribeStepResponse DescribeStep(DescribeStepRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return Invoke<DescribeStepResponse>(request, options);
        }


        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual Task<DescribeStepResponse> DescribeStepAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeStepAsync(new DescribeStepRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides more detail about the cluster step.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStep service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStep service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStep">REST API Reference for DescribeStep Operation</seealso>
        public virtual Task<DescribeStepResponse> DescribeStepAsync(DescribeStepRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStepRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStepResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStepResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeStudio

        internal virtual DescribeStudioResponse DescribeStudio(DescribeStudioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStudioResponseUnmarshaller.Instance;

            return Invoke<DescribeStudioResponse>(request, options);
        }



        /// <summary>
        /// Returns details for the specified Amazon EMR Studio including ID, Name, VPC, Studio
        /// access URL, and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/DescribeStudio">REST API Reference for DescribeStudio Operation</seealso>
        public virtual Task<DescribeStudioResponse> DescribeStudioAsync(DescribeStudioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStudioResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStudioResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetAutoTerminationPolicy

        internal virtual GetAutoTerminationPolicyResponse GetAutoTerminationPolicy(GetAutoTerminationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoTerminationPolicyResponseUnmarshaller.Instance;

            return Invoke<GetAutoTerminationPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns the auto-termination policy for an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAutoTerminationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetAutoTerminationPolicy">REST API Reference for GetAutoTerminationPolicy Operation</seealso>
        public virtual Task<GetAutoTerminationPolicyResponse> GetAutoTerminationPolicyAsync(GetAutoTerminationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAutoTerminationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetAutoTerminationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBlockPublicAccessConfiguration

        internal virtual GetBlockPublicAccessConfigurationResponse GetBlockPublicAccessConfiguration(GetBlockPublicAccessConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlockPublicAccessConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlockPublicAccessConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBlockPublicAccessConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Returns the Amazon EMR block public access configuration for your Amazon Web Services
        /// account in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
        /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlockPublicAccessConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBlockPublicAccessConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetBlockPublicAccessConfiguration">REST API Reference for GetBlockPublicAccessConfiguration Operation</seealso>
        public virtual Task<GetBlockPublicAccessConfigurationResponse> GetBlockPublicAccessConfigurationAsync(GetBlockPublicAccessConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBlockPublicAccessConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBlockPublicAccessConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBlockPublicAccessConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetClusterSessionCredentials

        internal virtual GetClusterSessionCredentialsResponse GetClusterSessionCredentials(GetClusterSessionCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterSessionCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterSessionCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetClusterSessionCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Provides temporary, HTTP basic credentials that are associated with a given runtime
        /// IAM role and used by a cluster with fine-grained access control activated. You can
        /// use these credentials to connect to cluster endpoints that support username and password
        /// authentication.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterSessionCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClusterSessionCredentials service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetClusterSessionCredentials">REST API Reference for GetClusterSessionCredentials Operation</seealso>
        public virtual Task<GetClusterSessionCredentialsResponse> GetClusterSessionCredentialsAsync(GetClusterSessionCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetClusterSessionCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetClusterSessionCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetClusterSessionCredentialsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetManagedScalingPolicy

        internal virtual GetManagedScalingPolicyResponse GetManagedScalingPolicy(GetManagedScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<GetManagedScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Fetches the attached managed scaling policy for an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetManagedScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetManagedScalingPolicy">REST API Reference for GetManagedScalingPolicy Operation</seealso>
        public virtual Task<GetManagedScalingPolicyResponse> GetManagedScalingPolicyAsync(GetManagedScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetManagedScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetManagedScalingPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetOnClusterAppUIPresignedURL

        internal virtual GetOnClusterAppUIPresignedURLResponse GetOnClusterAppUIPresignedURL(GetOnClusterAppUIPresignedURLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOnClusterAppUIPresignedURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOnClusterAppUIPresignedURLResponseUnmarshaller.Instance;

            return Invoke<GetOnClusterAppUIPresignedURLResponse>(request, options);
        }



        /// <summary>
        /// The presigned URL properties for the cluster's application user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOnClusterAppUIPresignedURL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetOnClusterAppUIPresignedURL service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetOnClusterAppUIPresignedURL">REST API Reference for GetOnClusterAppUIPresignedURL Operation</seealso>
        public virtual Task<GetOnClusterAppUIPresignedURLResponse> GetOnClusterAppUIPresignedURLAsync(GetOnClusterAppUIPresignedURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOnClusterAppUIPresignedURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOnClusterAppUIPresignedURLResponseUnmarshaller.Instance;

            return InvokeAsync<GetOnClusterAppUIPresignedURLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPersistentAppUIPresignedURL

        internal virtual GetPersistentAppUIPresignedURLResponse GetPersistentAppUIPresignedURL(GetPersistentAppUIPresignedURLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPersistentAppUIPresignedURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersistentAppUIPresignedURLResponseUnmarshaller.Instance;

            return Invoke<GetPersistentAppUIPresignedURLResponse>(request, options);
        }



        /// <summary>
        /// The presigned URL properties for the cluster's application user interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPersistentAppUIPresignedURL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPersistentAppUIPresignedURL service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetPersistentAppUIPresignedURL">REST API Reference for GetPersistentAppUIPresignedURL Operation</seealso>
        public virtual Task<GetPersistentAppUIPresignedURLResponse> GetPersistentAppUIPresignedURLAsync(GetPersistentAppUIPresignedURLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPersistentAppUIPresignedURLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPersistentAppUIPresignedURLResponseUnmarshaller.Instance;

            return InvokeAsync<GetPersistentAppUIPresignedURLResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetStudioSessionMapping

        internal virtual GetStudioSessionMappingResponse GetStudioSessionMapping(GetStudioSessionMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStudioSessionMappingResponseUnmarshaller.Instance;

            return Invoke<GetStudioSessionMappingResponse>(request, options);
        }



        /// <summary>
        /// Fetches mapping details for the specified Amazon EMR Studio and identity (user or
        /// group).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetStudioSessionMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/GetStudioSessionMapping">REST API Reference for GetStudioSessionMapping Operation</seealso>
        public virtual Task<GetStudioSessionMappingResponse> GetStudioSessionMappingAsync(GetStudioSessionMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetStudioSessionMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetStudioSessionMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBootstrapActions

        internal virtual ListBootstrapActionsResponse ListBootstrapActions()
        {
            return ListBootstrapActions(new ListBootstrapActionsRequest());
        }
        internal virtual ListBootstrapActionsResponse ListBootstrapActions(ListBootstrapActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBootstrapActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return Invoke<ListBootstrapActionsResponse>(request, options);
        }


        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListBootstrapActionsAsync(new ListBootstrapActionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides information about the bootstrap actions associated with a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBootstrapActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBootstrapActions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListBootstrapActions">REST API Reference for ListBootstrapActions Operation</seealso>
        public virtual Task<ListBootstrapActionsResponse> ListBootstrapActionsAsync(ListBootstrapActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBootstrapActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBootstrapActionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBootstrapActionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters()
        {
            return ListClusters(new ListClustersRequest());
        }
        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }


        /// <summary>
        /// Provides the status of all clusters visible to this Amazon Web Services account. Allows
        /// you to filter the list of clusters based on certain criteria; for example, filtering
        /// by cluster creation date and time or by status. This call returns a maximum of 50
        /// clusters in unsorted order per call, but returns a marker to track the paging of the
        /// cluster list across multiple ListClusters calls.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListClustersAsync(new ListClustersRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides the status of all clusters visible to this Amazon Web Services account. Allows
        /// you to filter the list of clusters based on certain criteria; for example, filtering
        /// by cluster creation date and time or by status. This call returns a maximum of 50
        /// clusters in unsorted order per call, but returns a marker to track the paging of the
        /// cluster list across multiple ListClusters calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInstanceFleets

        internal virtual ListInstanceFleetsResponse ListInstanceFleets(ListInstanceFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceFleetsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceFleetsResponse>(request, options);
        }



        /// <summary>
        /// Lists all available details about the instance fleets in a cluster.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceFleets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceFleets service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceFleets">REST API Reference for ListInstanceFleets Operation</seealso>
        public virtual Task<ListInstanceFleetsResponse> ListInstanceFleetsAsync(ListInstanceFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceFleetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInstanceGroups

        internal virtual ListInstanceGroupsResponse ListInstanceGroups()
        {
            return ListInstanceGroups(new ListInstanceGroupsRequest());
        }
        internal virtual ListInstanceGroupsResponse ListInstanceGroups(ListInstanceGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ListInstanceGroupsResponse>(request, options);
        }


        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListInstanceGroupsAsync(new ListInstanceGroupsRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides all available details about the instance groups in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstanceGroups">REST API Reference for ListInstanceGroups Operation</seealso>
        public virtual Task<ListInstanceGroupsResponse> ListInstanceGroupsAsync(ListInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstanceGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListInstances

        internal virtual ListInstancesResponse ListInstances()
        {
            return ListInstances(new ListInstancesRequest());
        }
        internal virtual ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return Invoke<ListInstancesResponse>(request, options);
        }


        /// <summary>
        /// Provides information for all active Amazon EC2 instances and Amazon EC2 instances
        /// terminated in the last 30 days, up to a maximum of 2,000. Amazon EC2 instances in
        /// any of the following states are considered active: AWAITING_FULFILLMENT, PROVISIONING,
        /// BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListInstancesAsync(new ListInstancesRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides information for all active Amazon EC2 instances and Amazon EC2 instances
        /// terminated in the last 30 days, up to a maximum of 2,000. Amazon EC2 instances in
        /// any of the following states are considered active: AWAITING_FULFILLMENT, PROVISIONING,
        /// BOOTSTRAPPING, RUNNING.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListInstances service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListInstances">REST API Reference for ListInstances Operation</seealso>
        public virtual Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListInstancesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListNotebookExecutions

        internal virtual ListNotebookExecutionsResponse ListNotebookExecutions(ListNotebookExecutionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookExecutionsResponseUnmarshaller.Instance;

            return Invoke<ListNotebookExecutionsResponse>(request, options);
        }



        /// <summary>
        /// Provides summaries of all notebook executions. You can filter the list based on multiple
        /// criteria such as status, time range, and editor id. Returns a maximum of 50 notebook
        /// executions and a marker to track the paging of a longer notebook execution list across
        /// multiple <c>ListNotebookExecutions</c> calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookExecutions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotebookExecutions service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListNotebookExecutions">REST API Reference for ListNotebookExecutions Operation</seealso>
        public virtual Task<ListNotebookExecutionsResponse> ListNotebookExecutionsAsync(ListNotebookExecutionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNotebookExecutionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotebookExecutionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotebookExecutionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListReleaseLabels

        internal virtual ListReleaseLabelsResponse ListReleaseLabels(ListReleaseLabelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReleaseLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReleaseLabelsResponseUnmarshaller.Instance;

            return Invoke<ListReleaseLabelsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves release labels of Amazon EMR services in the Region where the API is called.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListReleaseLabels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListReleaseLabels service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListReleaseLabels">REST API Reference for ListReleaseLabels Operation</seealso>
        public virtual Task<ListReleaseLabelsResponse> ListReleaseLabelsAsync(ListReleaseLabelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListReleaseLabelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListReleaseLabelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListReleaseLabelsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSecurityConfigurations

        internal virtual ListSecurityConfigurationsResponse ListSecurityConfigurations(ListSecurityConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListSecurityConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the security configurations visible to this account, providing their creation
        /// dates and times, and their names. This call returns a maximum of 50 clusters per call,
        /// but returns a marker to track the paging of the cluster list across multiple ListSecurityConfigurations
        /// calls.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecurityConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSecurityConfigurations service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSecurityConfigurations">REST API Reference for ListSecurityConfigurations Operation</seealso>
        public virtual Task<ListSecurityConfigurationsResponse> ListSecurityConfigurationsAsync(ListSecurityConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecurityConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecurityConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecurityConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSteps

        internal virtual ListStepsResponse ListSteps()
        {
            return ListSteps(new ListStepsRequest());
        }
        internal virtual ListStepsResponse ListSteps(ListStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;

            return Invoke<ListStepsResponse>(request, options);
        }


        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify <c>stepIds</c>
        /// with the request or filter by <c>StepStates</c>. You can specify a maximum of 10 <c>stepIDs</c>.
        /// The CLI automatically paginates results to return a list greater than 50 steps. To
        /// return more than 50 steps using the CLI, specify a <c>Marker</c>, which is a pagination
        /// token that indicates the next set of steps to retrieve.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual Task<ListStepsResponse> ListStepsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListStepsAsync(new ListStepsRequest(), cancellationToken);
        }



        /// <summary>
        /// Provides a list of steps for the cluster in reverse order unless you specify <c>stepIds</c>
        /// with the request or filter by <c>StepStates</c>. You can specify a maximum of 10 <c>stepIDs</c>.
        /// The CLI automatically paginates results to return a list greater than 50 steps. To
        /// return more than 50 steps using the CLI, specify a <c>Marker</c>, which is a pagination
        /// token that indicates the next set of steps to retrieve.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSteps">REST API Reference for ListSteps Operation</seealso>
        public virtual Task<ListStepsResponse> ListStepsAsync(ListStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStepsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStepsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStudios

        internal virtual ListStudiosResponse ListStudios(ListStudiosRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStudiosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudiosResponseUnmarshaller.Instance;

            return Invoke<ListStudiosResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all Amazon EMR Studios associated with the Amazon Web Services account.
        /// The list includes details such as ID, Studio Access URL, and creation time for each
        /// Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudios service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudios service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudios">REST API Reference for ListStudios Operation</seealso>
        public virtual Task<ListStudiosResponse> ListStudiosAsync(ListStudiosRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStudiosRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudiosResponseUnmarshaller.Instance;

            return InvokeAsync<ListStudiosResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListStudioSessionMappings

        internal virtual ListStudioSessionMappingsResponse ListStudioSessionMappings(ListStudioSessionMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStudioSessionMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudioSessionMappingsResponseUnmarshaller.Instance;

            return Invoke<ListStudioSessionMappingsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of all user or group session mappings for the Amazon EMR Studio specified
        /// by <c>StudioId</c>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStudioSessionMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListStudioSessionMappings service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListStudioSessionMappings">REST API Reference for ListStudioSessionMappings Operation</seealso>
        public virtual Task<ListStudioSessionMappingsResponse> ListStudioSessionMappingsAsync(ListStudioSessionMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListStudioSessionMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListStudioSessionMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListStudioSessionMappingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSupportedInstanceTypes

        internal virtual ListSupportedInstanceTypesResponse ListSupportedInstanceTypes(ListSupportedInstanceTypesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSupportedInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<ListSupportedInstanceTypesResponse>(request, options);
        }



        /// <summary>
        /// A list of the instance types that Amazon EMR supports. You can filter the list by
        /// Amazon Web Services Region and Amazon EMR release.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSupportedInstanceTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSupportedInstanceTypes service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ListSupportedInstanceTypes">REST API Reference for ListSupportedInstanceTypes Operation</seealso>
        public virtual Task<ListSupportedInstanceTypesResponse> ListSupportedInstanceTypesAsync(ListSupportedInstanceTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSupportedInstanceTypesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSupportedInstanceTypesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSupportedInstanceTypesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyCluster

        internal virtual ModifyClusterResponse ModifyCluster(ModifyClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return Invoke<ModifyClusterResponse>(request, options);
        }



        /// <summary>
        /// Modifies the number of steps that can be executed concurrently for the cluster specified
        /// using ClusterID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        public virtual Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClusterResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClusterResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyInstanceFleet

        internal virtual ModifyInstanceFleetResponse ModifyInstanceFleet(ModifyInstanceFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceFleetResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceFleetResponse>(request, options);
        }



        /// <summary>
        /// Modifies the target On-Demand and target Spot capacities for the instance fleet with
        /// the specified InstanceFleetID within the cluster specified using ClusterID. The call
        /// either succeeds or fails atomically.
        /// 
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceFleet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceFleet service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceFleet">REST API Reference for ModifyInstanceFleet Operation</seealso>
        public virtual Task<ModifyInstanceFleetResponse> ModifyInstanceFleetAsync(ModifyInstanceFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceFleetResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceFleetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ModifyInstanceGroups

        internal virtual ModifyInstanceGroupsResponse ModifyInstanceGroups(ModifyInstanceGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceGroupsResponse>(request, options);
        }



        /// <summary>
        /// ModifyInstanceGroups modifies the number of nodes and configuration settings of an
        /// instance group. The input parameters include the new target instance count for the
        /// group and the instance group ID. The call will either succeed or fail atomically.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyInstanceGroups service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/ModifyInstanceGroups">REST API Reference for ModifyInstanceGroups Operation</seealso>
        public virtual Task<ModifyInstanceGroupsResponse> ModifyInstanceGroupsAsync(ModifyInstanceGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceGroupsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAutoScalingPolicy

        internal virtual PutAutoScalingPolicyResponse PutAutoScalingPolicy(PutAutoScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAutoScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates an automatic scaling policy for a core instance group or task instance
        /// group in an Amazon EMR cluster. The automatic scaling policy defines how an instance
        /// group dynamically adds and terminates Amazon EC2 instances in response to the value
        /// of a CloudWatch metric.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoScalingPolicy">REST API Reference for PutAutoScalingPolicy Operation</seealso>
        public virtual Task<PutAutoScalingPolicyResponse> PutAutoScalingPolicyAsync(PutAutoScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutAutoScalingPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAutoTerminationPolicy

        internal virtual PutAutoTerminationPolicyResponse PutAutoTerminationPolicy(PutAutoTerminationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoTerminationPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAutoTerminationPolicyResponse>(request, options);
        }



        /// <summary>
        /// <note> 
        /// <para>
        /// Auto-termination is supported in Amazon EMR releases 5.30.0 and 6.1.0 and later. For
        /// more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-auto-termination-policy.html">Using
        /// an auto-termination policy</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Creates or updates an auto-termination policy for an Amazon EMR cluster. An auto-termination
        /// policy defines the amount of idle time in seconds after which a cluster automatically
        /// terminates. For alternative cluster termination options, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-termination.html">Control
        /// cluster termination</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAutoTerminationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutAutoTerminationPolicy">REST API Reference for PutAutoTerminationPolicy Operation</seealso>
        public virtual Task<PutAutoTerminationPolicyResponse> PutAutoTerminationPolicyAsync(PutAutoTerminationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAutoTerminationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutAutoTerminationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutBlockPublicAccessConfiguration

        internal virtual PutBlockPublicAccessConfigurationResponse PutBlockPublicAccessConfiguration(PutBlockPublicAccessConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBlockPublicAccessConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBlockPublicAccessConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBlockPublicAccessConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates an Amazon EMR block public access configuration for your Amazon
        /// Web Services account in the current Region. For more information see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/configure-block-public-access.html">Configure
        /// Block Public Access for Amazon EMR</a> in the <i>Amazon EMR Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutBlockPublicAccessConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBlockPublicAccessConfiguration service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutBlockPublicAccessConfiguration">REST API Reference for PutBlockPublicAccessConfiguration Operation</seealso>
        public virtual Task<PutBlockPublicAccessConfigurationResponse> PutBlockPublicAccessConfigurationAsync(PutBlockPublicAccessConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBlockPublicAccessConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBlockPublicAccessConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBlockPublicAccessConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutManagedScalingPolicy

        internal virtual PutManagedScalingPolicyResponse PutManagedScalingPolicy(PutManagedScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutManagedScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutManagedScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a managed scaling policy for an Amazon EMR cluster. The managed
        /// scaling policy defines the limits for resources, such as Amazon EC2 instances that
        /// can be added or terminated from a cluster. The policy only applies to the core and
        /// task nodes. The master node cannot be scaled after initial configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutManagedScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/PutManagedScalingPolicy">REST API Reference for PutManagedScalingPolicy Operation</seealso>
        public virtual Task<PutManagedScalingPolicyResponse> PutManagedScalingPolicyAsync(PutManagedScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutManagedScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutManagedScalingPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveAutoScalingPolicy

        internal virtual RemoveAutoScalingPolicyResponse RemoveAutoScalingPolicy(RemoveAutoScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<RemoveAutoScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Removes an automatic scaling policy from a specified instance group within an Amazon
        /// EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAutoScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoScalingPolicy">REST API Reference for RemoveAutoScalingPolicy Operation</seealso>
        public virtual Task<RemoveAutoScalingPolicyResponse> RemoveAutoScalingPolicyAsync(RemoveAutoScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAutoScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAutoScalingPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveAutoTerminationPolicy

        internal virtual RemoveAutoTerminationPolicyResponse RemoveAutoTerminationPolicy(RemoveAutoTerminationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoTerminationPolicyResponseUnmarshaller.Instance;

            return Invoke<RemoveAutoTerminationPolicyResponse>(request, options);
        }



        /// <summary>
        /// Removes an auto-termination policy from an Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveAutoTerminationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveAutoTerminationPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveAutoTerminationPolicy">REST API Reference for RemoveAutoTerminationPolicy Operation</seealso>
        public virtual Task<RemoveAutoTerminationPolicyResponse> RemoveAutoTerminationPolicyAsync(RemoveAutoTerminationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveAutoTerminationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveAutoTerminationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveAutoTerminationPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveManagedScalingPolicy

        internal virtual RemoveManagedScalingPolicyResponse RemoveManagedScalingPolicy(RemoveManagedScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveManagedScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<RemoveManagedScalingPolicyResponse>(request, options);
        }



        /// <summary>
        /// Removes a managed scaling policy from a specified Amazon EMR cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveManagedScalingPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveManagedScalingPolicy service method, as returned by ElasticMapReduce.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveManagedScalingPolicy">REST API Reference for RemoveManagedScalingPolicy Operation</seealso>
        public virtual Task<RemoveManagedScalingPolicyResponse> RemoveManagedScalingPolicyAsync(RemoveManagedScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveManagedScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveManagedScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveManagedScalingPolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }



        /// <summary>
        /// Removes tags from an Amazon EMR resource, such as a cluster or Amazon EMR Studio.
        /// Tags make it easier to associate resources in various ways, such as grouping clusters
        /// to track your Amazon EMR resource allocation costs. For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-tags.html">Tag
        /// Clusters</a>. 
        /// 
        ///  
        /// <para>
        /// The following example removes the stack tag with value Prod from a cluster:
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RunJobFlow

        internal virtual RunJobFlowResponse RunJobFlow(RunJobFlowRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunJobFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return Invoke<RunJobFlowResponse>(request, options);
        }



        /// <summary>
        /// RunJobFlow creates and starts running a new cluster (job flow). The cluster runs the
        /// steps specified. After the steps complete, the cluster stops and the HDFS partition
        /// is lost. To prevent loss of data, configure the last step of the job flow to store
        /// results in Amazon S3. If the <a>JobFlowInstancesConfig</a> <c>KeepJobFlowAliveWhenNoSteps</c>
        /// parameter is set to <c>TRUE</c>, the cluster transitions to the WAITING state rather
        /// than shutting down after the steps have completed. 
        /// 
        ///  
        /// <para>
        /// For additional protection, you can set the <a>JobFlowInstancesConfig</a> <c>TerminationProtected</c>
        /// parameter to <c>TRUE</c> to lock the cluster and prevent it from being terminated
        /// by API call, user intervention, or in the event of a job flow error.
        /// </para>
        ///  
        /// <para>
        /// A maximum of 256 steps are allowed in each job flow.
        /// </para>
        ///  
        /// <para>
        /// If your cluster is long-running (such as a Hive data warehouse) or complex, you may
        /// require more than 256 steps to process your data. You can bypass the 256-step limitation
        /// in various ways, including using the SSH shell to connect to the master node and submitting
        /// queries directly to the software running on the master node, such as Hive and Hadoop.
        /// </para>
        ///  
        /// <para>
        /// For long-running clusters, we recommend that you periodically store your results.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleets configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions. The RunJobFlow request can contain InstanceFleets
        /// parameters or InstanceGroups parameters, but not both.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunJobFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RunJobFlow service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/RunJobFlow">REST API Reference for RunJobFlow Operation</seealso>
        public virtual Task<RunJobFlowResponse> RunJobFlowAsync(RunJobFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunJobFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunJobFlowResponseUnmarshaller.Instance;

            return InvokeAsync<RunJobFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetKeepJobFlowAliveWhenNoSteps

        internal virtual SetKeepJobFlowAliveWhenNoStepsResponse SetKeepJobFlowAliveWhenNoSteps(SetKeepJobFlowAliveWhenNoStepsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetKeepJobFlowAliveWhenNoStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetKeepJobFlowAliveWhenNoStepsResponseUnmarshaller.Instance;

            return Invoke<SetKeepJobFlowAliveWhenNoStepsResponse>(request, options);
        }



        /// <summary>
        /// You can use the <c>SetKeepJobFlowAliveWhenNoSteps</c> to configure a cluster (job
        /// flow) to terminate after the step execution, i.e., all your steps are executed. If
        /// you want a transient cluster that shuts down after the last of the current executing
        /// steps are completed, you can configure <c>SetKeepJobFlowAliveWhenNoSteps</c> to false.
        /// If you want a long running cluster, configure <c>SetKeepJobFlowAliveWhenNoSteps</c>
        /// to true.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
        /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetKeepJobFlowAliveWhenNoSteps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetKeepJobFlowAliveWhenNoSteps service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetKeepJobFlowAliveWhenNoSteps">REST API Reference for SetKeepJobFlowAliveWhenNoSteps Operation</seealso>
        public virtual Task<SetKeepJobFlowAliveWhenNoStepsResponse> SetKeepJobFlowAliveWhenNoStepsAsync(SetKeepJobFlowAliveWhenNoStepsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetKeepJobFlowAliveWhenNoStepsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetKeepJobFlowAliveWhenNoStepsResponseUnmarshaller.Instance;

            return InvokeAsync<SetKeepJobFlowAliveWhenNoStepsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetTerminationProtection

        internal virtual SetTerminationProtectionResponse SetTerminationProtection(SetTerminationProtectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return Invoke<SetTerminationProtectionResponse>(request, options);
        }



        /// <summary>
        /// SetTerminationProtection locks a cluster (job flow) so the Amazon EC2 instances in
        /// the cluster cannot be terminated by user intervention, an API call, or in the event
        /// of a job-flow error. The cluster still terminates upon successful completion of the
        /// job flow. Calling <c>SetTerminationProtection</c> on a cluster is similar to calling
        /// the Amazon EC2 <c>DisableAPITermination</c> API on all Amazon EC2 instances in a cluster.
        /// 
        ///  
        /// <para>
        ///  <c>SetTerminationProtection</c> is used to prevent accidental termination of a cluster
        /// and to ensure that in the event of an error, the instances persist so that you can
        /// recover any data stored in their ephemeral instance storage.
        /// </para>
        ///  
        /// <para>
        ///  To terminate a cluster that has been locked by setting <c>SetTerminationProtection</c>
        /// to <c>true</c>, you must first unlock the job flow by a subsequent call to <c>SetTerminationProtection</c>
        /// in which you set the value to <c>false</c>. 
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/UsingEMR_TerminationProtection.html">Managing
        /// Cluster Termination</a> in the <i>Amazon EMR Management Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTerminationProtection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTerminationProtection service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetTerminationProtection">REST API Reference for SetTerminationProtection Operation</seealso>
        public virtual Task<SetTerminationProtectionResponse> SetTerminationProtectionAsync(SetTerminationProtectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetTerminationProtectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTerminationProtectionResponseUnmarshaller.Instance;

            return InvokeAsync<SetTerminationProtectionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetUnhealthyNodeReplacement

        internal virtual SetUnhealthyNodeReplacementResponse SetUnhealthyNodeReplacement(SetUnhealthyNodeReplacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUnhealthyNodeReplacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUnhealthyNodeReplacementResponseUnmarshaller.Instance;

            return Invoke<SetUnhealthyNodeReplacementResponse>(request, options);
        }



        /// <summary>
        /// Specify whether to enable unhealthy node replacement, which lets Amazon EMR gracefully
        /// replace core nodes on a cluster if any nodes become unhealthy. For example, a node
        /// becomes unhealthy if disk usage is above 90%. If unhealthy node replacement is on
        /// and <c>TerminationProtected</c> are off, Amazon EMR immediately terminates the unhealthy
        /// core nodes. To use unhealthy node replacement and retain unhealthy core nodes, use
        /// to turn on termination protection. In such cases, Amazon EMR adds the unhealthy nodes
        /// to a denylist, reducing job interruptions and failures.
        /// 
        ///  
        /// <para>
        /// If unhealthy node replacement is on, Amazon EMR notifies YARN and other applications
        /// on the cluster to stop scheduling tasks with these nodes, moves the data, and then
        /// terminates the nodes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-node-replacement.html">graceful
        /// node replacement</a> in the <i>Amazon EMR Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetUnhealthyNodeReplacement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetUnhealthyNodeReplacement service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetUnhealthyNodeReplacement">REST API Reference for SetUnhealthyNodeReplacement Operation</seealso>
        public virtual Task<SetUnhealthyNodeReplacementResponse> SetUnhealthyNodeReplacementAsync(SetUnhealthyNodeReplacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetUnhealthyNodeReplacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetUnhealthyNodeReplacementResponseUnmarshaller.Instance;

            return InvokeAsync<SetUnhealthyNodeReplacementResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetVisibleToAllUsers

        internal virtual SetVisibleToAllUsersResponse SetVisibleToAllUsers(SetVisibleToAllUsersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVisibleToAllUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return Invoke<SetVisibleToAllUsersResponse>(request, options);
        }



        /// <summary>
        /// <important> 
        /// <para>
        /// The SetVisibleToAllUsers parameter is no longer supported. Your cluster may be visible
        /// to all users in your account. To restrict cluster access using an IAM policy, see
        /// <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/emr-plan-access-IAM.html">Identity
        /// and Access Management for Amazon EMR</a>. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Sets the <a>Cluster$VisibleToAllUsers</a> value for an Amazon EMR cluster. When <c>true</c>,
        /// IAM principals in the Amazon Web Services account can perform Amazon EMR cluster actions
        /// that their IAM policies allow. When <c>false</c>, only the IAM principal that created
        /// the cluster and the Amazon Web Services account root user can perform Amazon EMR actions
        /// on the cluster, regardless of IAM permissions policies attached to other IAM principals.
        /// </para>
        ///  
        /// <para>
        /// This action works on running clusters. When you create a cluster, use the <a>RunJobFlowInput$VisibleToAllUsers</a>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/emr/latest/ManagementGuide/security_IAM_emr-with-IAM.html#security_set_visible_to_all_users">Understanding
        /// the Amazon EMR Cluster VisibleToAllUsers Setting</a> in the <i>Amazon EMR Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVisibleToAllUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetVisibleToAllUsers service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/SetVisibleToAllUsers">REST API Reference for SetVisibleToAllUsers Operation</seealso>
        public virtual Task<SetVisibleToAllUsersResponse> SetVisibleToAllUsersAsync(SetVisibleToAllUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetVisibleToAllUsersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVisibleToAllUsersResponseUnmarshaller.Instance;

            return InvokeAsync<SetVisibleToAllUsersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartNotebookExecution

        internal virtual StartNotebookExecutionResponse StartNotebookExecution(StartNotebookExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookExecutionResponseUnmarshaller.Instance;

            return Invoke<StartNotebookExecutionResponse>(request, options);
        }



        /// <summary>
        /// Starts a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StartNotebookExecution">REST API Reference for StartNotebookExecution Operation</seealso>
        public virtual Task<StartNotebookExecutionResponse> StartNotebookExecutionAsync(StartNotebookExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartNotebookExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StartNotebookExecutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StopNotebookExecution

        internal virtual StopNotebookExecutionResponse StopNotebookExecution(StopNotebookExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookExecutionResponseUnmarshaller.Instance;

            return Invoke<StopNotebookExecutionResponse>(request, options);
        }



        /// <summary>
        /// Stops a notebook execution.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookExecution service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopNotebookExecution service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/StopNotebookExecution">REST API Reference for StopNotebookExecution Operation</seealso>
        public virtual Task<StopNotebookExecutionResponse> StopNotebookExecutionAsync(StopNotebookExecutionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopNotebookExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopNotebookExecutionResponseUnmarshaller.Instance;

            return InvokeAsync<StopNotebookExecutionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TerminateJobFlows

        internal virtual TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return Invoke<TerminateJobFlowsResponse>(request, options);
        }



        /// <summary>
        /// TerminateJobFlows shuts a list of clusters (job flows) down. When a job flow is shut
        /// down, any step not yet completed is canceled and the Amazon EC2 instances on which
        /// the cluster is running are stopped. Any log files not already saved are uploaded to
        /// Amazon S3 if a LogUri was specified when the cluster was created.
        /// 
        ///  
        /// <para>
        /// The maximum number of clusters allowed is 10. The call to <c>TerminateJobFlows</c>
        /// is asynchronous. Depending on the configuration of the cluster, it may take up to
        /// 1-5 minutes for the cluster to completely terminate and release allocated resources,
        /// such as Amazon EC2 instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateJobFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TerminateJobFlows service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/TerminateJobFlows">REST API Reference for TerminateJobFlows Operation</seealso>
        public virtual Task<TerminateJobFlowsResponse> TerminateJobFlowsAsync(TerminateJobFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateJobFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateJobFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateJobFlowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStudio

        internal virtual UpdateStudioResponse UpdateStudio(UpdateStudioRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStudioResponseUnmarshaller.Instance;

            return Invoke<UpdateStudioResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon EMR Studio configuration, including attributes such as name, description,
        /// and subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudio service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStudio service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the Amazon EMR service.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudio">REST API Reference for UpdateStudio Operation</seealso>
        public virtual Task<UpdateStudioResponse> UpdateStudioAsync(UpdateStudioRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStudioRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStudioResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStudioResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateStudioSessionMapping

        internal virtual UpdateStudioSessionMappingResponse UpdateStudioSessionMapping(UpdateStudioSessionMappingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStudioSessionMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateStudioSessionMappingResponse>(request, options);
        }



        /// <summary>
        /// Updates the session policy attached to the user or group for the specified Amazon
        /// EMR Studio.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStudioSessionMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateStudioSessionMapping service method, as returned by ElasticMapReduce.</returns>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InternalServerErrorException">
        /// Indicates that an error occurred while processing the request and that the request
        /// was not completed.
        /// </exception>
        /// <exception cref="Amazon.ElasticMapReduce.Model.InvalidRequestException">
        /// This exception occurs when there is something wrong with user input.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticmapreduce-2009-03-31/UpdateStudioSessionMapping">REST API Reference for UpdateStudioSessionMapping Operation</seealso>
        public virtual Task<UpdateStudioSessionMappingResponse> UpdateStudioSessionMappingAsync(UpdateStudioSessionMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateStudioSessionMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateStudioSessionMappingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStudioSessionMappingResponse>(request, options, cancellationToken);
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