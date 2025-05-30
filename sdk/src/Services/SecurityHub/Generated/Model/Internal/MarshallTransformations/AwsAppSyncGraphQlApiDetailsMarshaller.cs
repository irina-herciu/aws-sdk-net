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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsAppSyncGraphQlApiDetails Marshaller
    /// </summary>
    public class AwsAppSyncGraphQlApiDetailsMarshaller : IRequestMarshaller<AwsAppSyncGraphQlApiDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsAppSyncGraphQlApiDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalAuthenticationProviders())
            {
                context.Writer.WritePropertyName("AdditionalAuthenticationProviders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAdditionalAuthenticationProvidersListValue in requestObject.AdditionalAuthenticationProviders)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsAppSyncGraphQlApiAdditionalAuthenticationProvidersDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectAdditionalAuthenticationProvidersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetApiId())
            {
                context.Writer.WritePropertyName("ApiId");
                context.Writer.WriteStringValue(requestObject.ApiId);
            }

            if(requestObject.IsSetArn())
            {
                context.Writer.WritePropertyName("Arn");
                context.Writer.WriteStringValue(requestObject.Arn);
            }

            if(requestObject.IsSetAuthenticationType())
            {
                context.Writer.WritePropertyName("AuthenticationType");
                context.Writer.WriteStringValue(requestObject.AuthenticationType);
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if(requestObject.IsSetLambdaAuthorizerConfig())
            {
                context.Writer.WritePropertyName("LambdaAuthorizerConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsAppSyncGraphQlApiLambdaAuthorizerConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LambdaAuthorizerConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLogConfig())
            {
                context.Writer.WritePropertyName("LogConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsAppSyncGraphQlApiLogConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.LogConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetOpenIdConnectConfig())
            {
                context.Writer.WritePropertyName("OpenIdConnectConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsAppSyncGraphQlApiOpenIdConnectConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.OpenIdConnectConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUserPoolConfig())
            {
                context.Writer.WritePropertyName("UserPoolConfig");
                context.Writer.WriteStartObject();

                var marshaller = AwsAppSyncGraphQlApiUserPoolConfigDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.UserPoolConfig, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWafWebAclArn())
            {
                context.Writer.WritePropertyName("WafWebAclArn");
                context.Writer.WriteStringValue(requestObject.WafWebAclArn);
            }

            if(requestObject.IsSetXrayEnabled())
            {
                context.Writer.WritePropertyName("XrayEnabled");
                context.Writer.WriteBooleanValue(requestObject.XrayEnabled.Value);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsAppSyncGraphQlApiDetailsMarshaller Instance = new AwsAppSyncGraphQlApiDetailsMarshaller();

    }
}