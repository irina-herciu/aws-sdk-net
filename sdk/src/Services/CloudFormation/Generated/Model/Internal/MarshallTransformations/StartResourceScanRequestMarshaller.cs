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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartResourceScan Request Marshaller
    /// </summary>       
    public class StartResourceScanRequestMarshaller : IMarshaller<IRequest, StartResourceScanRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartResourceScanRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartResourceScanRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "StartResourceScan");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetClientRequestToken())
                {
                    request.Parameters.Add("ClientRequestToken", StringUtils.FromString(publicRequest.ClientRequestToken));
                }
                if(publicRequest.IsSetScanFilters())
                {
                    if (publicRequest.ScanFilters.Count == 0)
                        request.Parameters.Add("ScanFilters", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.ScanFilters)
                         {
                            if(publicRequestlistValue.IsSetTypes())
                            {
                                if (publicRequestlistValue.Types.Count == 0)
                                    request.Parameters.Add("ScanFilters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Types", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Types)
                                     {
                                         request.Parameters.Add("ScanFilters" + "." + "member" + "." + publicRequestlistValueIndex + "." + "Types" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static StartResourceScanRequestMarshaller _instance = new StartResourceScanRequestMarshaller();        

        internal static StartResourceScanRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartResourceScanRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}