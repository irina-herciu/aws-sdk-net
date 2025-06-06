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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
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
namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetServiceNetworkVpcAssociation Request Marshaller
    /// </summary>       
    public class GetServiceNetworkVpcAssociationRequestMarshaller : IMarshaller<IRequest, GetServiceNetworkVpcAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetServiceNetworkVpcAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetServiceNetworkVpcAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.VPCLattice");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-30";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetServiceNetworkVpcAssociationIdentifier())
                throw new AmazonVPCLatticeException("Request object does not have required field ServiceNetworkVpcAssociationIdentifier set");
            request.AddPathResource("{serviceNetworkVpcAssociationIdentifier}", StringUtils.FromString(publicRequest.ServiceNetworkVpcAssociationIdentifier));
            request.ResourcePath = "/servicenetworkvpcassociations/{serviceNetworkVpcAssociationIdentifier}";

            return request;
        }
        private static GetServiceNetworkVpcAssociationRequestMarshaller _instance = new GetServiceNetworkVpcAssociationRequestMarshaller();        

        internal static GetServiceNetworkVpcAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetServiceNetworkVpcAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}