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
 * Do not modify this file. This file is generated from the waf-2015-08-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WAF.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.WAF.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LoggingConfiguration Marshaller
    /// </summary>
    public class LoggingConfigurationMarshaller : IRequestMarshaller<LoggingConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LoggingConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLogDestinationConfigs())
            {
                context.Writer.WritePropertyName("LogDestinationConfigs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLogDestinationConfigsListValue in requestObject.LogDestinationConfigs)
                {
                        context.Writer.WriteStringValue(requestObjectLogDestinationConfigsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRedactedFields())
            {
                context.Writer.WritePropertyName("RedactedFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRedactedFieldsListValue in requestObject.RedactedFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FieldToMatchMarshaller.Instance;
                    marshaller.Marshall(requestObjectRedactedFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetResourceArn())
            {
                context.Writer.WritePropertyName("ResourceArn");
                context.Writer.WriteStringValue(requestObject.ResourceArn);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LoggingConfigurationMarshaller Instance = new LoggingConfigurationMarshaller();

    }
}