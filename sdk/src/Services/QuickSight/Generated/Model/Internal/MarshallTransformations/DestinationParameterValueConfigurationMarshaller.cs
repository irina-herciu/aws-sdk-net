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
    /// DestinationParameterValueConfiguration Marshaller
    /// </summary>
    public class DestinationParameterValueConfigurationMarshaller : IRequestMarshaller<DestinationParameterValueConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DestinationParameterValueConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCustomValuesConfiguration())
            {
                context.Writer.WritePropertyName("CustomValuesConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = CustomValuesConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomValuesConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSelectAllValueOptions())
            {
                context.Writer.WritePropertyName("SelectAllValueOptions");
                context.Writer.WriteStringValue(requestObject.SelectAllValueOptions);
            }

            if(requestObject.IsSetSourceColumn())
            {
                context.Writer.WritePropertyName("SourceColumn");
                context.Writer.WriteStartObject();

                var marshaller = ColumnIdentifierMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceColumn, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSourceField())
            {
                context.Writer.WritePropertyName("SourceField");
                context.Writer.WriteStringValue(requestObject.SourceField);
            }

            if(requestObject.IsSetSourceParameterName())
            {
                context.Writer.WritePropertyName("SourceParameterName");
                context.Writer.WriteStringValue(requestObject.SourceParameterName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DestinationParameterValueConfigurationMarshaller Instance = new DestinationParameterValueConfigurationMarshaller();

    }
}