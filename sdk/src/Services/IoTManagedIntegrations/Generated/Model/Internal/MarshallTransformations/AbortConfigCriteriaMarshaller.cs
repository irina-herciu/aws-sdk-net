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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AbortConfigCriteria Marshaller
    /// </summary>
    public class AbortConfigCriteriaMarshaller : IRequestMarshaller<AbortConfigCriteria, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AbortConfigCriteria requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAction())
            {
                context.Writer.WritePropertyName("Action");
                context.Writer.WriteStringValue(requestObject.Action);
            }

            if(requestObject.IsSetFailureType())
            {
                context.Writer.WritePropertyName("FailureType");
                context.Writer.WriteStringValue(requestObject.FailureType);
            }

            if(requestObject.IsSetMinNumberOfExecutedThings())
            {
                context.Writer.WritePropertyName("MinNumberOfExecutedThings");
                context.Writer.WriteNumberValue(requestObject.MinNumberOfExecutedThings.Value);
            }

            if(requestObject.IsSetThresholdPercentage())
            {
                context.Writer.WritePropertyName("ThresholdPercentage");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ThresholdPercentage.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ThresholdPercentage.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ThresholdPercentage.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AbortConfigCriteriaMarshaller Instance = new AbortConfigCriteriaMarshaller();

    }
}