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
 * Do not modify this file. This file is generated from the comprehendmedical-2018-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComprehendMedical.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.ComprehendMedical.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartSNOMEDCTInferenceJob Request Marshaller
    /// </summary>       
    public class StartSNOMEDCTInferenceJobRequestMarshaller : IMarshaller<IRequest, StartSNOMEDCTInferenceJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartSNOMEDCTInferenceJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartSNOMEDCTInferenceJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComprehendMedical");
            string target = "ComprehendMedical_20181030.StartSNOMEDCTInferenceJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-10-30";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetClientRequestToken())
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(publicRequest.ClientRequestToken);
            }

            else if(!(publicRequest.IsSetClientRequestToken()))
            {
                context.Writer.WritePropertyName("ClientRequestToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetDataAccessRoleArn())
            {
                context.Writer.WritePropertyName("DataAccessRoleArn");
                context.Writer.WriteStringValue(publicRequest.DataAccessRoleArn);
            }

            if(publicRequest.IsSetInputDataConfig())
            {
                context.Writer.WritePropertyName("InputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = InputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.InputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetJobName())
            {
                context.Writer.WritePropertyName("JobName");
                context.Writer.WriteStringValue(publicRequest.JobName);
            }

            if(publicRequest.IsSetKMSKey())
            {
                context.Writer.WritePropertyName("KMSKey");
                context.Writer.WriteStringValue(publicRequest.KMSKey);
            }

            if(publicRequest.IsSetLanguageCode())
            {
                context.Writer.WritePropertyName("LanguageCode");
                context.Writer.WriteStringValue(publicRequest.LanguageCode);
            }

            if(publicRequest.IsSetOutputDataConfig())
            {
                context.Writer.WritePropertyName("OutputDataConfig");
                context.Writer.WriteStartObject();

                var marshaller = OutputDataConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutputDataConfig, context);

                context.Writer.WriteEndObject();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static StartSNOMEDCTInferenceJobRequestMarshaller _instance = new StartSNOMEDCTInferenceJobRequestMarshaller();        

        internal static StartSNOMEDCTInferenceJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartSNOMEDCTInferenceJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}