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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FirewallPolicy Object
    /// </summary>  
    public class FirewallPolicyUnmarshaller : IJsonUnmarshaller<FirewallPolicy, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public FirewallPolicy Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            FirewallPolicy unmarshalledObject = new FirewallPolicy();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("PolicyVariables", targetDepth))
                {
                    var unmarshaller = PolicyVariablesUnmarshaller.Instance;
                    unmarshalledObject.PolicyVariables = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatefulDefaultActions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StatefulDefaultActions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatefulEngineOptions", targetDepth))
                {
                    var unmarshaller = StatefulEngineOptionsUnmarshaller.Instance;
                    unmarshalledObject.StatefulEngineOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatefulRuleGroupReferences", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StatefulRuleGroupReference, StatefulRuleGroupReferenceUnmarshaller>(StatefulRuleGroupReferenceUnmarshaller.Instance);
                    unmarshalledObject.StatefulRuleGroupReferences = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatelessCustomActions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<CustomAction, CustomActionUnmarshaller>(CustomActionUnmarshaller.Instance);
                    unmarshalledObject.StatelessCustomActions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatelessDefaultActions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StatelessDefaultActions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatelessFragmentDefaultActions", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.StatelessFragmentDefaultActions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatelessRuleGroupReferences", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StatelessRuleGroupReference, StatelessRuleGroupReferenceUnmarshaller>(StatelessRuleGroupReferenceUnmarshaller.Instance);
                    unmarshalledObject.StatelessRuleGroupReferences = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TLSInspectionConfigurationArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TLSInspectionConfigurationArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static FirewallPolicyUnmarshaller _instance = new FirewallPolicyUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static FirewallPolicyUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}