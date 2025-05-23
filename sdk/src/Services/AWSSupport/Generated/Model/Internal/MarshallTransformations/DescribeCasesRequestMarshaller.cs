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
 * Do not modify this file. This file is generated from the support-2013-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSSupport.Model;
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
namespace Amazon.AWSSupport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeCases Request Marshaller
    /// </summary>       
    public class DescribeCasesRequestMarshaller : IMarshaller<IRequest, DescribeCasesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeCasesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeCasesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AWSSupport");
            string target = "AWSSupport_20130415.DescribeCases";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2013-04-15";
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
            if(publicRequest.IsSetAfterTime())
            {
                context.Writer.WritePropertyName("afterTime");
                context.Writer.WriteStringValue(publicRequest.AfterTime);
            }

            if(publicRequest.IsSetBeforeTime())
            {
                context.Writer.WritePropertyName("beforeTime");
                context.Writer.WriteStringValue(publicRequest.BeforeTime);
            }

            if(publicRequest.IsSetCaseIdList())
            {
                context.Writer.WritePropertyName("caseIdList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCaseIdListListValue in publicRequest.CaseIdList)
                {
                        context.Writer.WriteStringValue(publicRequestCaseIdListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDisplayId())
            {
                context.Writer.WritePropertyName("displayId");
                context.Writer.WriteStringValue(publicRequest.DisplayId);
            }

            if(publicRequest.IsSetIncludeCommunications())
            {
                context.Writer.WritePropertyName("includeCommunications");
                context.Writer.WriteBooleanValue(publicRequest.IncludeCommunications.Value);
            }

            if(publicRequest.IsSetIncludeResolvedCases())
            {
                context.Writer.WritePropertyName("includeResolvedCases");
                context.Writer.WriteBooleanValue(publicRequest.IncludeResolvedCases.Value);
            }

            if(publicRequest.IsSetLanguage())
            {
                context.Writer.WritePropertyName("language");
                context.Writer.WriteStringValue(publicRequest.Language);
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
        private static DescribeCasesRequestMarshaller _instance = new DescribeCasesRequestMarshaller();        

        internal static DescribeCasesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeCasesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}