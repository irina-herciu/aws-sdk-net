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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FIS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.FIS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateExperimentTemplate Request Marshaller
    /// </summary>       
    public class CreateExperimentTemplateRequestMarshaller : IMarshaller<IRequest, CreateExperimentTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateExperimentTemplateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateExperimentTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FIS");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-12-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/experimentTemplates";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetActions())
                {
                    context.Writer.WritePropertyName("actions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestActionsKvp in publicRequest.Actions)
                    {
                        context.Writer.WritePropertyName(publicRequestActionsKvp.Key);
                        var publicRequestActionsValue = publicRequestActionsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = CreateExperimentTemplateActionInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestActionsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetExperimentOptions())
                {
                    context.Writer.WritePropertyName("experimentOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = CreateExperimentTemplateExperimentOptionsInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExperimentOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExperimentReportConfiguration())
                {
                    context.Writer.WritePropertyName("experimentReportConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CreateExperimentTemplateReportConfigurationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ExperimentReportConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogConfiguration())
                {
                    context.Writer.WritePropertyName("logConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CreateExperimentTemplateLogConfigurationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LogConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRoleArn())
                {
                    context.Writer.WritePropertyName("roleArn");
                    context.Writer.Write(publicRequest.RoleArn);
                }

                if(publicRequest.IsSetStopConditions())
                {
                    context.Writer.WritePropertyName("stopConditions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStopConditionsListValue in publicRequest.StopConditions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CreateExperimentTemplateStopConditionInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestStopConditionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTargets())
                {
                    context.Writer.WritePropertyName("targets");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTargetsKvp in publicRequest.Targets)
                    {
                        context.Writer.WritePropertyName(publicRequestTargetsKvp.Key);
                        var publicRequestTargetsValue = publicRequestTargetsKvp.Value;

                        context.Writer.WriteObjectStart();

                        var marshaller = CreateExperimentTemplateTargetInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestTargetsValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateExperimentTemplateRequestMarshaller _instance = new CreateExperimentTemplateRequestMarshaller();        

        internal static CreateExperimentTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateExperimentTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}