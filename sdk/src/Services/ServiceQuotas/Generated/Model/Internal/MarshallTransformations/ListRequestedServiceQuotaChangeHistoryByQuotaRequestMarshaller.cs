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
 * Do not modify this file. This file is generated from the service-quotas-2019-06-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ServiceQuotas.Model;
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
namespace Amazon.ServiceQuotas.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListRequestedServiceQuotaChangeHistoryByQuota Request Marshaller
    /// </summary>       
    public class ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller : IMarshaller<IRequest, ListRequestedServiceQuotaChangeHistoryByQuotaRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListRequestedServiceQuotaChangeHistoryByQuotaRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListRequestedServiceQuotaChangeHistoryByQuotaRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ServiceQuotas");
            string target = "ServiceQuotasV20190624.ListRequestedServiceQuotaChangeHistoryByQuota";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-06-24";
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
            if(publicRequest.IsSetMaxResults())
            {
                context.Writer.WritePropertyName("MaxResults");
                context.Writer.WriteNumberValue(publicRequest.MaxResults.Value);
            }

            if(publicRequest.IsSetNextToken())
            {
                context.Writer.WritePropertyName("NextToken");
                context.Writer.WriteStringValue(publicRequest.NextToken);
            }

            if(publicRequest.IsSetQuotaCode())
            {
                context.Writer.WritePropertyName("QuotaCode");
                context.Writer.WriteStringValue(publicRequest.QuotaCode);
            }

            if(publicRequest.IsSetQuotaRequestedAtLevel())
            {
                context.Writer.WritePropertyName("QuotaRequestedAtLevel");
                context.Writer.WriteStringValue(publicRequest.QuotaRequestedAtLevel);
            }

            if(publicRequest.IsSetServiceCode())
            {
                context.Writer.WritePropertyName("ServiceCode");
                context.Writer.WriteStringValue(publicRequest.ServiceCode);
            }

            if(publicRequest.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
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
        private static ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller _instance = new ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller();        

        internal static ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListRequestedServiceQuotaChangeHistoryByQuotaRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}