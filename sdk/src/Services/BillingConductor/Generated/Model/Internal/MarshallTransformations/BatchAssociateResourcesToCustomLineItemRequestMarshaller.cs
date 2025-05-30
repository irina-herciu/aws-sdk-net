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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BillingConductor.Model;
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
namespace Amazon.BillingConductor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchAssociateResourcesToCustomLineItem Request Marshaller
    /// </summary>       
    public class BatchAssociateResourcesToCustomLineItemRequestMarshaller : IMarshaller<IRequest, BatchAssociateResourcesToCustomLineItemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchAssociateResourcesToCustomLineItemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchAssociateResourcesToCustomLineItemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BillingConductor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-07-30";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/batch-associate-resources-to-custom-line-item";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetBillingPeriodRange())
            {
                context.Writer.WritePropertyName("BillingPeriodRange");
                context.Writer.WriteStartObject();

                var marshaller = CustomLineItemBillingPeriodRangeMarshaller.Instance;
                marshaller.Marshall(publicRequest.BillingPeriodRange, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetResourceArns())
            {
                context.Writer.WritePropertyName("ResourceArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestResourceArnsListValue in publicRequest.ResourceArns)
                {
                        context.Writer.WriteStringValue(publicRequestResourceArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTargetArn())
            {
                context.Writer.WritePropertyName("TargetArn");
                context.Writer.WriteStringValue(publicRequest.TargetArn);
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
        private static BatchAssociateResourcesToCustomLineItemRequestMarshaller _instance = new BatchAssociateResourcesToCustomLineItemRequestMarshaller();        

        internal static BatchAssociateResourcesToCustomLineItemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchAssociateResourcesToCustomLineItemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}