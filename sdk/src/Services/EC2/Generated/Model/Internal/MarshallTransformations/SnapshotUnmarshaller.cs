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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Snapshot Object
    /// </summary>  
    public class SnapshotUnmarshaller : IXmlUnmarshaller<Snapshot, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Snapshot Unmarshall(XmlUnmarshallerContext context)
        {
            Snapshot unmarshalledObject = new Snapshot();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("availabilityZone", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AvailabilityZone = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("completionDurationMinutes", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.CompletionDurationMinutes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("completionTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.CompletionTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("dataEncryptionKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DataEncryptionKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("encrypted", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        unmarshalledObject.Encrypted = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("fullSnapshotSizeInBytes", targetDepth))
                    {
                        var unmarshaller = NullableLongUnmarshaller.Instance;
                        unmarshalledObject.FullSnapshotSizeInBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("kmsKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("outpostArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OutpostArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ownerAlias", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerAlias = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ownerId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.OwnerId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("progress", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Progress = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("restoreExpiryTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.RestoreExpiryTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("snapshotId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SnapshotId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("sseType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SseType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("startTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.State = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("statusMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StateMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("storageTier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StorageTier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("transferType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TransferType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("volumeId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.VolumeId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("volumeSize", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.VolumeSize = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static SnapshotUnmarshaller _instance = new SnapshotUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SnapshotUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}