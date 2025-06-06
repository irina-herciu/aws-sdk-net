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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PI.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PI.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetricQuery Marshaller
    /// </summary>
    public class MetricQueryMarshaller : IRequestMarshaller<MetricQuery, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetricQuery requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFilter())
            {
                context.Writer.WritePropertyName("Filter");
                context.Writer.WriteStartObject();
                foreach (var requestObjectFilterKvp in requestObject.Filter)
                {
                    context.Writer.WritePropertyName(requestObjectFilterKvp.Key);
                    var requestObjectFilterValue = requestObjectFilterKvp.Value;

                        context.Writer.WriteStringValue(requestObjectFilterValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGroupBy())
            {
                context.Writer.WritePropertyName("GroupBy");
                context.Writer.WriteStartObject();

                var marshaller = DimensionGroupMarshaller.Instance;
                marshaller.Marshall(requestObject.GroupBy, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMetric())
            {
                context.Writer.WritePropertyName("Metric");
                context.Writer.WriteStringValue(requestObject.Metric);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetricQueryMarshaller Instance = new MetricQueryMarshaller();

    }
}