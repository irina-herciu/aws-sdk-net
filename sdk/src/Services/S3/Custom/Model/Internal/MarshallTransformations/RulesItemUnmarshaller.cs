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
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using Amazon.Runtime;

#pragma warning disable CS0612,CS0618
namespace Amazon.S3.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   RulesItem Unmarshaller
     /// </summary>
    public class RulesItemUnmarshaller : IXmlUnmarshaller<LifecycleRule, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public LifecycleRule Unmarshall(XmlUnmarshallerContext context) 
        {
            LifecycleRule rulesItem = new LifecycleRule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Expiration", targetDepth))
                    {
                        rulesItem.Expiration = ExpirationUnmarshaller.Instance.Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("ID", targetDepth))
                    {
                        rulesItem.Id = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        var predicateList = LifecycleFilterPredicateListUnmarshaller.Instance.Unmarshall(context);

                        if (predicateList.Count == 1)
                        {
                            rulesItem.Filter = new LifecycleFilter()
                            {
                                LifecycleFilterPredicate = predicateList[0]
                            };
                        }
                        else if (predicateList.Count > 1)
                        {
                            var requestId = context.ResponseData.GetHeaderValue(HeaderKeys.RequestIdHeader);
                            var message = "The Filter element must contain at most one 'Prefix', 'Tag', or 'And' predicate.";
                            throw new AmazonUnmarshallingException(requestId, context.CurrentPath, context.ResponseBody, message, null);
                        }
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        rulesItem.Status = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Transition", targetDepth))
                    {
                        if (rulesItem.Transitions == null)
                        {
                            rulesItem.Transitions = new List<LifecycleTransition>();
                        }
                        rulesItem.Transitions.Add(TransitionUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("NoncurrentVersionTransition", targetDepth))
                    {
                        if (rulesItem.NoncurrentVersionTransitions == null)
                        {
                            rulesItem.NoncurrentVersionTransitions = new List<LifecycleRuleNoncurrentVersionTransition>();
                        }
                        rulesItem.NoncurrentVersionTransitions.Add(LifecycleRuleNoncurrentVersionTransitionUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("NoncurrentVersionExpiration", targetDepth))
                    {
                        rulesItem.NoncurrentVersionExpiration = LifecycleRuleNoncurrentVersionExpirationUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("AbortIncompleteMultipartUpload", targetDepth))
                    {
                        rulesItem.AbortIncompleteMultipartUpload = AbortIncompleteMultipartUploadUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return rulesItem;
                }
            }
                        


            return rulesItem;
        }

        private static RulesItemUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static RulesItemUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new RulesItemUnmarshaller();
                }
                return _instance;
            }
        }
    }
}