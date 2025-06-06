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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Chatbot.Model;
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
namespace Amazon.Chatbot.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMicrosoftTeamsChannelConfiguration Request Marshaller
    /// </summary>       
    public class CreateMicrosoftTeamsChannelConfigurationRequestMarshaller : IMarshaller<IRequest, CreateMicrosoftTeamsChannelConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMicrosoftTeamsChannelConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMicrosoftTeamsChannelConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Chatbot");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";
            request.HttpMethod = "POST";

            request.ResourcePath = "/create-ms-teams-channel-configuration";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetChannelId())
            {
                context.Writer.WritePropertyName("ChannelId");
                context.Writer.WriteStringValue(publicRequest.ChannelId);
            }

            if(publicRequest.IsSetChannelName())
            {
                context.Writer.WritePropertyName("ChannelName");
                context.Writer.WriteStringValue(publicRequest.ChannelName);
            }

            if(publicRequest.IsSetConfigurationName())
            {
                context.Writer.WritePropertyName("ConfigurationName");
                context.Writer.WriteStringValue(publicRequest.ConfigurationName);
            }

            if(publicRequest.IsSetGuardrailPolicyArns())
            {
                context.Writer.WritePropertyName("GuardrailPolicyArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGuardrailPolicyArnsListValue in publicRequest.GuardrailPolicyArns)
                {
                        context.Writer.WriteStringValue(publicRequestGuardrailPolicyArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIamRoleArn())
            {
                context.Writer.WritePropertyName("IamRoleArn");
                context.Writer.WriteStringValue(publicRequest.IamRoleArn);
            }

            if(publicRequest.IsSetLoggingLevel())
            {
                context.Writer.WritePropertyName("LoggingLevel");
                context.Writer.WriteStringValue(publicRequest.LoggingLevel);
            }

            if(publicRequest.IsSetSnsTopicArns())
            {
                context.Writer.WritePropertyName("SnsTopicArns");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSnsTopicArnsListValue in publicRequest.SnsTopicArns)
                {
                        context.Writer.WriteStringValue(publicRequestSnsTopicArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTeamId())
            {
                context.Writer.WritePropertyName("TeamId");
                context.Writer.WriteStringValue(publicRequest.TeamId);
            }

            if(publicRequest.IsSetTeamName())
            {
                context.Writer.WritePropertyName("TeamName");
                context.Writer.WriteStringValue(publicRequest.TeamName);
            }

            if(publicRequest.IsSetTenantId())
            {
                context.Writer.WritePropertyName("TenantId");
                context.Writer.WriteStringValue(publicRequest.TenantId);
            }

            if(publicRequest.IsSetUserAuthorizationRequired())
            {
                context.Writer.WritePropertyName("UserAuthorizationRequired");
                context.Writer.WriteBooleanValue(publicRequest.UserAuthorizationRequired.Value);
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
        private static CreateMicrosoftTeamsChannelConfigurationRequestMarshaller _instance = new CreateMicrosoftTeamsChannelConfigurationRequestMarshaller();        

        internal static CreateMicrosoftTeamsChannelConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMicrosoftTeamsChannelConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}