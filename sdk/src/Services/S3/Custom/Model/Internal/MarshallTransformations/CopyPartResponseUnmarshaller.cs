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
using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Amazon.S3.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for CopyPart operation
    /// </summary>
    public class CopyPartResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            CopyPartResponse response = new CopyPartResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    UnmarshallResult(context,response);                        
                    continue;
                }
            }
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,CopyPartResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ChecksumCRC32", targetDepth))
                    {
                        response.ChecksumCRC32 = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumCRC32C", targetDepth))
                    {
                        response.ChecksumCRC32C = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumCRC64NVME", targetDepth))
                    {
                        response.ChecksumCRC64NVME = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumSHA1", targetDepth))
                    {
                        response.ChecksumSHA1 = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChecksumSHA256", targetDepth))
                    {
                        response.ChecksumSHA256 = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ETag", targetDepth))
                    {
                        response.ETag = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("LastModified", targetDepth))
                    {
                        response.LastModified = DateTimeUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }                    
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
                

            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent("x-amz-copy-source-version-id"))
                response.CopySourceVersionId = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-copy-source-version-id"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryptionMethod = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption"));
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader))
                response.ServerSideEncryptionKeyManagementServiceKeyId = S3Transforms.ToString(responseData.GetHeaderValue(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader));
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderBucketKeyEnabled))
                response.BucketKeyEnabled = S3Transforms.ToBool(responseData.GetHeaderValue(S3Constants.AmzHeaderBucketKeyEnabled));

            return;
        }

        private static CopyPartResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static CopyPartResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CopyPartResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
