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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KinesisVideo.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.KinesisVideo.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImageGenerationConfiguration Marshaller
    /// </summary>
    public class ImageGenerationConfigurationMarshaller : IRequestMarshaller<ImageGenerationConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ImageGenerationConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationConfig())
            {
                context.Writer.WritePropertyName("DestinationConfig");
                context.Writer.WriteStartObject();

                var marshaller = ImageGenerationDestinationConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.DestinationConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFormat())
            {
                context.Writer.WritePropertyName("Format");
                context.Writer.WriteStringValue(requestObject.Format);
            }

            if(requestObject.IsSetFormatConfig())
            {
                context.Writer.WritePropertyName("FormatConfig");
                context.Writer.WriteStartObject();
                foreach (var requestObjectFormatConfigKvp in requestObject.FormatConfig)
                {
                    context.Writer.WritePropertyName(requestObjectFormatConfigKvp.Key);
                    var requestObjectFormatConfigValue = requestObjectFormatConfigKvp.Value;

                        context.Writer.WriteStringValue(requestObjectFormatConfigValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetHeightPixels())
            {
                context.Writer.WritePropertyName("HeightPixels");
                context.Writer.WriteNumberValue(requestObject.HeightPixels.Value);
            }

            if(requestObject.IsSetImageSelectorType())
            {
                context.Writer.WritePropertyName("ImageSelectorType");
                context.Writer.WriteStringValue(requestObject.ImageSelectorType);
            }

            if(requestObject.IsSetSamplingInterval())
            {
                context.Writer.WritePropertyName("SamplingInterval");
                context.Writer.WriteNumberValue(requestObject.SamplingInterval.Value);
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.WriteStringValue(requestObject.Status);
            }

            if(requestObject.IsSetWidthPixels())
            {
                context.Writer.WritePropertyName("WidthPixels");
                context.Writer.WriteNumberValue(requestObject.WidthPixels.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ImageGenerationConfigurationMarshaller Instance = new ImageGenerationConfigurationMarshaller();

    }
}