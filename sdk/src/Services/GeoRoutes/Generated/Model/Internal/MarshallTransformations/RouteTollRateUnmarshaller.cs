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
 * Do not modify this file. This file is generated from the geo-routes-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GeoRoutes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GeoRoutes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RouteTollRate Object
    /// </summary>  
    public class RouteTollRateUnmarshaller : IUnmarshaller<RouteTollRate, XmlUnmarshallerContext>, IUnmarshaller<RouteTollRate, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        RouteTollRate IUnmarshaller<RouteTollRate, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RouteTollRate Unmarshall(JsonUnmarshallerContext context)
        {
            RouteTollRate unmarshalledObject = new RouteTollRate();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("ApplicableTimes", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicableTimes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ConvertedPrice", targetDepth))
                {
                    var unmarshaller = RouteTollPriceUnmarshaller.Instance;
                    unmarshalledObject.ConvertedPrice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LocalPrice", targetDepth))
                {
                    var unmarshaller = RouteTollPriceUnmarshaller.Instance;
                    unmarshalledObject.LocalPrice = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Pass", targetDepth))
                {
                    var unmarshaller = RouteTollPassUnmarshaller.Instance;
                    unmarshalledObject.Pass = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PaymentMethods", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.PaymentMethods = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Transponders", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<RouteTransponder, RouteTransponderUnmarshaller>(RouteTransponderUnmarshaller.Instance);
                    unmarshalledObject.Transponders = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RouteTollRateUnmarshaller _instance = new RouteTollRateUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RouteTollRateUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}