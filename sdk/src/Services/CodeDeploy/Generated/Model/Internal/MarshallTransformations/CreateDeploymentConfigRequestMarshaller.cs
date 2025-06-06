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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDeploymentConfig Request Marshaller
    /// </summary>       
    public class CreateDeploymentConfigRequestMarshaller : IMarshaller<IRequest, CreateDeploymentConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDeploymentConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDeploymentConfigRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeDeploy");
            string target = "CodeDeploy_20141006.CreateDeploymentConfig";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-10-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetComputePlatform())
            {
                context.Writer.WritePropertyName("computePlatform");
                context.Writer.WriteStringValue(publicRequest.ComputePlatform);
            }

            if(publicRequest.IsSetDeploymentConfigName())
            {
                context.Writer.WritePropertyName("deploymentConfigName");
                context.Writer.WriteStringValue(publicRequest.DeploymentConfigName);
            }

            if(publicRequest.IsSetMinimumHealthyHosts())
            {
                context.Writer.WritePropertyName("minimumHealthyHosts");
                context.Writer.WriteStartObject();

                var marshaller = MinimumHealthyHostsMarshaller.Instance;
                marshaller.Marshall(publicRequest.MinimumHealthyHosts, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTrafficRoutingConfig())
            {
                context.Writer.WritePropertyName("trafficRoutingConfig");
                context.Writer.WriteStartObject();

                var marshaller = TrafficRoutingConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.TrafficRoutingConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetZonalConfig())
            {
                context.Writer.WritePropertyName("zonalConfig");
                context.Writer.WriteStartObject();

                var marshaller = ZonalConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.ZonalConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateDeploymentConfigRequestMarshaller _instance = new CreateDeploymentConfigRequestMarshaller();        

        internal static CreateDeploymentConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDeploymentConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}