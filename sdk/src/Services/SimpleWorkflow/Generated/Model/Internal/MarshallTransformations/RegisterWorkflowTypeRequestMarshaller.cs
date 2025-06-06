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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
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
namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterWorkflowType Request Marshaller
    /// </summary>       
    public class RegisterWorkflowTypeRequestMarshaller : IMarshaller<IRequest, RegisterWorkflowTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterWorkflowTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterWorkflowTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleWorkflow");
            string target = "SimpleWorkflowService.RegisterWorkflowType";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-01-25";
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
            if(publicRequest.IsSetDefaultChildPolicy())
            {
                context.Writer.WritePropertyName("defaultChildPolicy");
                context.Writer.WriteStringValue(publicRequest.DefaultChildPolicy);
            }

            if(publicRequest.IsSetDefaultExecutionStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("defaultExecutionStartToCloseTimeout");
                context.Writer.WriteStringValue(publicRequest.DefaultExecutionStartToCloseTimeout);
            }

            if(publicRequest.IsSetDefaultLambdaRole())
            {
                context.Writer.WritePropertyName("defaultLambdaRole");
                context.Writer.WriteStringValue(publicRequest.DefaultLambdaRole);
            }

            if(publicRequest.IsSetDefaultTaskList())
            {
                context.Writer.WritePropertyName("defaultTaskList");
                context.Writer.WriteStartObject();

                var marshaller = TaskListMarshaller.Instance;
                marshaller.Marshall(publicRequest.DefaultTaskList, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDefaultTaskPriority())
            {
                context.Writer.WritePropertyName("defaultTaskPriority");
                context.Writer.WriteStringValue(publicRequest.DefaultTaskPriority);
            }

            if(publicRequest.IsSetDefaultTaskStartToCloseTimeout())
            {
                context.Writer.WritePropertyName("defaultTaskStartToCloseTimeout");
                context.Writer.WriteStringValue(publicRequest.DefaultTaskStartToCloseTimeout);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetDomain())
            {
                context.Writer.WritePropertyName("domain");
                context.Writer.WriteStringValue(publicRequest.Domain);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetVersion())
            {
                context.Writer.WritePropertyName("version");
                context.Writer.WriteStringValue(publicRequest.Version);
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
        private static RegisterWorkflowTypeRequestMarshaller _instance = new RegisterWorkflowTypeRequestMarshaller();        

        internal static RegisterWorkflowTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterWorkflowTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}