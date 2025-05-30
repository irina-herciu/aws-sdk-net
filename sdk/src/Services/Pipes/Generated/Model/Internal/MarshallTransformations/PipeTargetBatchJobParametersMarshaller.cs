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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PipeTargetBatchJobParameters Marshaller
    /// </summary>
    public class PipeTargetBatchJobParametersMarshaller : IRequestMarshaller<PipeTargetBatchJobParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PipeTargetBatchJobParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetArrayProperties())
            {
                context.Writer.WritePropertyName("ArrayProperties");
                context.Writer.WriteStartObject();

                var marshaller = BatchArrayPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.ArrayProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContainerOverrides())
            {
                context.Writer.WritePropertyName("ContainerOverrides");
                context.Writer.WriteStartObject();

                var marshaller = BatchContainerOverridesMarshaller.Instance;
                marshaller.Marshall(requestObject.ContainerOverrides, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDependsOn())
            {
                context.Writer.WritePropertyName("DependsOn");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDependsOnListValue in requestObject.DependsOn)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = BatchJobDependencyMarshaller.Instance;
                    marshaller.Marshall(requestObjectDependsOnListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetJobDefinition())
            {
                context.Writer.WritePropertyName("JobDefinition");
                context.Writer.WriteStringValue(requestObject.JobDefinition);
            }

            if(requestObject.IsSetJobName())
            {
                context.Writer.WritePropertyName("JobName");
                context.Writer.WriteStringValue(requestObject.JobName);
            }

            if(requestObject.IsSetParameters())
            {
                context.Writer.WritePropertyName("Parameters");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParametersKvp in requestObject.Parameters)
                {
                    context.Writer.WritePropertyName(requestObjectParametersKvp.Key);
                    var requestObjectParametersValue = requestObjectParametersKvp.Value;

                        context.Writer.WriteStringValue(requestObjectParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRetryStrategy())
            {
                context.Writer.WritePropertyName("RetryStrategy");
                context.Writer.WriteStartObject();

                var marshaller = BatchRetryStrategyMarshaller.Instance;
                marshaller.Marshall(requestObject.RetryStrategy, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PipeTargetBatchJobParametersMarshaller Instance = new PipeTargetBatchJobParametersMarshaller();

    }
}