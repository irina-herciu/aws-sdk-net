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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElastiCache.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElastiCache.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DecreaseNodeGroupsInGlobalReplicationGroup Request Marshaller
    /// </summary>       
    public class DecreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller : IMarshaller<IRequest, DecreaseNodeGroupsInGlobalReplicationGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DecreaseNodeGroupsInGlobalReplicationGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DecreaseNodeGroupsInGlobalReplicationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "DecreaseNodeGroupsInGlobalReplicationGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetApplyImmediately())
                {
                    request.Parameters.Add("ApplyImmediately", StringUtils.FromBool(publicRequest.ApplyImmediately));
                }
                if(publicRequest.IsSetGlobalNodeGroupsToRemove())
                {
                    if (publicRequest.GlobalNodeGroupsToRemove.Count == 0)
                        request.Parameters.Add("GlobalNodeGroupsToRemove", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.GlobalNodeGroupsToRemove)
                         {
                             request.Parameters.Add("GlobalNodeGroupsToRemove" + "." + "GlobalNodeGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetGlobalNodeGroupsToRetain())
                {
                    if (publicRequest.GlobalNodeGroupsToRetain.Count == 0)
                        request.Parameters.Add("GlobalNodeGroupsToRetain", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.GlobalNodeGroupsToRetain)
                         {
                             request.Parameters.Add("GlobalNodeGroupsToRetain" + "." + "GlobalNodeGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetGlobalReplicationGroupId())
                {
                    request.Parameters.Add("GlobalReplicationGroupId", StringUtils.FromString(publicRequest.GlobalReplicationGroupId));
                }
                if(publicRequest.IsSetNodeGroupCount())
                {
                    request.Parameters.Add("NodeGroupCount", StringUtils.FromInt(publicRequest.NodeGroupCount));
                }
            }
            return request;
        }
                    private static DecreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller _instance = new DecreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller();        

        internal static DecreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DecreaseNodeGroupsInGlobalReplicationGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}