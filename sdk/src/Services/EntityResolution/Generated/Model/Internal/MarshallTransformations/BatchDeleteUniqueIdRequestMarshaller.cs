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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EntityResolution.Model;
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
namespace Amazon.EntityResolution.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchDeleteUniqueId Request Marshaller
    /// </summary>       
    public class BatchDeleteUniqueIdRequestMarshaller : IMarshaller<IRequest, BatchDeleteUniqueIdRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDeleteUniqueIdRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchDeleteUniqueIdRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.EntityResolution");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetWorkflowName())
                throw new AmazonEntityResolutionException("Request object does not have required field WorkflowName set");
            request.AddPathResource("{workflowName}", StringUtils.FromString(publicRequest.WorkflowName));
            request.ResourcePath = "/matchingworkflows/{workflowName}/uniqueids";
        
            if (publicRequest.IsSetInputSource()) 
            {
                request.Headers["inputSource"] = publicRequest.InputSource;
            }
        
            if (publicRequest.IsSetUniqueIds()) 
            {
                        request.Headers["uniqueIds"] = StringUtils.FromList(publicRequest.UniqueIds);
            }

            return request;
        }
        private static BatchDeleteUniqueIdRequestMarshaller _instance = new BatchDeleteUniqueIdRequestMarshaller();        

        internal static BatchDeleteUniqueIdRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchDeleteUniqueIdRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}