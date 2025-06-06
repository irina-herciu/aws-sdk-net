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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InlineRedactionPattern Object
    /// </summary>  
    public class InlineRedactionPatternUnmarshaller : IJsonUnmarshaller<InlineRedactionPattern, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public InlineRedactionPattern Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            InlineRedactionPattern unmarshalledObject = new InlineRedactionPattern();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("builtInPatternId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.BuiltInPatternId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("confidenceLevel", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ConfidenceLevel = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("customPattern", targetDepth))
                {
                    var unmarshaller = CustomPatternUnmarshaller.Instance;
                    unmarshalledObject.CustomPattern = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("enforcedUrls", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.EnforcedUrls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("exemptUrls", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.ExemptUrls = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("redactionPlaceHolder", targetDepth))
                {
                    var unmarshaller = RedactionPlaceHolderUnmarshaller.Instance;
                    unmarshalledObject.RedactionPlaceHolder = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static InlineRedactionPatternUnmarshaller _instance = new InlineRedactionPatternUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InlineRedactionPatternUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}