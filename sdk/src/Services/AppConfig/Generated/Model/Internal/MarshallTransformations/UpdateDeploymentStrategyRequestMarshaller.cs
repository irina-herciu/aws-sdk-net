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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfig.Model;
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
namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDeploymentStrategy Request Marshaller
    /// </summary>       
    public class UpdateDeploymentStrategyRequestMarshaller : IMarshaller<IRequest, UpdateDeploymentStrategyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDeploymentStrategyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDeploymentStrategyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetDeploymentStrategyId())
                throw new AmazonAppConfigException("Request object does not have required field DeploymentStrategyId set");
            request.AddPathResource("{DeploymentStrategyId}", StringUtils.FromString(publicRequest.DeploymentStrategyId));
            request.ResourcePath = "/deploymentstrategies/{DeploymentStrategyId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDeploymentDurationInMinutes())
            {
                context.Writer.WritePropertyName("DeploymentDurationInMinutes");
                context.Writer.WriteNumberValue(publicRequest.DeploymentDurationInMinutes.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetFinalBakeTimeInMinutes())
            {
                context.Writer.WritePropertyName("FinalBakeTimeInMinutes");
                context.Writer.WriteNumberValue(publicRequest.FinalBakeTimeInMinutes.Value);
            }

            if(publicRequest.IsSetGrowthFactor())
            {
                context.Writer.WritePropertyName("GrowthFactor");
                if(StringUtils.IsSpecialFloatValue(publicRequest.GrowthFactor.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialFloatValue(publicRequest.GrowthFactor.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(publicRequest.GrowthFactor.Value);
                }
            }

            if(publicRequest.IsSetGrowthType())
            {
                context.Writer.WritePropertyName("GrowthType");
                context.Writer.WriteStringValue(publicRequest.GrowthType);
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
        private static UpdateDeploymentStrategyRequestMarshaller _instance = new UpdateDeploymentStrategyRequestMarshaller();        

        internal static UpdateDeploymentStrategyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDeploymentStrategyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}