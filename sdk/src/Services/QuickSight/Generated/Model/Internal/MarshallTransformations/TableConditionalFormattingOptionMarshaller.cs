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
    /// TableConditionalFormattingOption Marshaller
    /// </summary>
    public class TableConditionalFormattingOptionMarshaller : IRequestMarshaller<TableConditionalFormattingOption, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TableConditionalFormattingOption requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCell())
            {
                context.Writer.WritePropertyName("Cell");
                context.Writer.WriteStartObject();

                var marshaller = TableCellConditionalFormattingMarshaller.Instance;
                marshaller.Marshall(requestObject.Cell, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRow())
            {
                context.Writer.WritePropertyName("Row");
                context.Writer.WriteStartObject();

                var marshaller = TableRowConditionalFormattingMarshaller.Instance;
                marshaller.Marshall(requestObject.Row, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TableConditionalFormattingOptionMarshaller Instance = new TableConditionalFormattingOptionMarshaller();

    }
}