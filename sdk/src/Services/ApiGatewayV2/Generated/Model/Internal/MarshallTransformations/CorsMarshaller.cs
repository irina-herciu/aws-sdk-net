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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Cors Marshaller
    /// </summary>
    public class CorsMarshaller : IRequestMarshaller<Cors, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Cors requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowCredentials())
            {
                context.Writer.WritePropertyName("allowCredentials");
                context.Writer.WriteBooleanValue(requestObject.AllowCredentials.Value);
            }

            if(requestObject.IsSetAllowHeaders())
            {
                context.Writer.WritePropertyName("allowHeaders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowHeadersListValue in requestObject.AllowHeaders)
                {
                        context.Writer.WriteStringValue(requestObjectAllowHeadersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAllowMethods())
            {
                context.Writer.WritePropertyName("allowMethods");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowMethodsListValue in requestObject.AllowMethods)
                {
                        context.Writer.WriteStringValue(requestObjectAllowMethodsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetAllowOrigins())
            {
                context.Writer.WritePropertyName("allowOrigins");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowOriginsListValue in requestObject.AllowOrigins)
                {
                        context.Writer.WriteStringValue(requestObjectAllowOriginsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetExposeHeaders())
            {
                context.Writer.WritePropertyName("exposeHeaders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExposeHeadersListValue in requestObject.ExposeHeaders)
                {
                        context.Writer.WriteStringValue(requestObjectExposeHeadersListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaxAge())
            {
                context.Writer.WritePropertyName("maxAge");
                context.Writer.WriteNumberValue(requestObject.MaxAge.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CorsMarshaller Instance = new CorsMarshaller();

    }
}