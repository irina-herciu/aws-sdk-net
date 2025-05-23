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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
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
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteEmailIdentityPolicy Request Marshaller
    /// </summary>       
    public class DeleteEmailIdentityPolicyRequestMarshaller : IMarshaller<IRequest, DeleteEmailIdentityPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteEmailIdentityPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteEmailIdentityPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SimpleEmailV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-09-27";
            request.HttpMethod = "DELETE";

            if (!publicRequest.IsSetEmailIdentity())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field EmailIdentity set");
            request.AddPathResource("{EmailIdentity}", StringUtils.FromString(publicRequest.EmailIdentity));
            if (!publicRequest.IsSetPolicyName())
                throw new AmazonSimpleEmailServiceV2Exception("Request object does not have required field PolicyName set");
            request.AddPathResource("{PolicyName}", StringUtils.FromString(publicRequest.PolicyName));
            request.ResourcePath = "/v2/email/identities/{EmailIdentity}/policies/{PolicyName}";

            return request;
        }
        private static DeleteEmailIdentityPolicyRequestMarshaller _instance = new DeleteEmailIdentityPolicyRequestMarshaller();        

        internal static DeleteEmailIdentityPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteEmailIdentityPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}