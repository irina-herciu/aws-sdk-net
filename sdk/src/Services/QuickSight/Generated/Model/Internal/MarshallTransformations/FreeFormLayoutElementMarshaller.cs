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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FreeFormLayoutElement Marshaller
    /// </summary>
    public class FreeFormLayoutElementMarshaller : IRequestMarshaller<FreeFormLayoutElement, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FreeFormLayoutElement requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBackgroundStyle())
            {
                context.Writer.WritePropertyName("BackgroundStyle");
                context.Writer.WriteStartObject();

                var marshaller = FreeFormLayoutElementBackgroundStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.BackgroundStyle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBorderStyle())
            {
                context.Writer.WritePropertyName("BorderStyle");
                context.Writer.WriteStartObject();

                var marshaller = FreeFormLayoutElementBorderStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.BorderStyle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetElementId())
            {
                context.Writer.WritePropertyName("ElementId");
                context.Writer.WriteStringValue(requestObject.ElementId);
            }

            if(requestObject.IsSetElementType())
            {
                context.Writer.WritePropertyName("ElementType");
                context.Writer.WriteStringValue(requestObject.ElementType);
            }

            if(requestObject.IsSetHeight())
            {
                context.Writer.WritePropertyName("Height");
                context.Writer.WriteStringValue(requestObject.Height);
            }

            if(requestObject.IsSetLoadingAnimation())
            {
                context.Writer.WritePropertyName("LoadingAnimation");
                context.Writer.WriteStartObject();

                var marshaller = LoadingAnimationMarshaller.Instance;
                marshaller.Marshall(requestObject.LoadingAnimation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRenderingRules())
            {
                context.Writer.WritePropertyName("RenderingRules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRenderingRulesListValue in requestObject.RenderingRules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SheetElementRenderingRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectRenderingRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSelectedBorderStyle())
            {
                context.Writer.WritePropertyName("SelectedBorderStyle");
                context.Writer.WriteStartObject();

                var marshaller = FreeFormLayoutElementBorderStyleMarshaller.Instance;
                marshaller.Marshall(requestObject.SelectedBorderStyle, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVisibility())
            {
                context.Writer.WritePropertyName("Visibility");
                context.Writer.WriteStringValue(requestObject.Visibility);
            }

            if(requestObject.IsSetWidth())
            {
                context.Writer.WritePropertyName("Width");
                context.Writer.WriteStringValue(requestObject.Width);
            }

            if(requestObject.IsSetXAxisLocation())
            {
                context.Writer.WritePropertyName("XAxisLocation");
                context.Writer.WriteStringValue(requestObject.XAxisLocation);
            }

            if(requestObject.IsSetYAxisLocation())
            {
                context.Writer.WritePropertyName("YAxisLocation");
                context.Writer.WriteStringValue(requestObject.YAxisLocation);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FreeFormLayoutElementMarshaller Instance = new FreeFormLayoutElementMarshaller();

    }
}