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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EC2CreateRouteAction Object
    /// </summary>  
    public class EC2CreateRouteActionUnmarshaller : IJsonUnmarshaller<EC2CreateRouteAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EC2CreateRouteAction Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EC2CreateRouteAction unmarshalledObject = new EC2CreateRouteAction();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Description = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DestinationCidrBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationCidrBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DestinationIpv6CidrBlock", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationIpv6CidrBlock = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("DestinationPrefixListId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DestinationPrefixListId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("GatewayId", targetDepth))
                {
                    var unmarshaller = ActionTargetUnmarshaller.Instance;
                    unmarshalledObject.GatewayId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RouteTableId", targetDepth))
                {
                    var unmarshaller = ActionTargetUnmarshaller.Instance;
                    unmarshalledObject.RouteTableId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VpcEndpointId", targetDepth))
                {
                    var unmarshaller = ActionTargetUnmarshaller.Instance;
                    unmarshalledObject.VpcEndpointId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EC2CreateRouteActionUnmarshaller _instance = new EC2CreateRouteActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EC2CreateRouteActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}