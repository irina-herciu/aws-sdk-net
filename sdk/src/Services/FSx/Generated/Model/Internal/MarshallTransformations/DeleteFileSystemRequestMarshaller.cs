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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
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
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteFileSystem Request Marshaller
    /// </summary>       
    public class DeleteFileSystemRequestMarshaller : IMarshaller<IRequest, DeleteFileSystemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteFileSystemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteFileSystemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FSx");
            string target = "AWSSimbaAPIService_v20180301.DeleteFileSystem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-03-01";
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
            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetFileSystemId())
            {
                context.Writer.WritePropertyName("FileSystemId");
                context.Writer.WriteStringValue(publicRequest.FileSystemId);
            }

            if(publicRequest.IsSetLustreConfiguration())
            {
                context.Writer.WritePropertyName("LustreConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeleteFileSystemLustreConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.LustreConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOpenZFSConfiguration())
            {
                context.Writer.WritePropertyName("OpenZFSConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeleteFileSystemOpenZFSConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.OpenZFSConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetWindowsConfiguration())
            {
                context.Writer.WritePropertyName("WindowsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeleteFileSystemWindowsConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.WindowsConfiguration, context);

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
            


            return request;
        }
        private static DeleteFileSystemRequestMarshaller _instance = new DeleteFileSystemRequestMarshaller();        

        internal static DeleteFileSystemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteFileSystemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}