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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
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
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExportAutoScalingGroupRecommendations Request Marshaller
    /// </summary>       
    public class ExportAutoScalingGroupRecommendationsRequestMarshaller : IMarshaller<IRequest, ExportAutoScalingGroupRecommendationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ExportAutoScalingGroupRecommendationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ExportAutoScalingGroupRecommendationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ComputeOptimizer");
            string target = "ComputeOptimizerService.ExportAutoScalingGroupRecommendations";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-11-01";
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
            if(publicRequest.IsSetAccountIds())
            {
                context.Writer.WritePropertyName("accountIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestAccountIdsListValue in publicRequest.AccountIds)
                {
                        context.Writer.WriteStringValue(publicRequestAccountIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFieldsToExport())
            {
                context.Writer.WritePropertyName("fieldsToExport");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFieldsToExportListValue in publicRequest.FieldsToExport)
                {
                        context.Writer.WriteStringValue(publicRequestFieldsToExportListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetFileFormat())
            {
                context.Writer.WritePropertyName("fileFormat");
                context.Writer.WriteStringValue(publicRequest.FileFormat);
            }

            if(publicRequest.IsSetFilters())
            {
                context.Writer.WritePropertyName("filters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFiltersListValue in publicRequest.Filters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = FilterMarshaller.Instance;
                    marshaller.Marshall(publicRequestFiltersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIncludeMemberAccounts())
            {
                context.Writer.WritePropertyName("includeMemberAccounts");
                context.Writer.WriteBooleanValue(publicRequest.IncludeMemberAccounts.Value);
            }

            if(publicRequest.IsSetRecommendationPreferences())
            {
                context.Writer.WritePropertyName("recommendationPreferences");
                context.Writer.WriteStartObject();

                var marshaller = RecommendationPreferencesMarshaller.Instance;
                marshaller.Marshall(publicRequest.RecommendationPreferences, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetS3DestinationConfig())
            {
                context.Writer.WritePropertyName("s3DestinationConfig");
                context.Writer.WriteStartObject();

                var marshaller = S3DestinationConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.S3DestinationConfig, context);

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
        private static ExportAutoScalingGroupRecommendationsRequestMarshaller _instance = new ExportAutoScalingGroupRecommendationsRequestMarshaller();        

        internal static ExportAutoScalingGroupRecommendationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExportAutoScalingGroupRecommendationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}