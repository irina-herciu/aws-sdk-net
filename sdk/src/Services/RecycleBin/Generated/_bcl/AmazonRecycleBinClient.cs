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
 * Do not modify this file. This file is generated from the rbin-2021-06-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RecycleBin.Model;
using Amazon.RecycleBin.Model.Internal.MarshallTransformations;
using Amazon.RecycleBin.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.RecycleBin
{
    /// <summary>
    /// <para>Implementation for accessing RecycleBin</para>
    ///
    /// This is the <i>Recycle Bin API Reference</i>. This documentation provides descriptions
    /// and syntax for each of the actions and data types in Recycle Bin.
    /// 
    ///  
    /// <para>
    /// Recycle Bin is a resource recovery feature that enables you to restore accidentally
    /// deleted snapshots and EBS-backed AMIs. When using Recycle Bin, if your resources are
    /// deleted, they are retained in the Recycle Bin for a time period that you specify.
    /// </para>
    ///  
    /// <para>
    /// You can restore a resource from the Recycle Bin at any time before its retention period
    /// expires. After you restore a resource from the Recycle Bin, the resource is removed
    /// from the Recycle Bin, and you can then use it in the same way you use any other resource
    /// of that type in your account. If the retention period expires and the resource is
    /// not restored, the resource is permanently deleted from the Recycle Bin and is no longer
    /// available for recovery. For more information about Recycle Bin, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin.html">
    /// Recycle Bin</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonRecycleBinClient : AmazonServiceClient, IAmazonRecycleBin
    {
        private static IServiceMetadata serviceMetadata = new AmazonRecycleBinMetadata();
        private IRecycleBinPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRecycleBinPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RecycleBinPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonRecycleBinClient with the credentials loaded from the application's
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
        public AmazonRecycleBinClient()
            : base(new AmazonRecycleBinConfig()) { }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with the credentials loaded from the application's
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
        public AmazonRecycleBinClient(RegionEndpoint region)
            : base(new AmazonRecycleBinConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRecycleBinClient Configuration Object</param>
        public AmazonRecycleBinClient(AmazonRecycleBinConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRecycleBinClient(AWSCredentials credentials)
            : this(credentials, new AmazonRecycleBinConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRecycleBinClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRecycleBinConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Credentials and an
        /// AmazonRecycleBinClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRecycleBinClient Configuration Object</param>
        public AmazonRecycleBinClient(AWSCredentials credentials, AmazonRecycleBinConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRecycleBinClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRecycleBinConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRecycleBinClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRecycleBinConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRecycleBinClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRecycleBinClient Configuration Object</param>
        public AmazonRecycleBinClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRecycleBinConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRecycleBinClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRecycleBinConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRecycleBinClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRecycleBinConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRecycleBinClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRecycleBinClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRecycleBinClient Configuration Object</param>
        public AmazonRecycleBinClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRecycleBinConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRecycleBinEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRecycleBinAuthSchemeHandler());
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


        #region  CreateRule


        /// <summary>
        /// Creates a Recycle Bin retention rule. You can create two types of retention rules:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Tag-level retention rules</b> - These retention rules use resource tags to identify
        /// the resources to protect. For each retention rule, you specify one or more tag key
        /// and value pairs. Resources (of the specified type) that have at least one of these
        /// tag key and value pairs are automatically retained in the Recycle Bin upon deletion.
        /// Use this type of retention rule to protect specific resources in your account based
        /// on their tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Region-level retention rules</b> - These retention rules, by default, apply to
        /// all of the resources (of the specified type) in the Region, even if the resources
        /// are not tagged. However, you can specify exclusion tags to exclude resources that
        /// have specific tags. Use this type of retention rule to protect all resources of a
        /// specific type in a Region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/recycle-bin.html">
        /// Create Recycle Bin retention rules</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }


        /// <summary>
        /// Creates a Recycle Bin retention rule. You can create two types of retention rules:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <b>Tag-level retention rules</b> - These retention rules use resource tags to identify
        /// the resources to protect. For each retention rule, you specify one or more tag key
        /// and value pairs. Resources (of the specified type) that have at least one of these
        /// tag key and value pairs are automatically retained in the Recycle Bin upon deletion.
        /// Use this type of retention rule to protect specific resources in your account based
        /// on their tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Region-level retention rules</b> - These retention rules, by default, apply to
        /// all of the resources (of the specified type) in the Region, even if the resources
        /// are not tagged. However, you can specify exclusion tags to exclude resources that
        /// have specific tags. Use this type of retention rule to protect all resources of a
        /// specific type in a Region.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/recycle-bin.html">
        /// Create Recycle Bin retention rules</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes a Recycle Bin retention rule. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-delete-rule">
        /// Delete Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Recycle Bin retention rule. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-delete-rule">
        /// Delete Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRule


        /// <summary>
        /// Gets information about a Recycle Bin retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual GetRuleResponse GetRule(GetRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;

            return Invoke<GetRuleResponse>(request, options);
        }


        /// <summary>
        /// Gets information about a Recycle Bin retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/GetRule">REST API Reference for GetRule Operation</seealso>
        public virtual Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRules


        /// <summary>
        /// Lists the Recycle Bin retention rules in the Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual ListRulesResponse ListRules(ListRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;

            return Invoke<ListRulesResponse>(request, options);
        }


        /// <summary>
        /// Lists the Recycle Bin retention rules in the Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRules service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListRules">REST API Reference for ListRules Operation</seealso>
        public virtual Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags assigned to a retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags assigned to a retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  LockRule


        /// <summary>
        /// Locks a Region-level retention rule. A locked retention rule can't be modified or
        /// deleted.
        /// 
        ///  <note> 
        /// <para>
        /// You can't lock tag-level retention rules, or Region-level retention rules that have
        /// exclusion tags.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LockRule service method.</param>
        /// 
        /// <returns>The response from the LockRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/LockRule">REST API Reference for LockRule Operation</seealso>
        public virtual LockRuleResponse LockRule(LockRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LockRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LockRuleResponseUnmarshaller.Instance;

            return Invoke<LockRuleResponse>(request, options);
        }


        /// <summary>
        /// Locks a Region-level retention rule. A locked retention rule can't be modified or
        /// deleted.
        /// 
        ///  <note> 
        /// <para>
        /// You can't lock tag-level retention rules, or Region-level retention rules that have
        /// exclusion tags.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the LockRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the LockRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/LockRule">REST API Reference for LockRule Operation</seealso>
        public virtual Task<LockRuleResponse> LockRuleAsync(LockRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = LockRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = LockRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<LockRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns tags to the specified retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Assigns tags to the specified retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnlockRule


        /// <summary>
        /// Unlocks a retention rule. After a retention rule is unlocked, it can be modified or
        /// deleted only after the unlock delay period expires.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlockRule service method.</param>
        /// 
        /// <returns>The response from the UnlockRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UnlockRule">REST API Reference for UnlockRule Operation</seealso>
        public virtual UnlockRuleResponse UnlockRule(UnlockRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlockRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlockRuleResponseUnmarshaller.Instance;

            return Invoke<UnlockRuleResponse>(request, options);
        }


        /// <summary>
        /// Unlocks a retention rule. After a retention rule is unlocked, it can be modified or
        /// deleted only after the unlock delay period expires.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnlockRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UnlockRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UnlockRule">REST API Reference for UnlockRule Operation</seealso>
        public virtual Task<UnlockRuleResponse> UnlockRuleAsync(UnlockRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnlockRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnlockRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UnlockRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Unassigns a tag from a retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Unassigns a tag from a retention rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRule


        /// <summary>
        /// Updates an existing Recycle Bin retention rule. You can update a retention rule's
        /// description, resource tags, and retention period at any time after creation. You can't
        /// update a retention rule's resource type after creation. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-update-rule">
        /// Update Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateRuleResponse>(request, options);
        }


        /// <summary>
        /// Updates an existing Recycle Bin retention rule. You can update a retention rule's
        /// description, resource tags, and retention period at any time after creation. You can't
        /// update a retention rule's resource type after creation. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/recycle-bin-working-with-rules.html#recycle-bin-update-rule">
        /// Update Recycle Bin retention rules</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRule service method, as returned by RecycleBin.</returns>
        /// <exception cref="Amazon.RecycleBin.Model.ConflictException">
        /// The specified retention rule lock request can't be completed.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.InternalServerException">
        /// The service could not respond to the request due to an internal problem.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ResourceNotFoundException">
        /// The specified resource was not found.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota for the number of tags per resource to be
        /// exceeded.
        /// </exception>
        /// <exception cref="Amazon.RecycleBin.Model.ValidationException">
        /// One or more of the parameters in the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rbin-2021-06-15/UpdateRule">REST API Reference for UpdateRule Operation</seealso>
        public virtual Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuleResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRuleResponse>(request, options, cancellationToken);
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