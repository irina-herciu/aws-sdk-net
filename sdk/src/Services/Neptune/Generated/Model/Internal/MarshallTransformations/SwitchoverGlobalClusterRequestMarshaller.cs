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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptune.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SwitchoverGlobalCluster Request Marshaller
    /// </summary>       
    public class SwitchoverGlobalClusterRequestMarshaller : IMarshaller<IRequest, SwitchoverGlobalClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((SwitchoverGlobalClusterRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(SwitchoverGlobalClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Neptune");
            request.Parameters.Add("Action", "SwitchoverGlobalCluster");
            request.Parameters.Add("Version", "2014-10-31");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetGlobalClusterIdentifier())
                {
                    request.Parameters.Add("GlobalClusterIdentifier", StringUtils.FromString(publicRequest.GlobalClusterIdentifier));
                }
                if(publicRequest.IsSetTargetDbClusterIdentifier())
                {
                    request.Parameters.Add("TargetDbClusterIdentifier", StringUtils.FromString(publicRequest.TargetDbClusterIdentifier));
                }
            }
            return request;
        }
                    private static SwitchoverGlobalClusterRequestMarshaller _instance = new SwitchoverGlobalClusterRequestMarshaller();        

        internal static SwitchoverGlobalClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SwitchoverGlobalClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}