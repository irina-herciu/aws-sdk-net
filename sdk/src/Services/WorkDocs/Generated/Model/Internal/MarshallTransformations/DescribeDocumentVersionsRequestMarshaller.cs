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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkDocs.Model;
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
namespace Amazon.WorkDocs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeDocumentVersions Request Marshaller
    /// </summary>       
    public class DescribeDocumentVersionsRequestMarshaller : IMarshaller<IRequest, DescribeDocumentVersionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeDocumentVersionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeDocumentVersionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkDocs");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-05-01";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetDocumentId())
                throw new AmazonWorkDocsException("Request object does not have required field DocumentId set");
            request.AddPathResource("{DocumentId}", StringUtils.FromString(publicRequest.DocumentId));
            
            if (publicRequest.IsSetFields())
                request.Parameters.Add("fields", StringUtils.FromString(publicRequest.Fields));
            
            if (publicRequest.IsSetInclude())
                request.Parameters.Add("include", StringUtils.FromString(publicRequest.Include));
            
            if (publicRequest.IsSetLimit())
                request.Parameters.Add("limit", StringUtils.FromInt(publicRequest.Limit));
            
            if (publicRequest.IsSetMarker())
                request.Parameters.Add("marker", StringUtils.FromString(publicRequest.Marker));
            request.ResourcePath = "/api/v1/documents/{DocumentId}/versions";
        
            if (publicRequest.IsSetAuthenticationToken()) 
            {
                request.Headers["Authentication"] = publicRequest.AuthenticationToken;
            }
            request.UseQueryString = true;

            return request;
        }
        private static DescribeDocumentVersionsRequestMarshaller _instance = new DescribeDocumentVersionsRequestMarshaller();        

        internal static DescribeDocumentVersionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeDocumentVersionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}