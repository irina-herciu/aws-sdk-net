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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreTestingPlanForCreate Marshaller
    /// </summary>
    public class RestoreTestingPlanForCreateMarshaller : IRequestMarshaller<RestoreTestingPlanForCreate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(RestoreTestingPlanForCreate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetRecoveryPointSelection())
            {
                context.Writer.WritePropertyName("RecoveryPointSelection");
                context.Writer.WriteStartObject();

                var marshaller = RestoreTestingRecoveryPointSelectionMarshaller.Instance;
                marshaller.Marshall(requestObject.RecoveryPointSelection, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRestoreTestingPlanName())
            {
                context.Writer.WritePropertyName("RestoreTestingPlanName");
                context.Writer.WriteStringValue(requestObject.RestoreTestingPlanName);
            }

            if(requestObject.IsSetScheduleExpression())
            {
                context.Writer.WritePropertyName("ScheduleExpression");
                context.Writer.WriteStringValue(requestObject.ScheduleExpression);
            }

            if(requestObject.IsSetScheduleExpressionTimezone())
            {
                context.Writer.WritePropertyName("ScheduleExpressionTimezone");
                context.Writer.WriteStringValue(requestObject.ScheduleExpressionTimezone);
            }

            if(requestObject.IsSetStartWindowHours())
            {
                context.Writer.WritePropertyName("StartWindowHours");
                context.Writer.WriteNumberValue(requestObject.StartWindowHours.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RestoreTestingPlanForCreateMarshaller Instance = new RestoreTestingPlanForCreateMarshaller();

    }
}