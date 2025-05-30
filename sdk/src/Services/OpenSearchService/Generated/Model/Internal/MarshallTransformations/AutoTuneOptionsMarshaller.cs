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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutoTuneOptions Marshaller
    /// </summary>
    public class AutoTuneOptionsMarshaller : IRequestMarshaller<AutoTuneOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutoTuneOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDesiredState())
            {
                context.Writer.WritePropertyName("DesiredState");
                context.Writer.WriteStringValue(requestObject.DesiredState);
            }

            if(requestObject.IsSetMaintenanceSchedules())
            {
                context.Writer.WritePropertyName("MaintenanceSchedules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMaintenanceSchedulesListValue in requestObject.MaintenanceSchedules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AutoTuneMaintenanceScheduleMarshaller.Instance;
                    marshaller.Marshall(requestObjectMaintenanceSchedulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRollbackOnDisable())
            {
                context.Writer.WritePropertyName("RollbackOnDisable");
                context.Writer.WriteStringValue(requestObject.RollbackOnDisable);
            }

            if(requestObject.IsSetUseOffPeakWindow())
            {
                context.Writer.WritePropertyName("UseOffPeakWindow");
                context.Writer.WriteBooleanValue(requestObject.UseOffPeakWindow.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutoTuneOptionsMarshaller Instance = new AutoTuneOptionsMarshaller();

    }
}