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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RevokePermissions Request Marshaller
    /// </summary>       
    public class RevokePermissionsRequestMarshaller : IMarshaller<IRequest, RevokePermissionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RevokePermissionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RevokePermissionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/RevokePermissions";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCatalogId())
                {
                    context.Writer.WritePropertyName("CatalogId");
                    context.Writer.Write(publicRequest.CatalogId);
                }

                if(publicRequest.IsSetCondition())
                {
                    context.Writer.WritePropertyName("Condition");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConditionMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Condition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPermissions())
                {
                    context.Writer.WritePropertyName("Permissions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPermissionsListValue in publicRequest.Permissions)
                    {
                            context.Writer.Write(publicRequestPermissionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPermissionsWithGrantOption())
                {
                    context.Writer.WritePropertyName("PermissionsWithGrantOption");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPermissionsWithGrantOptionListValue in publicRequest.PermissionsWithGrantOption)
                    {
                            context.Writer.Write(publicRequestPermissionsWithGrantOptionListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPrincipal())
                {
                    context.Writer.WritePropertyName("Principal");
                    context.Writer.WriteObjectStart();

                    var marshaller = DataLakePrincipalMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Principal, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetResource())
                {
                    context.Writer.WritePropertyName("Resource");
                    context.Writer.WriteObjectStart();

                    var marshaller = ResourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Resource, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RevokePermissionsRequestMarshaller _instance = new RevokePermissionsRequestMarshaller();        

        internal static RevokePermissionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RevokePermissionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}