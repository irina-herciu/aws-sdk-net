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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HyperParameterAlgorithmSpecification Marshaller
    /// </summary>
    public class HyperParameterAlgorithmSpecificationMarshaller : IRequestMarshaller<HyperParameterAlgorithmSpecification, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HyperParameterAlgorithmSpecification requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlgorithmName())
            {
                context.Writer.WritePropertyName("AlgorithmName");
                context.Writer.WriteStringValue(requestObject.AlgorithmName);
            }

            if(requestObject.IsSetMetricDefinitions())
            {
                context.Writer.WritePropertyName("MetricDefinitions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMetricDefinitionsListValue in requestObject.MetricDefinitions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MetricDefinitionMarshaller.Instance;
                    marshaller.Marshall(requestObjectMetricDefinitionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTrainingImage())
            {
                context.Writer.WritePropertyName("TrainingImage");
                context.Writer.WriteStringValue(requestObject.TrainingImage);
            }

            if(requestObject.IsSetTrainingInputMode())
            {
                context.Writer.WritePropertyName("TrainingInputMode");
                context.Writer.WriteStringValue(requestObject.TrainingInputMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HyperParameterAlgorithmSpecificationMarshaller Instance = new HyperParameterAlgorithmSpecificationMarshaller();

    }
}