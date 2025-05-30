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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618
namespace Amazon.Route53.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListResourceRecordSets operation
    /// </summary>  
    public class ListResourceRecordSetsResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListResourceRecordSetsResponse response = new ListResourceRecordSetsResponse();
            UnmarshallResult(context,response);
            
            return response;
        }        

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListResourceRecordSetsResponse response)
        {
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
                   targetDepth += 1;
            if (context.IsEmptyResponse)
            {
                return;
            }
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ResourceRecordSets/ResourceRecordSet", targetDepth))
                    {
                        if (response.ResourceRecordSets == null)
                        {
                            response.ResourceRecordSets = new List<ResourceRecordSet>();
                        }
                        var unmarshaller = ResourceRecordSetUnmarshaller.Instance;
                        response.ResourceRecordSets.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextRecordName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextRecordName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextRecordType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextRecordType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NextRecordIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.NextRecordIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxItems", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.MaxItems = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
          
            return;
        }
  

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidInput"))
                {
                    return InvalidInputExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchHostedZone"))
                {
                    return NoSuchHostedZoneExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonRoute53Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ListResourceRecordSetsResponseUnmarshaller _instance = new ListResourceRecordSetsResponseUnmarshaller();        

        internal static ListResourceRecordSetsResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ListResourceRecordSetsResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}