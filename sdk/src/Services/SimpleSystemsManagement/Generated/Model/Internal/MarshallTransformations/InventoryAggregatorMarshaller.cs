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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleSystemsManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleSystemsManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InventoryAggregator Marshaller
    /// </summary>
    public class InventoryAggregatorMarshaller : IRequestMarshaller<InventoryAggregator, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InventoryAggregator requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAggregators())
            {
                context.Writer.WritePropertyName("Aggregators");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAggregatorsListValue in requestObject.Aggregators)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InventoryAggregatorMarshaller.Instance;
                    marshaller.Marshall(requestObjectAggregatorsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExpression())
            {
                context.Writer.WritePropertyName("Expression");
                context.Writer.WriteStringValue(requestObject.Expression);
            }

            if(requestObject.IsSetGroups())
            {
                context.Writer.WritePropertyName("Groups");
                context.Writer.WriteStartArray();
                foreach(var requestObjectGroupsListValue in requestObject.Groups)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InventoryGroupMarshaller.Instance;
                    marshaller.Marshall(requestObjectGroupsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InventoryAggregatorMarshaller Instance = new InventoryAggregatorMarshaller();

    }
}