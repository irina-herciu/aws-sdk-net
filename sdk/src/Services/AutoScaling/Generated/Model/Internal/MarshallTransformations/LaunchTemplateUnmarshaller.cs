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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LaunchTemplate Object
    /// </summary>  
    public class LaunchTemplateUnmarshaller : IXmlUnmarshaller<LaunchTemplate, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public LaunchTemplate Unmarshall(XmlUnmarshallerContext context)
        {
            LaunchTemplate unmarshalledObject = new LaunchTemplate();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("LaunchTemplateSpecification", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateSpecificationUnmarshaller.Instance;
                        unmarshalledObject.LaunchTemplateSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Overrides/member", targetDepth))
                    {
                        var unmarshaller = LaunchTemplateOverridesUnmarshaller.Instance;
                        if (unmarshalledObject.Overrides == null)
                        {
                            unmarshalledObject.Overrides = new List<LaunchTemplateOverrides>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Overrides.Add(item);
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

        private static LaunchTemplateUnmarshaller _instance = new LaunchTemplateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LaunchTemplateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}