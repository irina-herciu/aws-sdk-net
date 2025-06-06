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
    /// CreateReplicationGroup Request Marshaller
    /// </summary>       
    public class CreateReplicationGroupRequestMarshaller : IMarshaller<IRequest, CreateReplicationGroupRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateReplicationGroupRequest)input);
        }
    
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateReplicationGroupRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElastiCache");
            request.Parameters.Add("Action", "CreateReplicationGroup");
            request.Parameters.Add("Version", "2015-02-02");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetAtRestEncryptionEnabled())
                {
                    request.Parameters.Add("AtRestEncryptionEnabled", StringUtils.FromBool(publicRequest.AtRestEncryptionEnabled));
                }
                if(publicRequest.IsSetAuthToken())
                {
                    request.Parameters.Add("AuthToken", StringUtils.FromString(publicRequest.AuthToken));
                }
                if(publicRequest.IsSetAutomaticFailoverEnabled())
                {
                    request.Parameters.Add("AutomaticFailoverEnabled", StringUtils.FromBool(publicRequest.AutomaticFailoverEnabled));
                }
                if(publicRequest.IsSetAutoMinorVersionUpgrade())
                {
                    request.Parameters.Add("AutoMinorVersionUpgrade", StringUtils.FromBool(publicRequest.AutoMinorVersionUpgrade));
                }
                if(publicRequest.IsSetCacheNodeType())
                {
                    request.Parameters.Add("CacheNodeType", StringUtils.FromString(publicRequest.CacheNodeType));
                }
                if(publicRequest.IsSetCacheParameterGroupName())
                {
                    request.Parameters.Add("CacheParameterGroupName", StringUtils.FromString(publicRequest.CacheParameterGroupName));
                }
                if(publicRequest.IsSetCacheSecurityGroupNames())
                {
                    if (publicRequest.CacheSecurityGroupNames.Count == 0)
                        request.Parameters.Add("CacheSecurityGroupNames", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.CacheSecurityGroupNames)
                         {
                             request.Parameters.Add("CacheSecurityGroupNames" + "." + "CacheSecurityGroupName" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetCacheSubnetGroupName())
                {
                    request.Parameters.Add("CacheSubnetGroupName", StringUtils.FromString(publicRequest.CacheSubnetGroupName));
                }
                if(publicRequest.IsSetClusterMode())
                {
                    request.Parameters.Add("ClusterMode", StringUtils.FromString(publicRequest.ClusterMode));
                }
                if(publicRequest.IsSetDataTieringEnabled())
                {
                    request.Parameters.Add("DataTieringEnabled", StringUtils.FromBool(publicRequest.DataTieringEnabled));
                }
                if(publicRequest.IsSetEngine())
                {
                    request.Parameters.Add("Engine", StringUtils.FromString(publicRequest.Engine));
                }
                if(publicRequest.IsSetEngineVersion())
                {
                    request.Parameters.Add("EngineVersion", StringUtils.FromString(publicRequest.EngineVersion));
                }
                if(publicRequest.IsSetGlobalReplicationGroupId())
                {
                    request.Parameters.Add("GlobalReplicationGroupId", StringUtils.FromString(publicRequest.GlobalReplicationGroupId));
                }
                if(publicRequest.IsSetIpDiscovery())
                {
                    request.Parameters.Add("IpDiscovery", StringUtils.FromString(publicRequest.IpDiscovery));
                }
                if(publicRequest.IsSetKmsKeyId())
                {
                    request.Parameters.Add("KmsKeyId", StringUtils.FromString(publicRequest.KmsKeyId));
                }
                if(publicRequest.IsSetLogDeliveryConfigurations())
                {
                    if (publicRequest.LogDeliveryConfigurations.Count == 0)
                        request.Parameters.Add("LogDeliveryConfigurations", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.LogDeliveryConfigurations)
                         {
                            if(publicRequestlistValue.IsSetDestinationDetails())
                            {
                                if(publicRequestlistValue.DestinationDetails.IsSetCloudWatchLogsDetails())
                                {
                                    if(publicRequestlistValue.DestinationDetails.CloudWatchLogsDetails.IsSetLogGroup())
                                    {
                                        request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "DestinationDetails" + "." + "CloudWatchLogsDetails" + "." + "LogGroup", StringUtils.FromString(publicRequestlistValue.DestinationDetails.CloudWatchLogsDetails.LogGroup));
                                    }
                                }
                                if(publicRequestlistValue.DestinationDetails.IsSetKinesisFirehoseDetails())
                                {
                                    if(publicRequestlistValue.DestinationDetails.KinesisFirehoseDetails.IsSetDeliveryStream())
                                    {
                                        request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "DestinationDetails" + "." + "KinesisFirehoseDetails" + "." + "DeliveryStream", StringUtils.FromString(publicRequestlistValue.DestinationDetails.KinesisFirehoseDetails.DeliveryStream));
                                    }
                                }
                            }
                            if(publicRequestlistValue.IsSetDestinationType())
                            {
                                request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "DestinationType", StringUtils.FromString(publicRequestlistValue.DestinationType));
                            }
                            if(publicRequestlistValue.IsSetEnabled())
                            {
                                request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "Enabled", StringUtils.FromBool(publicRequestlistValue.Enabled));
                            }
                            if(publicRequestlistValue.IsSetLogFormat())
                            {
                                request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "LogFormat", StringUtils.FromString(publicRequestlistValue.LogFormat));
                            }
                            if(publicRequestlistValue.IsSetLogType())
                            {
                                request.Parameters.Add("LogDeliveryConfigurations" + "." + "LogDeliveryConfigurationRequest" + "." + publicRequestlistValueIndex + "." + "LogType", StringUtils.FromString(publicRequestlistValue.LogType));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetMultiAZEnabled())
                {
                    request.Parameters.Add("MultiAZEnabled", StringUtils.FromBool(publicRequest.MultiAZEnabled));
                }
                if(publicRequest.IsSetNetworkType())
                {
                    request.Parameters.Add("NetworkType", StringUtils.FromString(publicRequest.NetworkType));
                }
                if(publicRequest.IsSetNodeGroupConfiguration())
                {
                    if (publicRequest.NodeGroupConfiguration.Count == 0)
                        request.Parameters.Add("NodeGroupConfiguration", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.NodeGroupConfiguration)
                         {
                            if(publicRequestlistValue.IsSetNodeGroupId())
                            {
                                request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "NodeGroupId", StringUtils.FromString(publicRequestlistValue.NodeGroupId));
                            }
                            if(publicRequestlistValue.IsSetPrimaryAvailabilityZone())
                            {
                                request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "PrimaryAvailabilityZone", StringUtils.FromString(publicRequestlistValue.PrimaryAvailabilityZone));
                            }
                            if(publicRequestlistValue.IsSetPrimaryOutpostArn())
                            {
                                request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "PrimaryOutpostArn", StringUtils.FromString(publicRequestlistValue.PrimaryOutpostArn));
                            }
                            if(publicRequestlistValue.IsSetReplicaAvailabilityZones())
                            {
                                if (publicRequestlistValue.ReplicaAvailabilityZones.Count == 0)
                                    request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "ReplicaAvailabilityZones", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.ReplicaAvailabilityZones)
                                     {
                                         request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "ReplicaAvailabilityZones" + "." + "AvailabilityZone" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetReplicaCount())
                            {
                                request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "ReplicaCount", StringUtils.FromInt(publicRequestlistValue.ReplicaCount));
                            }
                            if(publicRequestlistValue.IsSetReplicaOutpostArns())
                            {
                                if (publicRequestlistValue.ReplicaOutpostArns.Count == 0)
                                    request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "ReplicaOutpostArns", "");
                                else
                                {
                                     int publicRequestlistValuelistValueIndex = 1;
                                     foreach(var publicRequestlistValuelistValue in publicRequestlistValue.ReplicaOutpostArns)
                                     {
                                         request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "ReplicaOutpostArns" + "." + "OutpostArn" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                         publicRequestlistValuelistValueIndex++;
                                     }
                                }
                            }
                            if(publicRequestlistValue.IsSetSlots())
                            {
                                request.Parameters.Add("NodeGroupConfiguration" + "." + "NodeGroupConfiguration" + "." + publicRequestlistValueIndex + "." + "Slots", StringUtils.FromString(publicRequestlistValue.Slots));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetNotificationTopicArn())
                {
                    request.Parameters.Add("NotificationTopicArn", StringUtils.FromString(publicRequest.NotificationTopicArn));
                }
                if(publicRequest.IsSetNumCacheClusters())
                {
                    request.Parameters.Add("NumCacheClusters", StringUtils.FromInt(publicRequest.NumCacheClusters));
                }
                if(publicRequest.IsSetNumNodeGroups())
                {
                    request.Parameters.Add("NumNodeGroups", StringUtils.FromInt(publicRequest.NumNodeGroups));
                }
                if(publicRequest.IsSetPort())
                {
                    request.Parameters.Add("Port", StringUtils.FromInt(publicRequest.Port));
                }
                if(publicRequest.IsSetPreferredCacheClusterAZs())
                {
                    if (publicRequest.PreferredCacheClusterAZs.Count == 0)
                        request.Parameters.Add("PreferredCacheClusterAZs", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.PreferredCacheClusterAZs)
                         {
                             request.Parameters.Add("PreferredCacheClusterAZs" + "." + "AvailabilityZone" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    request.Parameters.Add("PreferredMaintenanceWindow", StringUtils.FromString(publicRequest.PreferredMaintenanceWindow));
                }
                if(publicRequest.IsSetPrimaryClusterId())
                {
                    request.Parameters.Add("PrimaryClusterId", StringUtils.FromString(publicRequest.PrimaryClusterId));
                }
                if(publicRequest.IsSetReplicasPerNodeGroup())
                {
                    request.Parameters.Add("ReplicasPerNodeGroup", StringUtils.FromInt(publicRequest.ReplicasPerNodeGroup));
                }
                if(publicRequest.IsSetReplicationGroupDescription())
                {
                    request.Parameters.Add("ReplicationGroupDescription", StringUtils.FromString(publicRequest.ReplicationGroupDescription));
                }
                if(publicRequest.IsSetReplicationGroupId())
                {
                    request.Parameters.Add("ReplicationGroupId", StringUtils.FromString(publicRequest.ReplicationGroupId));
                }
                if(publicRequest.IsSetSecurityGroupIds())
                {
                    if (publicRequest.SecurityGroupIds.Count == 0)
                        request.Parameters.Add("SecurityGroupIds", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SecurityGroupIds)
                         {
                             request.Parameters.Add("SecurityGroupIds" + "." + "SecurityGroupId" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetServerlessCacheSnapshotName())
                {
                    request.Parameters.Add("ServerlessCacheSnapshotName", StringUtils.FromString(publicRequest.ServerlessCacheSnapshotName));
                }
                if(publicRequest.IsSetSnapshotArns())
                {
                    if (publicRequest.SnapshotArns.Count == 0)
                        request.Parameters.Add("SnapshotArns", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.SnapshotArns)
                         {
                             request.Parameters.Add("SnapshotArns" + "." + "SnapshotArn" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetSnapshotName())
                {
                    request.Parameters.Add("SnapshotName", StringUtils.FromString(publicRequest.SnapshotName));
                }
                if(publicRequest.IsSetSnapshotRetentionLimit())
                {
                    request.Parameters.Add("SnapshotRetentionLimit", StringUtils.FromInt(publicRequest.SnapshotRetentionLimit));
                }
                if(publicRequest.IsSetSnapshotWindow())
                {
                    request.Parameters.Add("SnapshotWindow", StringUtils.FromString(publicRequest.SnapshotWindow));
                }
                if(publicRequest.IsSetTags())
                {
                    if (publicRequest.Tags.Count == 0)
                        request.Parameters.Add("Tags", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.Tags)
                         {
                            if(publicRequestlistValue.IsSetKey())
                            {
                                request.Parameters.Add("Tags" + "." + "Tag" + "." + publicRequestlistValueIndex + "." + "Key", StringUtils.FromString(publicRequestlistValue.Key));
                            }
                            if(publicRequestlistValue.IsSetValue())
                            {
                                request.Parameters.Add("Tags" + "." + "Tag" + "." + publicRequestlistValueIndex + "." + "Value", StringUtils.FromString(publicRequestlistValue.Value));
                            }
                             publicRequestlistValueIndex++;
                         }
                    }
                }
                if(publicRequest.IsSetTransitEncryptionEnabled())
                {
                    request.Parameters.Add("TransitEncryptionEnabled", StringUtils.FromBool(publicRequest.TransitEncryptionEnabled));
                }
                if(publicRequest.IsSetTransitEncryptionMode())
                {
                    request.Parameters.Add("TransitEncryptionMode", StringUtils.FromString(publicRequest.TransitEncryptionMode));
                }
                if(publicRequest.IsSetUserGroupIds())
                {
                    if (publicRequest.UserGroupIds.Count == 0)
                        request.Parameters.Add("UserGroupIds", "");
                    else
                    {
                         int publicRequestlistValueIndex = 1;
                         foreach(var publicRequestlistValue in publicRequest.UserGroupIds)
                         {
                             request.Parameters.Add("UserGroupIds" + "." + "member" + "." + publicRequestlistValueIndex, StringUtils.FromString(publicRequestlistValue));
                             publicRequestlistValueIndex++;
                         }
                    }
                }
            }
            return request;
        }
                    private static CreateReplicationGroupRequestMarshaller _instance = new CreateReplicationGroupRequestMarshaller();        

        internal static CreateReplicationGroupRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateReplicationGroupRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}