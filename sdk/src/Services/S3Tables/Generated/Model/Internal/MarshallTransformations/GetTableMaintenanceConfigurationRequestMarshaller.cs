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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Tables.Model;
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
namespace Amazon.S3Tables.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTableMaintenanceConfiguration Request Marshaller
    /// </summary>       
    public class GetTableMaintenanceConfigurationRequestMarshaller : IMarshaller<IRequest, GetTableMaintenanceConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTableMaintenanceConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTableMaintenanceConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Tables");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetName())
                throw new AmazonS3TablesException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            if (!publicRequest.IsSetNamespace())
                throw new AmazonS3TablesException("Request object does not have required field Namespace set");
            request.AddPathResource("{namespace}", StringUtils.FromString(publicRequest.Namespace));
            if (!publicRequest.IsSetTableBucketARN())
                throw new AmazonS3TablesException("Request object does not have required field TableBucketARN set");
            request.AddPathResource("{tableBucketARN}", StringUtils.FromString(publicRequest.TableBucketARN));
            request.ResourcePath = "/tables/{tableBucketARN}/{namespace}/{name}/maintenance";

            return request;
        }
        private static GetTableMaintenanceConfigurationRequestMarshaller _instance = new GetTableMaintenanceConfigurationRequestMarshaller();        

        internal static GetTableMaintenanceConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTableMaintenanceConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}