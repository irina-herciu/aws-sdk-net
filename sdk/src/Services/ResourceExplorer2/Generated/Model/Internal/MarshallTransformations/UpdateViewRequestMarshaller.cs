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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ResourceExplorer2.Model;
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
namespace Amazon.ResourceExplorer2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateView Request Marshaller
    /// </summary>       
    public class UpdateViewRequestMarshaller : IMarshaller<IRequest, UpdateViewRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateViewRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateViewRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ResourceExplorer2");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-07-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateView";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("Filters");
                context.Writer.WriteStartObject();

                var marshaller = SearchFilterMarshaller.Instance;
                marshaller.Marshall(publicRequest.Filters, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIncludedProperties())
            {
                context.Writer.WritePropertyName("IncludedProperties");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIncludedPropertiesListValue in publicRequest.IncludedProperties)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = IncludedPropertyMarshaller.Instance;
                    marshaller.Marshall(publicRequestIncludedPropertiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetViewArn())
            {
                context.Writer.WritePropertyName("ViewArn");
                context.Writer.WriteStringValue(publicRequest.ViewArn);
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
        private static UpdateViewRequestMarshaller _instance = new UpdateViewRequestMarshaller();        

        internal static UpdateViewRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateViewRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}