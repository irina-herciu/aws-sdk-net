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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Proton.Model;
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
namespace Amazon.Proton.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEnvironment Request Marshaller
    /// </summary>       
    public class CreateEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Proton");
            string target = "AwsProton20200720.CreateEnvironment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-20";
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
            if(publicRequest.IsSetCodebuildRoleArn())
            {
                context.Writer.WritePropertyName("codebuildRoleArn");
                context.Writer.WriteStringValue(publicRequest.CodebuildRoleArn);
            }

            if(publicRequest.IsSetComponentRoleArn())
            {
                context.Writer.WritePropertyName("componentRoleArn");
                context.Writer.WriteStringValue(publicRequest.ComponentRoleArn);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnvironmentAccountConnectionId())
            {
                context.Writer.WritePropertyName("environmentAccountConnectionId");
                context.Writer.WriteStringValue(publicRequest.EnvironmentAccountConnectionId);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProtonServiceRoleArn())
            {
                context.Writer.WritePropertyName("protonServiceRoleArn");
                context.Writer.WriteStringValue(publicRequest.ProtonServiceRoleArn);
            }

            if(publicRequest.IsSetProvisioningRepository())
            {
                context.Writer.WritePropertyName("provisioningRepository");
                context.Writer.WriteStartObject();

                var marshaller = RepositoryBranchInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.ProvisioningRepository, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSpec())
            {
                context.Writer.WritePropertyName("spec");
                context.Writer.WriteStringValue(publicRequest.Spec);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTemplateMajorVersion())
            {
                context.Writer.WritePropertyName("templateMajorVersion");
                context.Writer.WriteStringValue(publicRequest.TemplateMajorVersion);
            }

            if(publicRequest.IsSetTemplateMinorVersion())
            {
                context.Writer.WritePropertyName("templateMinorVersion");
                context.Writer.WriteStringValue(publicRequest.TemplateMinorVersion);
            }

            if(publicRequest.IsSetTemplateName())
            {
                context.Writer.WritePropertyName("templateName");
                context.Writer.WriteStringValue(publicRequest.TemplateName);
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
        private static CreateEnvironmentRequestMarshaller _instance = new CreateEnvironmentRequestMarshaller();        

        internal static CreateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}