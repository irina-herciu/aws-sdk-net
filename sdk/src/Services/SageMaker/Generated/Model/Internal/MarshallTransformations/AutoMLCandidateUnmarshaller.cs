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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AutoMLCandidate Object
    /// </summary>  
    public class AutoMLCandidateUnmarshaller : IJsonUnmarshaller<AutoMLCandidate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AutoMLCandidate Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AutoMLCandidate unmarshalledObject = new AutoMLCandidate();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CandidateName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CandidateName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CandidateProperties", targetDepth))
                {
                    var unmarshaller = CandidatePropertiesUnmarshaller.Instance;
                    unmarshalledObject.CandidateProperties = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CandidateStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CandidateStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CandidateSteps", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AutoMLCandidateStep, AutoMLCandidateStepUnmarshaller>(AutoMLCandidateStepUnmarshaller.Instance);
                    unmarshalledObject.CandidateSteps = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EndTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FailureReason", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FinalAutoMLJobObjectiveMetric", targetDepth))
                {
                    var unmarshaller = FinalAutoMLJobObjectiveMetricUnmarshaller.Instance;
                    unmarshalledObject.FinalAutoMLJobObjectiveMetric = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InferenceContainerDefinitions", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, List<AutoMLContainerDefinition>, StringUnmarshaller, JsonListUnmarshaller<AutoMLContainerDefinition,AutoMLContainerDefinitionUnmarshaller>>(StringUnmarshaller.Instance, new JsonListUnmarshaller<AutoMLContainerDefinition, AutoMLContainerDefinitionUnmarshaller>(AutoMLContainerDefinitionUnmarshaller.Instance));
                    unmarshalledObject.InferenceContainerDefinitions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InferenceContainers", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AutoMLContainerDefinition, AutoMLContainerDefinitionUnmarshaller>(AutoMLContainerDefinitionUnmarshaller.Instance);
                    unmarshalledObject.InferenceContainers = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("LastModifiedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ObjectiveStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObjectiveStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AutoMLCandidateUnmarshaller _instance = new AutoMLCandidateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutoMLCandidateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}