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
 * Do not modify this file. This file is generated from the dataexchange-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataExchange.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DataExchange.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateS3DataAccessFromS3BucketRequestDetails Marshaller
    /// </summary>
    public class CreateS3DataAccessFromS3BucketRequestDetailsMarshaller : IRequestMarshaller<CreateS3DataAccessFromS3BucketRequestDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CreateS3DataAccessFromS3BucketRequestDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAssetSource())
            {
                context.Writer.WritePropertyName("AssetSource");
                context.Writer.WriteStartObject();

                var marshaller = S3DataAccessAssetSourceEntryMarshaller.Instance;
                marshaller.Marshall(requestObject.AssetSource, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataSetId())
            {
                context.Writer.WritePropertyName("DataSetId");
                context.Writer.WriteStringValue(requestObject.DataSetId);
            }

            if(requestObject.IsSetRevisionId())
            {
                context.Writer.WritePropertyName("RevisionId");
                context.Writer.WriteStringValue(requestObject.RevisionId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CreateS3DataAccessFromS3BucketRequestDetailsMarshaller Instance = new CreateS3DataAccessFromS3BucketRequestDetailsMarshaller();

    }
}