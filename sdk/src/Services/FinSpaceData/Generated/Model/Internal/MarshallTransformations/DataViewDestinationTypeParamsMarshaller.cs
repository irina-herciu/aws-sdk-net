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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FinSpaceData.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FinSpaceData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataViewDestinationTypeParams Marshaller
    /// </summary>
    public class DataViewDestinationTypeParamsMarshaller : IRequestMarshaller<DataViewDestinationTypeParams, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataViewDestinationTypeParams requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestinationType())
            {
                context.Writer.WritePropertyName("destinationType");
                context.Writer.WriteStringValue(requestObject.DestinationType);
            }

            if(requestObject.IsSetS3DestinationExportFileFormat())
            {
                context.Writer.WritePropertyName("s3DestinationExportFileFormat");
                context.Writer.WriteStringValue(requestObject.S3DestinationExportFileFormat);
            }

            if(requestObject.IsSetS3DestinationExportFileFormatOptions())
            {
                context.Writer.WritePropertyName("s3DestinationExportFileFormatOptions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectS3DestinationExportFileFormatOptionsKvp in requestObject.S3DestinationExportFileFormatOptions)
                {
                    context.Writer.WritePropertyName(requestObjectS3DestinationExportFileFormatOptionsKvp.Key);
                    var requestObjectS3DestinationExportFileFormatOptionsValue = requestObjectS3DestinationExportFileFormatOptionsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectS3DestinationExportFileFormatOptionsValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataViewDestinationTypeParamsMarshaller Instance = new DataViewDestinationTypeParamsMarshaller();

    }
}