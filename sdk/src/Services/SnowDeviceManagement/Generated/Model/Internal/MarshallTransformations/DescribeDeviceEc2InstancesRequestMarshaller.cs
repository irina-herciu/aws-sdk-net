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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SnowDeviceManagement.Model;
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
namespace Amazon.SnowDeviceManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeDeviceEc2Instances Request Marshaller
    /// </summary>       
    public class DescribeDeviceEc2InstancesRequestMarshaller : IMarshaller<IRequest, DescribeDeviceEc2InstancesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDeviceEc2InstancesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeDeviceEc2InstancesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SnowDeviceManagement");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-08-04";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetManagedDeviceId())
                throw new AmazonSnowDeviceManagementException("Request object does not have required field ManagedDeviceId set");
            request.AddPathResource("{managedDeviceId}", StringUtils.FromString(publicRequest.ManagedDeviceId));
            request.ResourcePath = "/managed-device/{managedDeviceId}/resources/ec2/describe";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetInstanceIds())
            {
                context.Writer.WritePropertyName("instanceIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestInstanceIdsListValue in publicRequest.InstanceIds)
                {
                        context.Writer.WriteStringValue(publicRequestInstanceIdsListValue);
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
        private static DescribeDeviceEc2InstancesRequestMarshaller _instance = new DescribeDeviceEc2InstancesRequestMarshaller();        

        internal static DescribeDeviceEc2InstancesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDeviceEc2InstancesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}