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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
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
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FilterLogEvents Request Marshaller
    /// </summary>       
    public class FilterLogEventsRequestMarshaller : IMarshaller<IRequest, FilterLogEventsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((FilterLogEventsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(FilterLogEventsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudWatchLogs");
            string target = "Logs_20140328.FilterLogEvents";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-03-28";
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
            if(publicRequest.IsSetEndTime())
            {
                context.Writer.WritePropertyName("endTime");
                context.Writer.WriteNumberValue(publicRequest.EndTime.Value);
            }

            if(publicRequest.IsSetFilterPattern())
            {
                context.Writer.WritePropertyName("filterPattern");
                context.Writer.WriteStringValue(publicRequest.FilterPattern);
            }

            if(publicRequest.IsSetInterleaved())
            {
                context.Writer.WritePropertyName("interleaved");
                context.Writer.WriteBooleanValue(publicRequest.Interleaved.Value);
            }

            if(publicRequest.IsSetLimit())
            {
                context.Writer.WritePropertyName("limit");
                context.Writer.WriteNumberValue(publicRequest.Limit.Value);
            }

            if(publicRequest.IsSetLogGroupIdentifier())
            {
                context.Writer.WritePropertyName("logGroupIdentifier");
                context.Writer.WriteStringValue(publicRequest.LogGroupIdentifier);
            }

            if(publicRequest.IsSetLogGroupName())
            {
                context.Writer.WritePropertyName("logGroupName");
                context.Writer.WriteStringValue(publicRequest.LogGroupName);
            }

            if(publicRequest.IsSetLogStreamNamePrefix())
            {
                context.Writer.WritePropertyName("logStreamNamePrefix");
                context.Writer.WriteStringValue(publicRequest.LogStreamNamePrefix);
            }

            if(publicRequest.IsSetLogStreamNames())
            {
                context.Writer.WritePropertyName("logStreamNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLogStreamNamesListValue in publicRequest.LogStreamNames)
                {
                        context.Writer.WriteStringValue(publicRequestLogStreamNamesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("nextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetStartTime())
            {
                context.Writer.WritePropertyName("startTime");
                context.Writer.WriteNumberValue(publicRequest.StartTime.Value);
            }

            if(publicRequest.IsSetUnmask())
            {
                context.Writer.WritePropertyName("unmask");
                context.Writer.WriteBooleanValue(publicRequest.Unmask.Value);
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
        private static FilterLogEventsRequestMarshaller _instance = new FilterLogEventsRequestMarshaller();        

        internal static FilterLogEventsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FilterLogEventsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}