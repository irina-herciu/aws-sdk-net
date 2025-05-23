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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RedshiftServerless.Model;
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
namespace Amazon.RedshiftServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEndpointAccess Request Marshaller
    /// </summary>       
    public class CreateEndpointAccessRequestMarshaller : IMarshaller<IRequest, CreateEndpointAccessRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEndpointAccessRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEndpointAccessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.RedshiftServerless");
            string target = "RedshiftServerless.CreateEndpointAccess";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-04-21";
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
            if(publicRequest.IsSetEndpointName())
            {
                context.Writer.WritePropertyName("endpointName");
                context.Writer.WriteStringValue(publicRequest.EndpointName);
            }

            if(publicRequest.IsSetOwnerAccount())
            {
                context.Writer.WritePropertyName("ownerAccount");
                context.Writer.WriteStringValue(publicRequest.OwnerAccount);
            }

            if(publicRequest.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("subnetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                {
                        context.Writer.WriteStringValue(publicRequestSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVpcSecurityGroupIds())
            {
                context.Writer.WritePropertyName("vpcSecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVpcSecurityGroupIdsListValue in publicRequest.VpcSecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestVpcSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetWorkgroupName())
            {
                context.Writer.WritePropertyName("workgroupName");
                context.Writer.WriteStringValue(publicRequest.WorkgroupName);
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
        private static CreateEndpointAccessRequestMarshaller _instance = new CreateEndpointAccessRequestMarshaller();        

        internal static CreateEndpointAccessRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEndpointAccessRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}