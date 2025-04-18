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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DocDBElastic.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DocDBElastic.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ApplyPendingMaintenanceAction Request Marshaller
    /// </summary>       
    public class ApplyPendingMaintenanceActionRequestMarshaller : IMarshaller<IRequest, ApplyPendingMaintenanceActionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ApplyPendingMaintenanceActionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ApplyPendingMaintenanceActionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DocDBElastic");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "POST";

            request.ResourcePath = "/pending-action";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApplyAction())
                {
                    context.Writer.WritePropertyName("applyAction");
                    context.Writer.Write(publicRequest.ApplyAction);
                }

                if(publicRequest.IsSetApplyOn())
                {
                    context.Writer.WritePropertyName("applyOn");
                    context.Writer.Write(publicRequest.ApplyOn);
                }

                if(publicRequest.IsSetOptInType())
                {
                    context.Writer.WritePropertyName("optInType");
                    context.Writer.Write(publicRequest.OptInType);
                }

                if(publicRequest.IsSetResourceArn())
                {
                    context.Writer.WritePropertyName("resourceArn");
                    context.Writer.Write(publicRequest.ResourceArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ApplyPendingMaintenanceActionRequestMarshaller _instance = new ApplyPendingMaintenanceActionRequestMarshaller();        

        internal static ApplyPendingMaintenanceActionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplyPendingMaintenanceActionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}