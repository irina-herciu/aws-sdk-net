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

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.S3.Util;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Head Bucket Request Marshaller
    /// </summary>       
    public class HeadBucketRequestMarshaller : IMarshaller<IRequest, HeadBucketRequest>, IMarshaller<IRequest, Amazon.Runtime.AmazonWebServiceRequest>
    {
        public IRequest Marshall(Amazon.Runtime.AmazonWebServiceRequest input)
        {
            return this.Marshall((HeadBucketRequest)input);
        }

        public IRequest Marshall(HeadBucketRequest headBucketRequest)
        {
            IRequest request = new DefaultRequest(headBucketRequest, "AmazonS3");

            request.HttpMethod = "HEAD";

            if (headBucketRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(headBucketRequest.ExpectedBucketOwner));

            if (string.IsNullOrEmpty(headBucketRequest.BucketName))
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "HeadBucketRequest.BucketName");

            request.ResourcePath = "/";
            request.UseQueryString = true;
            
            return request;
        }

        private static HeadBucketRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static HeadBucketRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new HeadBucketRequestMarshaller();
                }
                return _instance;
            }
        }
    }
}
    
