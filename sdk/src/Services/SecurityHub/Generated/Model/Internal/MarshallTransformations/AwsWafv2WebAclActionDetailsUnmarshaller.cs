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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsWafv2WebAclActionDetails Object
    /// </summary>  
    public class AwsWafv2WebAclActionDetailsUnmarshaller : IJsonUnmarshaller<AwsWafv2WebAclActionDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public AwsWafv2WebAclActionDetails Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            AwsWafv2WebAclActionDetails unmarshalledObject = new AwsWafv2WebAclActionDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Allow", targetDepth))
                {
                    var unmarshaller = AwsWafv2ActionAllowDetailsUnmarshaller.Instance;
                    unmarshalledObject.Allow = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Block", targetDepth))
                {
                    var unmarshaller = AwsWafv2ActionBlockDetailsUnmarshaller.Instance;
                    unmarshalledObject.Block = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static AwsWafv2WebAclActionDetailsUnmarshaller _instance = new AwsWafv2WebAclActionDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AwsWafv2WebAclActionDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}