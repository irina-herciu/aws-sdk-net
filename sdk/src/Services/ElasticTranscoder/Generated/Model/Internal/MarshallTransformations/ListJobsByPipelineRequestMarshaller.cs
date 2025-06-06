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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticTranscoder.Model;
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
namespace Amazon.ElasticTranscoder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ListJobsByPipeline Request Marshaller
    /// </summary>       
    public class ListJobsByPipelineRequestMarshaller : IMarshaller<IRequest, ListJobsByPipelineRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ListJobsByPipelineRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ListJobsByPipelineRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticTranscoder");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-09-25";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetPipelineId())
                throw new AmazonElasticTranscoderException("Request object does not have required field PipelineId set");
            request.AddPathResource("{PipelineId}", StringUtils.FromString(publicRequest.PipelineId));
            
            if (publicRequest.IsSetAscending())
                request.Parameters.Add("Ascending", StringUtils.FromString(publicRequest.Ascending));
            
            if (publicRequest.IsSetPageToken())
                request.Parameters.Add("PageToken", StringUtils.FromString(publicRequest.PageToken));
            request.ResourcePath = "/2012-09-25/jobsByPipeline/{PipelineId}";
            request.UseQueryString = true;

            return request;
        }
        private static ListJobsByPipelineRequestMarshaller _instance = new ListJobsByPipelineRequestMarshaller();        

        internal static ListJobsByPipelineRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListJobsByPipelineRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}