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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for MultipartReadSetUploadListItem Object
    /// </summary>  
    public class MultipartReadSetUploadListItemUnmarshaller : IJsonUnmarshaller<MultipartReadSetUploadListItem, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public MultipartReadSetUploadListItem Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            MultipartReadSetUploadListItem unmarshalledObject = new MultipartReadSetUploadListItem();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("creationTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("generatedFrom", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.GeneratedFrom = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("referenceArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ReferenceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sampleId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SampleId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sequenceStoreId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SequenceStoreId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("sourceFileType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceFileType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("subjectId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubjectId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("uploadId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UploadId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static MultipartReadSetUploadListItemUnmarshaller _instance = new MultipartReadSetUploadListItemUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MultipartReadSetUploadListItemUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}