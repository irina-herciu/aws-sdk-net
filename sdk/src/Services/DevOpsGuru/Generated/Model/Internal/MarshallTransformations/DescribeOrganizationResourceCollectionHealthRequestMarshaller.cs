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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsGuru.Model;
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
namespace Amazon.DevOpsGuru.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeOrganizationResourceCollectionHealth Request Marshaller
    /// </summary>       
    public class DescribeOrganizationResourceCollectionHealthRequestMarshaller : IMarshaller<IRequest, DescribeOrganizationResourceCollectionHealthRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeOrganizationResourceCollectionHealthRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeOrganizationResourceCollectionHealthRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DevOpsGuru");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/organization/health/resource-collection";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("AccountIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                {
                        context.Writer.WriteStringValue(publicRequestAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

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

            if(publicRequest.IsSetOrganizationalUnitIds())
            {
                context.Writer.WritePropertyName("OrganizationalUnitIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestOrganizationalUnitIdsListValue in publicRequest.OrganizationalUnitIds)
                {
                        context.Writer.WriteStringValue(publicRequestOrganizationalUnitIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOrganizationResourceCollectionType())
            {
                context.Writer.WritePropertyName("OrganizationResourceCollectionType");
                context.Writer.WriteStringValue(publicRequest.OrganizationResourceCollectionType);
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
        private static DescribeOrganizationResourceCollectionHealthRequestMarshaller _instance = new DescribeOrganizationResourceCollectionHealthRequestMarshaller();        

        internal static DescribeOrganizationResourceCollectionHealthRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeOrganizationResourceCollectionHealthRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}