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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
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
namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateIndex Request Marshaller
    /// </summary>       
    public class CreateIndexRequestMarshaller : IMarshaller<IRequest, CreateIndexRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateIndexRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateIndexRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudDirectory");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-11";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/amazonclouddirectory/2017-01-11/index";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetIsUnique())
            {
                context.Writer.WritePropertyName("IsUnique");
                context.Writer.WriteBooleanValue(publicRequest.IsUnique.Value);
            }

            if(publicRequest.IsSetLinkName())
            {
                context.Writer.WritePropertyName("LinkName");
                context.Writer.WriteStringValue(publicRequest.LinkName);
            }

            if(publicRequest.IsSetOrderedIndexedAttributeList())
            {
                context.Writer.WritePropertyName("OrderedIndexedAttributeList");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOrderedIndexedAttributeListListValue in publicRequest.OrderedIndexedAttributeList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeKeyMarshaller.Instance;
                    marshaller.Marshall(publicRequestOrderedIndexedAttributeListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetParentReference())
            {
                context.Writer.WritePropertyName("ParentReference");
                context.Writer.WriteStartObject();

                var marshaller = ObjectReferenceMarshaller.Instance;
                marshaller.Marshall(publicRequest.ParentReference, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

        
            if (publicRequest.IsSetDirectoryArn()) 
            {
                request.Headers["x-amz-data-partition"] = publicRequest.DirectoryArn;
            }

            return request;
        }
        private static CreateIndexRequestMarshaller _instance = new CreateIndexRequestMarshaller();        

        internal static CreateIndexRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateIndexRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}