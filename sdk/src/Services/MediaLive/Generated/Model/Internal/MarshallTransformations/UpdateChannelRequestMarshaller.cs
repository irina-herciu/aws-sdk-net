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
 * Do not modify this file. This file is generated from the medialive-2017-10-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaLive.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MediaLive.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateChannel Request Marshaller
    /// </summary>       
    public class UpdateChannelRequestMarshaller : IMarshaller<IRequest, UpdateChannelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateChannelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateChannelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MediaLive");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-14";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetChannelId())
                throw new AmazonMediaLiveException("Request object does not have required field ChannelId set");
            request.AddPathResource("{channelId}", StringUtils.FromString(publicRequest.ChannelId));
            request.ResourcePath = "/prod/channels/{channelId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCdiInputSpecification())
                {
                    context.Writer.WritePropertyName("cdiInputSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = CdiInputSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CdiInputSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetChannelEngineVersion())
                {
                    context.Writer.WritePropertyName("channelEngineVersion");
                    context.Writer.WriteObjectStart();

                    var marshaller = ChannelEngineVersionRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ChannelEngineVersion, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDestinations())
                {
                    context.Writer.WritePropertyName("destinations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDestinationsListValue in publicRequest.Destinations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = OutputDestinationMarshaller.Instance;
                        marshaller.Marshall(publicRequestDestinationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDryRun())
                {
                    context.Writer.WritePropertyName("dryRun");
                    context.Writer.Write(publicRequest.DryRun);
                }

                if(publicRequest.IsSetEncoderSettings())
                {
                    context.Writer.WritePropertyName("encoderSettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncoderSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncoderSettings, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetInputAttachments())
                {
                    context.Writer.WritePropertyName("inputAttachments");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestInputAttachmentsListValue in publicRequest.InputAttachments)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = InputAttachmentMarshaller.Instance;
                        marshaller.Marshall(publicRequestInputAttachmentsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInputSpecification())
                {
                    context.Writer.WritePropertyName("inputSpecification");
                    context.Writer.WriteObjectStart();

                    var marshaller = InputSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InputSpecification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogLevel())
                {
                    context.Writer.WritePropertyName("logLevel");
                    context.Writer.Write(publicRequest.LogLevel);
                }

                if(publicRequest.IsSetMaintenance())
                {
                    context.Writer.WritePropertyName("maintenance");
                    context.Writer.WriteObjectStart();

                    var marshaller = MaintenanceUpdateSettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Maintenance, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateChannelRequestMarshaller _instance = new UpdateChannelRequestMarshaller();        

        internal static UpdateChannelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateChannelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}