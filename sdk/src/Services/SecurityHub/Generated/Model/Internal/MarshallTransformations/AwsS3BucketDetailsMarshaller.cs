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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsS3BucketDetails Marshaller
    /// </summary>
    public class AwsS3BucketDetailsMarshaller : IRequestMarshaller<AwsS3BucketDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsS3BucketDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccessControlList())
            {
                context.Writer.WritePropertyName("AccessControlList");
                context.Writer.WriteStringValue(requestObject.AccessControlList);
            }

            if(requestObject.IsSetBucketLifecycleConfiguration())
            {
                context.Writer.WritePropertyName("BucketLifecycleConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketBucketLifecycleConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.BucketLifecycleConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBucketLoggingConfiguration())
            {
                context.Writer.WritePropertyName("BucketLoggingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketLoggingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BucketLoggingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBucketNotificationConfiguration())
            {
                context.Writer.WritePropertyName("BucketNotificationConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketNotificationConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BucketNotificationConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBucketVersioningConfiguration())
            {
                context.Writer.WritePropertyName("BucketVersioningConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketBucketVersioningConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BucketVersioningConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBucketWebsiteConfiguration())
            {
                context.Writer.WritePropertyName("BucketWebsiteConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketWebsiteConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BucketWebsiteConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.WriteStringValue(requestObject.CreatedAt);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetObjectLockConfiguration())
            {
                context.Writer.WritePropertyName("ObjectLockConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketObjectLockConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ObjectLockConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOwnerAccountId())
            {
                context.Writer.WritePropertyName("OwnerAccountId");
                context.Writer.WriteStringValue(requestObject.OwnerAccountId);
            }

            if(requestObject.IsSetOwnerId())
            {
                context.Writer.WritePropertyName("OwnerId");
                context.Writer.WriteStringValue(requestObject.OwnerId);
            }

            if(requestObject.IsSetOwnerName())
            {
                context.Writer.WritePropertyName("OwnerName");
                context.Writer.WriteStringValue(requestObject.OwnerName);
            }

            if(requestObject.IsSetPublicAccessBlockConfiguration())
            {
                context.Writer.WritePropertyName("PublicAccessBlockConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3AccountPublicAccessBlockDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.PublicAccessBlockConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServerSideEncryptionConfiguration())
            {
                context.Writer.WritePropertyName("ServerSideEncryptionConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsS3BucketServerSideEncryptionConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ServerSideEncryptionConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsS3BucketDetailsMarshaller Instance = new AwsS3BucketDetailsMarshaller();

    }
}