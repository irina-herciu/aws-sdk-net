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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AuthorizeEndpointAccess Request Marshaller
    /// </summary>       
    public class AuthorizeEndpointAccessRequestMarshaller : IMarshaller<IRequest, AuthorizeEndpointAccessRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AuthorizeEndpointAccessRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AuthorizeEndpointAccessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Redshift");
            request.Parameters.Add("Action", "AuthorizeEndpointAccess");
            request.Parameters.Add("Version", "2012-12-01");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAccount())
                {
                    request.Parameters.Add("Account", StringUtils.FromString(publicRequest.Account));
                }
                if(publicRequest.IsSetClusterIdentifier())
                {
                    request.Parameters.Add("ClusterIdentifier", StringUtils.FromString(publicRequest.ClusterIdentifier));
                }
                if(publicRequest.IsSetVpcIds())
                {
                    if (publicRequest.VpcIds.Count == 0)
                        request.Parameters.Add("VpcIds", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.VpcIds)
                         {
                             request.Parameters.Add("VpcIds" + "." + "VpcIdentifier" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static AuthorizeEndpointAccessRequestMarshaller _instance = new AuthorizeEndpointAccessRequestMarshaller();        

        internal static AuthorizeEndpointAccessRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthorizeEndpointAccessRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}