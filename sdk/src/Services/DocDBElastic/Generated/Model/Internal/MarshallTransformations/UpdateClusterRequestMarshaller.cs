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
 * Do not modify this file. This file is generated from the docdb-elastic-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DocDBElastic.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.DocDBElastic.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateCluster Request Marshaller
    /// </summary>       
    public class UpdateClusterRequestMarshaller : IMarshaller<IRequest, UpdateClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DocDBElastic");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetClusterArn())
                throw new AmazonDocDBElasticException("Request object does not have required field ClusterArn set");
            request.AddPathResource("{clusterArn}", StringUtils.FromString(publicRequest.ClusterArn));
            request.ResourcePath = "/cluster/{clusterArn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAdminUserPassword())
            {
                context.Writer.WritePropertyName("adminUserPassword");
                context.Writer.WriteStringValue(publicRequest.AdminUserPassword);
            }

            if(publicRequest.IsSetAuthType())
            {
                context.Writer.WritePropertyName("authType");
                context.Writer.WriteStringValue(publicRequest.AuthType);
            }

            if(publicRequest.IsSetBackupRetentionPeriod())
            {
                context.Writer.WritePropertyName("backupRetentionPeriod");
                context.Writer.WriteNumberValue(publicRequest.BackupRetentionPeriod.Value);
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetPreferredBackupWindow())
            {
                context.Writer.WritePropertyName("preferredBackupWindow");
                context.Writer.WriteStringValue(publicRequest.PreferredBackupWindow);
            }

            if(publicRequest.IsSetPreferredMaintenanceWindow())
            {
                context.Writer.WritePropertyName("preferredMaintenanceWindow");
                context.Writer.WriteStringValue(publicRequest.PreferredMaintenanceWindow);
            }

            if(publicRequest.IsSetShardCapacity())
            {
                context.Writer.WritePropertyName("shardCapacity");
                context.Writer.WriteNumberValue(publicRequest.ShardCapacity.Value);
            }

            if(publicRequest.IsSetShardCount())
            {
                context.Writer.WritePropertyName("shardCount");
                context.Writer.WriteNumberValue(publicRequest.ShardCount.Value);
            }

            if(publicRequest.IsSetShardInstanceCount())
            {
                context.Writer.WritePropertyName("shardInstanceCount");
                context.Writer.WriteNumberValue(publicRequest.ShardInstanceCount.Value);
            }

            if(publicRequest.IsSetSubnetIds())
            {
                context.Writer.WritePropertyName("subnetIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                {
                        context.Writer.WriteStringValue(publicRequestSubnetIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVpcSecurityGroupIds())
            {
                context.Writer.WritePropertyName("vpcSecurityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVpcSecurityGroupIdsListValue in publicRequest.VpcSecurityGroupIds)
                {
                        context.Writer.WriteStringValue(publicRequestVpcSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static UpdateClusterRequestMarshaller _instance = new UpdateClusterRequestMarshaller();        

        internal static UpdateClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}