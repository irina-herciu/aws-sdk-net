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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
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
namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateThingGroupsForThing Request Marshaller
    /// </summary>       
    public class UpdateThingGroupsForThingRequestMarshaller : IMarshaller<IRequest, UpdateThingGroupsForThingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateThingGroupsForThingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateThingGroupsForThingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/thing-groups/updateThingGroupsForThing";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetOverrideDynamicGroups())
            {
                context.Writer.WritePropertyName("overrideDynamicGroups");
                context.Writer.WriteBooleanValue(publicRequest.OverrideDynamicGroups.Value);
            }

            if(publicRequest.IsSetThingGroupsToAdd())
            {
                context.Writer.WritePropertyName("thingGroupsToAdd");
                context.Writer.WriteStartArray();
                foreach(var publicRequestThingGroupsToAddListValue in publicRequest.ThingGroupsToAdd)
                {
                        context.Writer.WriteStringValue(publicRequestThingGroupsToAddListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetThingGroupsToRemove())
            {
                context.Writer.WritePropertyName("thingGroupsToRemove");
                context.Writer.WriteStartArray();
                foreach(var publicRequestThingGroupsToRemoveListValue in publicRequest.ThingGroupsToRemove)
                {
                        context.Writer.WriteStringValue(publicRequestThingGroupsToRemoveListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetThingName())
            {
                context.Writer.WritePropertyName("thingName");
                context.Writer.WriteStringValue(publicRequest.ThingName);
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
        private static UpdateThingGroupsForThingRequestMarshaller _instance = new UpdateThingGroupsForThingRequestMarshaller();        

        internal static UpdateThingGroupsForThingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateThingGroupsForThingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}