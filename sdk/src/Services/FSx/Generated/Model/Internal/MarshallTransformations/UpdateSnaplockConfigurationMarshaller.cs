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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSnaplockConfiguration Marshaller
    /// </summary>
    public class UpdateSnaplockConfigurationMarshaller : IRequestMarshaller<UpdateSnaplockConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(UpdateSnaplockConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAuditLogVolume())
            {
                context.Writer.WritePropertyName("AuditLogVolume");
                context.Writer.WriteBooleanValue(requestObject.AuditLogVolume.Value);
            }

            if(requestObject.IsSetAutocommitPeriod())
            {
                context.Writer.WritePropertyName("AutocommitPeriod");
                context.Writer.WriteStartObject();

                var marshaller = AutocommitPeriodMarshaller.Instance;
                marshaller.Marshall(requestObject.AutocommitPeriod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPrivilegedDelete())
            {
                context.Writer.WritePropertyName("PrivilegedDelete");
                context.Writer.WriteStringValue(requestObject.PrivilegedDelete);
            }

            if(requestObject.IsSetRetentionPeriod())
            {
                context.Writer.WritePropertyName("RetentionPeriod");
                context.Writer.WriteStartObject();

                var marshaller = SnaplockRetentionPeriodMarshaller.Instance;
                marshaller.Marshall(requestObject.RetentionPeriod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVolumeAppendModeEnabled())
            {
                context.Writer.WritePropertyName("VolumeAppendModeEnabled");
                context.Writer.WriteBooleanValue(requestObject.VolumeAppendModeEnabled.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static UpdateSnaplockConfigurationMarshaller Instance = new UpdateSnaplockConfigurationMarshaller();

    }
}