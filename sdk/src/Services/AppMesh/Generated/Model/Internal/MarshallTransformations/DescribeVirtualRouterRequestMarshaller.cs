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
 * Do not modify this file. This file is generated from the appmesh-2019-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppMesh.Model;
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
namespace Amazon.AppMesh.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeVirtualRouter Request Marshaller
    /// </summary>       
    public class DescribeVirtualRouterRequestMarshaller : IMarshaller<IRequest, DescribeVirtualRouterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeVirtualRouterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeVirtualRouterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppMesh");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-01-25";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetMeshName())
                throw new AmazonAppMeshException("Request object does not have required field MeshName set");
            request.AddPathResource("{meshName}", StringUtils.FromString(publicRequest.MeshName));
            if (!publicRequest.IsSetVirtualRouterName())
                throw new AmazonAppMeshException("Request object does not have required field VirtualRouterName set");
            request.AddPathResource("{virtualRouterName}", StringUtils.FromString(publicRequest.VirtualRouterName));
            
            if (publicRequest.IsSetMeshOwner())
                request.Parameters.Add("meshOwner", StringUtils.FromString(publicRequest.MeshOwner));
            request.ResourcePath = "/v20190125/meshes/{meshName}/virtualRouters/{virtualRouterName}";
            request.UseQueryString = true;

            return request;
        }
        private static DescribeVirtualRouterRequestMarshaller _instance = new DescribeVirtualRouterRequestMarshaller();        

        internal static DescribeVirtualRouterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeVirtualRouterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}