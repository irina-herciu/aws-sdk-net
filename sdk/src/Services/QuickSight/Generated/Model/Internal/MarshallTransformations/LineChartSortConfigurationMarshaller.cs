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
    /// LineChartSortConfiguration Marshaller
    /// </summary>
    public class LineChartSortConfigurationMarshaller : IRequestMarshaller<LineChartSortConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LineChartSortConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCategoryItemsLimitConfiguration())
            {
                context.Writer.WritePropertyName("CategoryItemsLimitConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ItemsLimitConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CategoryItemsLimitConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCategorySort())
            {
                context.Writer.WritePropertyName("CategorySort");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCategorySortListValue in requestObject.CategorySort)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldSortOptionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCategorySortListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetColorItemsLimitConfiguration())
            {
                context.Writer.WritePropertyName("ColorItemsLimitConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ItemsLimitConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ColorItemsLimitConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSmallMultiplesLimitConfiguration())
            {
                context.Writer.WritePropertyName("SmallMultiplesLimitConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ItemsLimitConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SmallMultiplesLimitConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSmallMultiplesSort())
            {
                context.Writer.WritePropertyName("SmallMultiplesSort");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSmallMultiplesSortListValue in requestObject.SmallMultiplesSort)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldSortOptionsMarshaller.Instance;
                    marshaller.Marshall(requestObjectSmallMultiplesSortListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LineChartSortConfigurationMarshaller Instance = new LineChartSortConfigurationMarshaller();

    }
}