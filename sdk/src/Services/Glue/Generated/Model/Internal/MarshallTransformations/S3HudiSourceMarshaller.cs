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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// S3HudiSource Marshaller
    /// </summary>
    public class S3HudiSourceMarshaller : IRequestMarshaller<S3HudiSource, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(S3HudiSource requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalHudiOptions())
            {
                context.Writer.WritePropertyName("AdditionalHudiOptions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAdditionalHudiOptionsKvp in requestObject.AdditionalHudiOptions)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalHudiOptionsKvp.Key);
                    var requestObjectAdditionalHudiOptionsValue = requestObjectAdditionalHudiOptionsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAdditionalHudiOptionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAdditionalOptions())
            {
                context.Writer.WritePropertyName("AdditionalOptions");
                context.Writer.WriteStartObject();

                var marshaller = S3DirectSourceAdditionalOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.AdditionalOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOutputSchemas())
            {
                context.Writer.WritePropertyName("OutputSchemas");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOutputSchemasListValue in requestObject.OutputSchemas)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = GlueSchemaMarshaller.Instance;
                    marshaller.Marshall(requestObjectOutputSchemasListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPaths())
            {
                context.Writer.WritePropertyName("Paths");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPathsListValue in requestObject.Paths)
                {
                        context.Writer.WriteStringValue(requestObjectPathsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static S3HudiSourceMarshaller Instance = new S3HudiSourceMarshaller();

    }
}