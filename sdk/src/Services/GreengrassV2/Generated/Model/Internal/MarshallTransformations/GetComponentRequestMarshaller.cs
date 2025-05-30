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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GreengrassV2.Model;
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
namespace Amazon.GreengrassV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetComponent Request Marshaller
    /// </summary>       
    public class GetComponentRequestMarshaller : IMarshaller<IRequest, GetComponentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetComponentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetComponentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.GreengrassV2");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-30";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetArn())
                throw new AmazonGreengrassV2Exception("Request object does not have required field Arn set");
            request.AddPathResource("{arn}", StringUtils.FromString(publicRequest.Arn));
            
            if (publicRequest.IsSetRecipeOutputFormat())
                request.Parameters.Add("recipeOutputFormat", StringUtils.FromString(publicRequest.RecipeOutputFormat));
            request.ResourcePath = "/greengrass/v2/components/{arn}";
            request.UseQueryString = true;

            return request;
        }
        private static GetComponentRequestMarshaller _instance = new GetComponentRequestMarshaller();        

        internal static GetComponentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetComponentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}