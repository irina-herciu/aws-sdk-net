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
 * Do not modify this file. This file is generated from the ssm-incidents-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SSMIncidents.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SSMIncidents.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PagerDutyConfiguration Marshaller
    /// </summary>
    public class PagerDutyConfigurationMarshaller : IRequestMarshaller<PagerDutyConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PagerDutyConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPagerDutyIncidentConfiguration())
            {
                context.Writer.WritePropertyName("pagerDutyIncidentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = PagerDutyIncidentConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.PagerDutyIncidentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSecretId())
            {
                context.Writer.WritePropertyName("secretId");
                context.Writer.WriteStringValue(requestObject.SecretId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PagerDutyConfigurationMarshaller Instance = new PagerDutyConfigurationMarshaller();

    }
}