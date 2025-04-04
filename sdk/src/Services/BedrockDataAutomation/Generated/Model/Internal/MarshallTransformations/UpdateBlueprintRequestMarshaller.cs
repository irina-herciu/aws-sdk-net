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
 * Do not modify this file. This file is generated from the bedrock-data-automation-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockDataAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockDataAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateBlueprint Request Marshaller
    /// </summary>       
    public class UpdateBlueprintRequestMarshaller : IMarshaller<IRequest, UpdateBlueprintRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateBlueprintRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateBlueprintRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockDataAutomation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBlueprintArn())
                throw new AmazonBedrockDataAutomationException("Request object does not have required field BlueprintArn set");
            request.AddPathResource("{blueprintArn}", StringUtils.FromString(publicRequest.BlueprintArn));
            request.ResourcePath = "/blueprints/{blueprintArn}/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBlueprintStage())
                {
                    context.Writer.WritePropertyName("blueprintStage");
                    context.Writer.Write(publicRequest.BlueprintStage);
                }

                if(publicRequest.IsSetEncryptionConfiguration())
                {
                    context.Writer.WritePropertyName("encryptionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSchema())
                {
                    context.Writer.WritePropertyName("schema");
                    context.Writer.Write(publicRequest.Schema);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateBlueprintRequestMarshaller _instance = new UpdateBlueprintRequestMarshaller();        

        internal static UpdateBlueprintRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateBlueprintRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}