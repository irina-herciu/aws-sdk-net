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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
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
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeJobDefinitions Request Marshaller
    /// </summary>       
    public class DescribeJobDefinitionsRequestMarshaller : IMarshaller<IRequest, DescribeJobDefinitionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeJobDefinitionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeJobDefinitionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Batch");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-08-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/v1/describejobdefinitions";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetJobDefinitionName())
            {
                context.Writer.WritePropertyName("jobDefinitionName");
                context.Writer.WriteStringValue(publicRequest.JobDefinitionName);
            }

            if(publicRequest.IsSetJobDefinitions())
            {
                context.Writer.WritePropertyName("jobDefinitions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestJobDefinitionsListValue in publicRequest.JobDefinitions)
                {
                        context.Writer.WriteStringValue(publicRequestJobDefinitionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("maxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("nextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("status");
                context.Writer.WriteStringValue(publicRequest.Status);
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
        private static DescribeJobDefinitionsRequestMarshaller _instance = new DescribeJobDefinitionsRequestMarshaller();        

        internal static DescribeJobDefinitionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeJobDefinitionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}