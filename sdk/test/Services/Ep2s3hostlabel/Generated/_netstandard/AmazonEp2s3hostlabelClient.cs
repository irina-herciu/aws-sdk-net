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
 * Do not modify this file. This file is generated from the ep2-s3-host-label-2022-08-24.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Ep2s3hostlabel.Model;
using Amazon.Ep2s3hostlabel.Model.Internal.MarshallTransformations;
using Amazon.Ep2s3hostlabel.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Ep2s3hostlabel
{
    /// <summary>
    /// <para>Implementation for accessing Ep2s3hostlabel</para>
    ///
    /// 
    /// </summary>
    public partial class AmazonEp2s3hostlabelClient : AmazonServiceClient, IAmazonEp2s3hostlabel
    {
        private static IServiceMetadata serviceMetadata = new AmazonEp2s3hostlabelMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with the credentials loaded from the application's
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
        public AmazonEp2s3hostlabelClient()
            : base(new AmazonEp2s3hostlabelConfig()) { }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with the credentials loaded from the application's
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
        public AmazonEp2s3hostlabelClient(RegionEndpoint region)
            : base(new AmazonEp2s3hostlabelConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEp2s3hostlabelClient Configuration Object</param>
        public AmazonEp2s3hostlabelClient(AmazonEp2s3hostlabelConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEp2s3hostlabelClient(AWSCredentials credentials)
            : this(credentials, new AmazonEp2s3hostlabelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2s3hostlabelClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEp2s3hostlabelConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Credentials and an
        /// AmazonEp2s3hostlabelClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEp2s3hostlabelClient Configuration Object</param>
        public AmazonEp2s3hostlabelClient(AWSCredentials credentials, AmazonEp2s3hostlabelConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEp2s3hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2s3hostlabelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2s3hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEp2s3hostlabelConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2s3hostlabelClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEp2s3hostlabelClient Configuration Object</param>
        public AmazonEp2s3hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEp2s3hostlabelConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEp2s3hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2s3hostlabelConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEp2s3hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEp2s3hostlabelConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEp2s3hostlabelClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEp2s3hostlabelClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEp2s3hostlabelClient Configuration Object</param>
        public AmazonEp2s3hostlabelClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEp2s3hostlabelConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEp2s3hostlabelEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEp2s3hostlabelAuthSchemeHandler());
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


        #region  MyOperation

        internal virtual MyOperationResponse MyOperation(MyOperationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MyOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MyOperationResponseUnmarshaller.Instance;

            return Invoke<MyOperationResponse>(request, options);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MyOperation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the MyOperation service method, as returned by Ep2s3hostlabel.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ep2-s3-host-label-2022-08-24/MyOperation">REST API Reference for MyOperation Operation</seealso>
        public virtual Task<MyOperationResponse> MyOperationAsync(MyOperationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MyOperationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MyOperationResponseUnmarshaller.Instance;

            return InvokeAsync<MyOperationResponse>(request, options, cancellationToken);
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