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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53RecoveryReadiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Route53RecoveryReadiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CellOutput Object
    /// </summary>  
    public class CellOutputUnmarshaller : IJsonUnmarshaller<CellOutput, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public CellOutput Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            CellOutput unmarshalledObject = new CellOutput();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("cellArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CellArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cellName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CellName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("cells", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Cells = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("parentReadinessScopes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ParentReadinessScopes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static CellOutputUnmarshaller _instance = new CellOutputUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CellOutputUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}