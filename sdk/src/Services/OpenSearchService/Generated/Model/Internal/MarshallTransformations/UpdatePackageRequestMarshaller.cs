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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePackage Request Marshaller
    /// </summary>       
    public class UpdatePackageRequestMarshaller : IMarshaller<IRequest, UpdatePackageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePackageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePackageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpenSearchService");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/2021-01-01/packages/update";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCommitMessage())
                {
                    context.Writer.WritePropertyName("CommitMessage");
                    context.Writer.Write(publicRequest.CommitMessage);
                }

                if(publicRequest.IsSetPackageConfiguration())
                {
                    context.Writer.WritePropertyName("PackageConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = PackageConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PackageConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPackageDescription())
                {
                    context.Writer.WritePropertyName("PackageDescription");
                    context.Writer.Write(publicRequest.PackageDescription);
                }

                if(publicRequest.IsSetPackageEncryptionOptions())
                {
                    context.Writer.WritePropertyName("PackageEncryptionOptions");
                    context.Writer.WriteObjectStart();

                    var marshaller = PackageEncryptionOptionsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PackageEncryptionOptions, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPackageID())
                {
                    context.Writer.WritePropertyName("PackageID");
                    context.Writer.Write(publicRequest.PackageID);
                }

                if(publicRequest.IsSetPackageSource())
                {
                    context.Writer.WritePropertyName("PackageSource");
                    context.Writer.WriteObjectStart();

                    var marshaller = PackageSourceMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PackageSource, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdatePackageRequestMarshaller _instance = new UpdatePackageRequestMarshaller();        

        internal static UpdatePackageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePackageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}