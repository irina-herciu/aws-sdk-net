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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GeospatialCategoricalColor Marshaller
    /// </summary>
    public class GeospatialCategoricalColorMarshaller : IRequestMarshaller<GeospatialCategoricalColor, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(GeospatialCategoricalColor requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCategoryDataColors())
            {
                context.Writer.WritePropertyName("CategoryDataColors");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCategoryDataColorsListValue in requestObject.CategoryDataColors)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = GeospatialCategoricalDataColorMarshaller.Instance;
                    marshaller.Marshall(requestObjectCategoryDataColorsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDefaultOpacity())
            {
                context.Writer.WritePropertyName("DefaultOpacity");
                if(StringUtils.IsSpecialDoubleValue(requestObject.DefaultOpacity))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.DefaultOpacity));
                }
                else
                {
                    context.Writer.Write(requestObject.DefaultOpacity);
                }
            }

            if(requestObject.IsSetNullDataSettings())
            {
                context.Writer.WritePropertyName("NullDataSettings");
                context.Writer.WriteObjectStart();

                var marshaller = GeospatialNullDataSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.NullDataSettings, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetNullDataVisibility())
            {
                context.Writer.WritePropertyName("NullDataVisibility");
                context.Writer.Write(requestObject.NullDataVisibility);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static GeospatialCategoricalColorMarshaller Instance = new GeospatialCategoricalColorMarshaller();

    }
}