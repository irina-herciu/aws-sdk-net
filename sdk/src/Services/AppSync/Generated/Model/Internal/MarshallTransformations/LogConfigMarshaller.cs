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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LogConfig Marshaller
    /// </summary>
    public class LogConfigMarshaller : IRequestMarshaller<LogConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LogConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchLogsRoleArn())
            {
                context.Writer.WritePropertyName("cloudWatchLogsRoleArn");
                context.Writer.WriteStringValue(requestObject.CloudWatchLogsRoleArn);
            }

            if(requestObject.IsSetExcludeVerboseContent())
            {
                context.Writer.WritePropertyName("excludeVerboseContent");
                context.Writer.WriteBooleanValue(requestObject.ExcludeVerboseContent.Value);
            }

            if(requestObject.IsSetFieldLogLevel())
            {
                context.Writer.WritePropertyName("fieldLogLevel");
                context.Writer.WriteStringValue(requestObject.FieldLogLevel);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static LogConfigMarshaller Instance = new LogConfigMarshaller();

    }
}