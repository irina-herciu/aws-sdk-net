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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SupportedEngineLifecycle Object
    /// </summary>  
    public class SupportedEngineLifecycleUnmarshaller : IXmlUnmarshaller<SupportedEngineLifecycle, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public SupportedEngineLifecycle Unmarshall(XmlUnmarshallerContext context)
        {
            SupportedEngineLifecycle unmarshalledObject = new SupportedEngineLifecycle();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("LifecycleSupportEndDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LifecycleSupportEndDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LifecycleSupportName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LifecycleSupportName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LifecycleSupportStartDate", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.LifecycleSupportStartDate = unmarshaller.Unmarshall(context);
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

        private static SupportedEngineLifecycleUnmarshaller _instance = new SupportedEngineLifecycleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SupportedEngineLifecycleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}