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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EMRContainers.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EMRContainers.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// JobDriver Marshaller
    /// </summary>
    public class JobDriverMarshaller : IRequestMarshaller<JobDriver, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(JobDriver requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetSparkSqlJobDriver())
            {
                context.Writer.WritePropertyName("sparkSqlJobDriver");
                context.Writer.WriteStartObject();

                var marshaller = SparkSqlJobDriverMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkSqlJobDriver, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSparkSubmitJobDriver())
            {
                context.Writer.WritePropertyName("sparkSubmitJobDriver");
                context.Writer.WriteStartObject();

                var marshaller = SparkSubmitJobDriverMarshaller.Instance;
                marshaller.Marshall(requestObject.SparkSubmitJobDriver, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static JobDriverMarshaller Instance = new JobDriverMarshaller();

    }
}