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
 * Do not modify this file. This file is generated from the appconfigdata-2021-11-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.AppConfigData.Model;
using Amazon.AppConfigData.Model.Internal.MarshallTransformations;
using Amazon.AppConfigData.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.AppConfigData
{
    /// <summary>
    /// <para>Implementation for accessing AppConfigData</para>
    ///
    /// AppConfig Data provides the data plane APIs your application uses to retrieve configuration
    /// data. Here's how it works:
    /// 
    ///  
    /// <para>
    /// Your application retrieves configuration data by first establishing a configuration
    /// session using the AppConfig Data <a>StartConfigurationSession</a> API action. Your
    /// session's client then makes periodic calls to <a>GetLatestConfiguration</a> to check
    /// for and retrieve the latest data available.
    /// </para>
    ///  
    /// <para>
    /// When calling <c>StartConfigurationSession</c>, your code sends the following information:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Identifiers (ID or name) of an AppConfig application, environment, and configuration
    /// profile that the session tracks.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) The minimum amount of time the session's client must wait between calls
    /// to <c>GetLatestConfiguration</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// In response, AppConfig provides an <c>InitialConfigurationToken</c> to be given to
    /// the session's client and used the first time it calls <c>GetLatestConfiguration</c>
    /// for that session.
    /// </para>
    ///  <important> 
    /// <para>
    /// This token should only be used once in your first call to <c>GetLatestConfiguration</c>.
    /// You <i>must</i> use the new token in the <c>GetLatestConfiguration</c> response (<c>NextPollConfigurationToken</c>)
    /// in each subsequent call to <c>GetLatestConfiguration</c>.
    /// </para>
    ///  </important> 
    /// <para>
    /// When calling <c>GetLatestConfiguration</c>, your client code sends the most recent
    /// <c>ConfigurationToken</c> value it has and receives in response:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>NextPollConfigurationToken</c>: the <c>ConfigurationToken</c> value to use on
    /// the next call to <c>GetLatestConfiguration</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>NextPollIntervalInSeconds</c>: the duration the client should wait before making
    /// its next call to <c>GetLatestConfiguration</c>. This duration may vary over the course
    /// of the session, so it should be used instead of the value sent on the <c>StartConfigurationSession</c>
    /// call.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The configuration: the latest data intended for the session. This may be empty if
    /// the client already has the latest version of the configuration.
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// The <c>InitialConfigurationToken</c> and <c>NextPollConfigurationToken</c> should
    /// only be used once. To support long poll use cases, the tokens are valid for up to
    /// 24 hours. If a <c>GetLatestConfiguration</c> call uses an expired token, the system
    /// returns <c>BadRequestException</c>.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information and to view example CLI commands that show how to retrieve a
    /// configuration using the AppConfig Data <c>StartConfigurationSession</c> and <c>GetLatestConfiguration</c>
    /// API actions, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Retrieving
    /// the configuration</a> in the <i>AppConfig User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonAppConfigDataClient : AmazonServiceClient, IAmazonAppConfigData
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppConfigDataMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with the credentials loaded from the application's
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
        public AmazonAppConfigDataClient()
            : base(new AmazonAppConfigDataConfig()) { }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with the credentials loaded from the application's
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
        public AmazonAppConfigDataClient(RegionEndpoint region)
            : base(new AmazonAppConfigDataConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAppConfigDataClient Configuration Object</param>
        public AmazonAppConfigDataClient(AmazonAppConfigDataConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppConfigDataClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppConfigDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigDataClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppConfigDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Credentials and an
        /// AmazonAppConfigDataClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppConfigDataClient Configuration Object</param>
        public AmazonAppConfigDataClient(AWSCredentials credentials, AmazonAppConfigDataConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppConfigDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppConfigDataConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppConfigDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppConfigDataClient Configuration Object</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppConfigDataConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppConfigDataConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppConfigDataConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppConfigDataClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppConfigDataClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppConfigDataClient Configuration Object</param>
        public AmazonAppConfigDataClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppConfigDataConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppConfigDataEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonAppConfigDataAuthSchemeHandler());
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


        #region  GetLatestConfiguration


        /// <summary>
        /// Retrieves the latest deployed configuration. This API may return empty configuration
        /// data if the client already has the latest version. For more information about this
        /// API action and to view example CLI commands that show how to use it with the <a>StartConfigurationSession</a>
        /// API action, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Retrieving
        /// the configuration</a> in the <i>AppConfig User Guide</i>. 
        /// 
        ///  <important> 
        /// <para>
        /// Note the following important information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Each configuration token is only valid for one call to <c>GetLatestConfiguration</c>.
        /// The <c>GetLatestConfiguration</c> response includes a <c>NextPollConfigurationToken</c>
        /// that should always replace the token used for the just-completed call in preparation
        /// for the next one. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GetLatestConfiguration</c> is a priced call. For more information, see <a href="https://aws.amazon.com/systems-manager/pricing/">Pricing</a>.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLatestConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLatestConfiguration service method, as returned by AppConfigData.</returns>
        /// <exception cref="Amazon.AppConfigData.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.InternalServerException">
        /// There was an internal failure in the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/GetLatestConfiguration">REST API Reference for GetLatestConfiguration Operation</seealso>
        public virtual GetLatestConfigurationResponse GetLatestConfiguration(GetLatestConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLatestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLatestConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLatestConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the latest deployed configuration. This API may return empty configuration
        /// data if the client already has the latest version. For more information about this
        /// API action and to view example CLI commands that show how to use it with the <a>StartConfigurationSession</a>
        /// API action, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Retrieving
        /// the configuration</a> in the <i>AppConfig User Guide</i>. 
        /// 
        ///  <important> 
        /// <para>
        /// Note the following important information.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Each configuration token is only valid for one call to <c>GetLatestConfiguration</c>.
        /// The <c>GetLatestConfiguration</c> response includes a <c>NextPollConfigurationToken</c>
        /// that should always replace the token used for the just-completed call in preparation
        /// for the next one. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>GetLatestConfiguration</c> is a priced call. For more information, see <a href="https://aws.amazon.com/systems-manager/pricing/">Pricing</a>.
        /// </para>
        ///  </li> </ul> </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLatestConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLatestConfiguration service method, as returned by AppConfigData.</returns>
        /// <exception cref="Amazon.AppConfigData.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.InternalServerException">
        /// There was an internal failure in the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/GetLatestConfiguration">REST API Reference for GetLatestConfiguration Operation</seealso>
        public virtual Task<GetLatestConfigurationResponse> GetLatestConfigurationAsync(GetLatestConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLatestConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLatestConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLatestConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartConfigurationSession


        /// <summary>
        /// Starts a configuration session used to retrieve a deployed configuration. For more
        /// information about this API action and to view example CLI commands that show how to
        /// use it with the <a>GetLatestConfiguration</a> API action, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Retrieving
        /// the configuration</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationSession service method.</param>
        /// 
        /// <returns>The response from the StartConfigurationSession service method, as returned by AppConfigData.</returns>
        /// <exception cref="Amazon.AppConfigData.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.InternalServerException">
        /// There was an internal failure in the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/StartConfigurationSession">REST API Reference for StartConfigurationSession Operation</seealso>
        public virtual StartConfigurationSessionResponse StartConfigurationSession(StartConfigurationSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationSessionResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationSessionResponse>(request, options);
        }


        /// <summary>
        /// Starts a configuration session used to retrieve a deployed configuration. For more
        /// information about this API action and to view example CLI commands that show how to
        /// use it with the <a>GetLatestConfiguration</a> API action, see <a href="http://docs.aws.amazon.com/appconfig/latest/userguide/appconfig-retrieving-the-configuration">Retrieving
        /// the configuration</a> in the <i>AppConfig User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartConfigurationSession service method, as returned by AppConfigData.</returns>
        /// <exception cref="Amazon.AppConfigData.Model.BadRequestException">
        /// The input fails to satisfy the constraints specified by the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.InternalServerException">
        /// There was an internal failure in the service.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ResourceNotFoundException">
        /// The requested resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.AppConfigData.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appconfigdata-2021-11-11/StartConfigurationSession">REST API Reference for StartConfigurationSession Operation</seealso>
        public virtual Task<StartConfigurationSessionResponse> StartConfigurationSessionAsync(StartConfigurationSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationSessionResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartConfigurationSessionResponse>(request, options, cancellationToken);
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