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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
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
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateLocationObjectStorage Request Marshaller
    /// </summary>       
    public class CreateLocationObjectStorageRequestMarshaller : IMarshaller<IRequest, CreateLocationObjectStorageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateLocationObjectStorageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateLocationObjectStorageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.CreateLocationObjectStorage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
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
            if(publicRequest.IsSetAccessKey())
            {
                context.Writer.WritePropertyName("AccessKey");
                context.Writer.WriteStringValue(publicRequest.AccessKey);
            }

            if(publicRequest.IsSetAgentArns())
            {
                context.Writer.WritePropertyName("AgentArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAgentArnsListValue in publicRequest.AgentArns)
                {
                        context.Writer.WriteStringValue(publicRequestAgentArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetBucketName())
            {
                context.Writer.WritePropertyName("BucketName");
                context.Writer.WriteStringValue(publicRequest.BucketName);
            }

            if(publicRequest.IsSetCmkSecretConfig())
            {
                context.Writer.WritePropertyName("CmkSecretConfig");
                context.Writer.WriteStartObject();

                var marshaller = CmkSecretConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CmkSecretConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCustomSecretConfig())
            {
                context.Writer.WritePropertyName("CustomSecretConfig");
                context.Writer.WriteStartObject();

                var marshaller = CustomSecretConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.CustomSecretConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSecretKey())
            {
                context.Writer.WritePropertyName("SecretKey");
                context.Writer.WriteStringValue(publicRequest.SecretKey);
            }

            if(publicRequest.IsSetServerCertificate())
            {
                context.Writer.WritePropertyName("ServerCertificate");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(publicRequest.ServerCertificate));
            }

            if(publicRequest.IsSetServerHostname())
            {
                context.Writer.WritePropertyName("ServerHostname");
                context.Writer.WriteStringValue(publicRequest.ServerHostname);
            }

            if(publicRequest.IsSetServerPort())
            {
                context.Writer.WritePropertyName("ServerPort");
                context.Writer.WriteNumberValue(publicRequest.ServerPort.Value);
            }

            if(publicRequest.IsSetServerProtocol())
            {
                context.Writer.WritePropertyName("ServerProtocol");
                context.Writer.WriteStringValue(publicRequest.ServerProtocol);
            }

            if(publicRequest.IsSetSubdirectory())
            {
                context.Writer.WritePropertyName("Subdirectory");
                context.Writer.WriteStringValue(publicRequest.Subdirectory);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagListEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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
        private static CreateLocationObjectStorageRequestMarshaller _instance = new CreateLocationObjectStorageRequestMarshaller();        

        internal static CreateLocationObjectStorageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLocationObjectStorageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}