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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JupyterLabAppSettings Marshaller
    /// </summary>
    public class JupyterLabAppSettingsMarshaller : IRequestMarshaller<JupyterLabAppSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JupyterLabAppSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAppLifecycleManagement())
            {
                context.Writer.WritePropertyName("AppLifecycleManagement");
                context.Writer.WriteStartObject();

                var marshaller = AppLifecycleManagementMarshaller.Instance;
                marshaller.Marshall(requestObject.AppLifecycleManagement, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBuiltInLifecycleConfigArn())
            {
                context.Writer.WritePropertyName("BuiltInLifecycleConfigArn");
                context.Writer.WriteStringValue(requestObject.BuiltInLifecycleConfigArn);
            }

            if(requestObject.IsSetCodeRepositories())
            {
                context.Writer.WritePropertyName("CodeRepositories");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCodeRepositoriesListValue in requestObject.CodeRepositories)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CodeRepositoryMarshaller.Instance;
                    marshaller.Marshall(requestObjectCodeRepositoriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCustomImages())
            {
                context.Writer.WritePropertyName("CustomImages");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCustomImagesListValue in requestObject.CustomImages)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CustomImageMarshaller.Instance;
                    marshaller.Marshall(requestObjectCustomImagesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDefaultResourceSpec())
            {
                context.Writer.WritePropertyName("DefaultResourceSpec");
                context.Writer.WriteStartObject();

                var marshaller = ResourceSpecMarshaller.Instance;
                marshaller.Marshall(requestObject.DefaultResourceSpec, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEmrSettings())
            {
                context.Writer.WritePropertyName("EmrSettings");
                context.Writer.WriteStartObject();

                var marshaller = EmrSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.EmrSettings, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLifecycleConfigArns())
            {
                context.Writer.WritePropertyName("LifecycleConfigArns");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLifecycleConfigArnsListValue in requestObject.LifecycleConfigArns)
                {
                        context.Writer.WriteStringValue(requestObjectLifecycleConfigArnsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JupyterLabAppSettingsMarshaller Instance = new JupyterLabAppSettingsMarshaller();

    }
}