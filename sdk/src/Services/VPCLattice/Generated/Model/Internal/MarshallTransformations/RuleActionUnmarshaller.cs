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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.VPCLattice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.VPCLattice.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RuleAction Object
    /// </summary>  
    public class RuleActionUnmarshaller : IJsonUnmarshaller<RuleAction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public RuleAction Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            RuleAction unmarshalledObject = new RuleAction();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("fixedResponse", targetDepth))
                {
                    var unmarshaller = FixedResponseActionUnmarshaller.Instance;
                    unmarshalledObject.FixedResponse = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("forward", targetDepth))
                {
                    var unmarshaller = ForwardActionUnmarshaller.Instance;
                    unmarshalledObject.Forward = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static RuleActionUnmarshaller _instance = new RuleActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RuleActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}