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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridge.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridge.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateConnectionAuthRequestParameters Marshaller
    /// </summary>
    public class CreateConnectionAuthRequestParametersMarshaller : IRequestMarshaller<CreateConnectionAuthRequestParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateConnectionAuthRequestParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetApiKeyAuthParameters())
            {
                context.Writer.WritePropertyName("ApiKeyAuthParameters");
                context.Writer.WriteStartObject();

                var marshaller = CreateConnectionApiKeyAuthRequestParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ApiKeyAuthParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBasicAuthParameters())
            {
                context.Writer.WritePropertyName("BasicAuthParameters");
                context.Writer.WriteStartObject();

                var marshaller = CreateConnectionBasicAuthRequestParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.BasicAuthParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConnectivityParameters())
            {
                context.Writer.WritePropertyName("ConnectivityParameters");
                context.Writer.WriteStartObject();

                var marshaller = ConnectivityResourceParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.ConnectivityParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInvocationHttpParameters())
            {
                context.Writer.WritePropertyName("InvocationHttpParameters");
                context.Writer.WriteStartObject();

                var marshaller = ConnectionHttpParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.InvocationHttpParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOAuthParameters())
            {
                context.Writer.WritePropertyName("OAuthParameters");
                context.Writer.WriteStartObject();

                var marshaller = CreateConnectionOAuthRequestParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.OAuthParameters, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateConnectionAuthRequestParametersMarshaller Instance = new CreateConnectionAuthRequestParametersMarshaller();

    }
}