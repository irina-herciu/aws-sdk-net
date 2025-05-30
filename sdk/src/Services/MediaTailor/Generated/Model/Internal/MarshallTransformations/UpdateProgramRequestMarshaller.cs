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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaTailor.Model;
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
namespace Amazon.MediaTailor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateProgram Request Marshaller
    /// </summary>       
    public class UpdateProgramRequestMarshaller : IMarshaller<IRequest, UpdateProgramRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateProgramRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateProgramRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaTailor");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-23";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetChannelName())
                throw new AmazonMediaTailorException("Request object does not have required field ChannelName set");
            request.AddPathResource("{ChannelName}", StringUtils.FromString(publicRequest.ChannelName));
            if (!publicRequest.IsSetProgramName())
                throw new AmazonMediaTailorException("Request object does not have required field ProgramName set");
            request.AddPathResource("{ProgramName}", StringUtils.FromString(publicRequest.ProgramName));
            request.ResourcePath = "/channel/{ChannelName}/program/{ProgramName}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdBreaks())
            {
                context.Writer.WritePropertyName("AdBreaks");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAdBreaksListValue in publicRequest.AdBreaks)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AdBreakMarshaller.Instance;
                    marshaller.Marshall(publicRequestAdBreaksListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetAudienceMedia())
            {
                context.Writer.WritePropertyName("AudienceMedia");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAudienceMediaListValue in publicRequest.AudienceMedia)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AudienceMediaMarshaller.Instance;
                    marshaller.Marshall(publicRequestAudienceMediaListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetScheduleConfiguration())
            {
                context.Writer.WritePropertyName("ScheduleConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = UpdateProgramScheduleConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ScheduleConfiguration, context);

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
        private static UpdateProgramRequestMarshaller _instance = new UpdateProgramRequestMarshaller();        

        internal static UpdateProgramRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateProgramRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}