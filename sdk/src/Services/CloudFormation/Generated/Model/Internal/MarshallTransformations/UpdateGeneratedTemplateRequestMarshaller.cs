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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateGeneratedTemplate Request Marshaller
    /// </summary>       
    public class UpdateGeneratedTemplateRequestMarshaller : IMarshaller<IRequest, UpdateGeneratedTemplateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateGeneratedTemplateRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateGeneratedTemplateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CloudFormation");
            request.Parameters.Add("Action", "UpdateGeneratedTemplate");
            request.Parameters.Add("Version", "2010-05-15");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAddResources())
                {
                    if (publicRequest.AddResources.Count == 0)
                        request.Parameters.Add("AddResources", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.AddResources)
                         {
                            if(publicRequestlistValue.IsSetLogicalResourceId())
                            {
                                request.Parameters.Add("AddResources" + "." + "member" + "." + publicRequestlistValueIndex + "." + "LogicalResourceId", StringUtils.FromString(publicRequestlistValue.LogicalResourceId));
                            }
                            if(publicRequestlistValue.IsSetResourceIdentifier())
                            {
                                int mapIndex = 1;
                                foreach(var key in publicRequestlistValue.ResourceIdentifier.Keys)
                                {
                                    String value;
                                    bool hasValue = publicRequestlistValue.ResourceIdentifier.TryGetValue(key, out value);
                                    request.Parameters.Add("AddResources" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceIdentifier" + "." + "entry" + "." + mapIndex + "." + "key", StringUtils.FromString(key));
                                    if (hasValue)
                                    {
                                        request.Parameters.Add("AddResources" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceIdentifier" + "." + "entry" + "." + mapIndex + "." + "value", StringUtils.FromString(value));
                                    }
                                    mapIndex++;
                                }
                            }
                            if(publicRequestlistValue.IsSetResourceType())
                            {
                                request.Parameters.Add("AddResources" + "." + "member" + "." + publicRequestlistValueIndex + "." + "ResourceType", StringUtils.FromString(publicRequestlistValue.ResourceType));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetGeneratedTemplateName())
                {
                    request.Parameters.Add("GeneratedTemplateName", StringUtils.FromString(publicRequest.GeneratedTemplateName));
                }
                if(publicRequest.IsSetNewGeneratedTemplateName())
                {
                    request.Parameters.Add("NewGeneratedTemplateName", StringUtils.FromString(publicRequest.NewGeneratedTemplateName));
                }
                if(publicRequest.IsSetRefreshAllResources())
                {
                    request.Parameters.Add("RefreshAllResources", StringUtils.FromBool(publicRequest.RefreshAllResources));
                }
                if(publicRequest.IsSetRemoveResources())
                {
                    if (publicRequest.RemoveResources.Count == 0)
                        request.Parameters.Add("RemoveResources", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.RemoveResources)
                         {
                             request.Parameters.Add("RemoveResources" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTemplateConfiguration())
                {
                    if(publicRequest.TemplateConfiguration.IsSetDeletionPolicy())
                    {
                        request.Parameters.Add("TemplateConfiguration" + "." + "DeletionPolicy", StringUtils.FromString(publicRequest.TemplateConfiguration.DeletionPolicy));
                    }
                    if(publicRequest.TemplateConfiguration.IsSetUpdateReplacePolicy())
                    {
                        request.Parameters.Add("TemplateConfiguration" + "." + "UpdateReplacePolicy", StringUtils.FromString(publicRequest.TemplateConfiguration.UpdateReplacePolicy));
                    }
                }
            }
            return request;
        }
                    private static UpdateGeneratedTemplateRequestMarshaller _instance = new UpdateGeneratedTemplateRequestMarshaller();        

        internal static UpdateGeneratedTemplateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateGeneratedTemplateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}