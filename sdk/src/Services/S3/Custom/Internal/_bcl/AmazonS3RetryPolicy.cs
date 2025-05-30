﻿/*
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Net;
using Amazon.S3.Util;
using System.Globalization;
using Amazon.Runtime.Internal.Util;
using Amazon.Util;

#pragma warning disable 1591

namespace Amazon.S3.Internal
{
    public partial class AmazonS3RetryPolicy : DefaultRetryPolicy
    {
        /// <summary>
        /// Return true if the request should be retried. Implements additional checks 
        /// specific to S3 on top of the checks in DefaultRetryPolicy.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public override bool RetryForException(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return SharedRetryForException(executionContext, exception, RetryForExceptionSync, base.RetryForException);
        }

        internal static bool SharedRetryForException(Runtime.IExecutionContext executionContext, Exception exception,            
            Func<Runtime.IExecutionContext, Exception, bool?> retryForExceptionSync,
            Func<Runtime.IExecutionContext, Exception, bool> baseRetryForException)
        {
            var syncResult = retryForExceptionSync(executionContext, exception);
            if (syncResult.HasValue)
            {
                return syncResult.Value;
            }
            else
            {
                var serviceException = exception as AmazonServiceException;
                string correctedRegion = null;
                AmazonS3Uri s3BucketUri;
                if (AmazonS3Uri.TryParseAmazonS3Uri(executionContext.RequestContext.Request.Endpoint, out s3BucketUri))
                {
                    if (executionContext.RequestContext.Identity is AWSCredentials && !(executionContext.RequestContext.Identity is AnonymousAWSCredentials))
                    {
                        correctedRegion = BucketRegionDetector.DetectMismatchWithHeadBucketFallback(s3BucketUri, serviceException, executionContext.RequestContext);
                    }
                }

                if (correctedRegion == null)
                {
                    return baseRetryForException(executionContext, exception);
                }
                else
                {
                    // change authentication region of request and signal the handler to sign again with the new region
                    executionContext.RequestContext.Request.AuthenticationRegion = correctedRegion;
                    executionContext.RequestContext.IsSigned = false;
                    return true;
                }
            }
        }
    }


    public partial class AmazonS3StandardRetryPolicy : StandardRetryPolicy
    {
        /// <summary>
        /// Return true if the request should be retried. Implements additional checks 
        /// specific to S3 on top of the checks in StandardRetryPolicy.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public override bool RetryForException(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return AmazonS3RetryPolicy.SharedRetryForException(executionContext, exception, RetryForExceptionSync, base.RetryForException);
        }
    }


    public partial class AmazonS3AdaptiveRetryPolicy : AdaptiveRetryPolicy
    {
        /// <summary>
        /// Return true if the request should be retried. Implements additional checks 
        /// specific to S3 on top of the checks in AdaptiveRetryPolicy.
        /// </summary>
        /// <param name="executionContext">Request context containing the state of the request.</param>
        /// <param name="exception">The exception thrown by the previous request.</param>
        /// <returns>Return true if the request should be retried.</returns>
        public override bool RetryForException(Runtime.IExecutionContext executionContext, Exception exception)
        {
            return AmazonS3RetryPolicy.SharedRetryForException(executionContext, exception, RetryForExceptionSync, base.RetryForException);            
        }
    }
}
