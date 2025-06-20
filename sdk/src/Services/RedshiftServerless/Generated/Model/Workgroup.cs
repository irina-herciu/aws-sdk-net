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
 * Do not modify this file. This file is generated from the redshift-serverless-2021-04-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RedshiftServerless.Model
{
    /// <summary>
    /// The collection of computing resources from which an endpoint is created.
    /// </summary>
    public partial class Workgroup
    {
        private int? _baseCapacity;
        private List<ConfigParameter> _configParameters = AWSConfigs.InitializeCollections ? new List<ConfigParameter>() : null;
        private DateTime? _creationDate;
        private List<string> _crossAccountVpcs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _customDomainCertificateArn;
        private DateTime? _customDomainCertificateExpiryTime;
        private string _customDomainName;
        private Endpoint _endpoint;
        private bool? _enhancedVpcRouting;
        private string _ipAddressType;
        private int? _maxCapacity;
        private string _namespaceName;
        private string _patchVersion;
        private string _pendingTrackName;
        private int? _port;
        private PerformanceTarget _pricePerformanceTarget;
        private bool? _publiclyAccessible;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private WorkgroupStatus _status;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _trackName;
        private string _workgroupArn;
        private string _workgroupId;
        private string _workgroupName;
        private string _workgroupVersion;

        /// <summary>
        /// Gets and sets the property BaseCapacity. 
        /// <para>
        /// The base data warehouse capacity of the workgroup in Redshift Processing Units (RPUs).
        /// </para>
        /// </summary>
        public int? BaseCapacity
        {
            get { return this._baseCapacity; }
            set { this._baseCapacity = value; }
        }

        // Check to see if BaseCapacity property is set
        internal bool IsSetBaseCapacity()
        {
            return this._baseCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConfigParameters. 
        /// <para>
        /// An array of parameters to set for advanced control over a database. The options are
        /// <c>auto_mv</c>, <c>datestyle</c>, <c>enable_case_sensitive_identifier</c>, <c>enable_user_activity_logging</c>,
        /// <c>query_group</c>, <c>search_path</c>, <c>require_ssl</c>, <c>use_fips_ssl</c>, and
        /// query monitoring metrics that let you define performance boundaries. For more information
        /// about query monitoring rules and available metrics, see <a href="https://docs.aws.amazon.com/redshift/latest/dg/cm-c-wlm-query-monitoring-rules.html#cm-c-wlm-query-monitoring-metrics-serverless">
        /// Query monitoring metrics for Amazon Redshift Serverless</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ConfigParameter> ConfigParameters
        {
            get { return this._configParameters; }
            set { this._configParameters = value; }
        }

        // Check to see if ConfigParameters property is set
        internal bool IsSetConfigParameters()
        {
            return this._configParameters != null && (this._configParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date of the workgroup.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CrossAccountVpcs. 
        /// <para>
        /// A list of VPCs. Each entry is the unique identifier of a virtual private cloud with
        /// access to Amazon Redshift Serverless. If all of the VPCs for the grantee are allowed,
        /// it shows an asterisk.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CrossAccountVpcs
        {
            get { return this._crossAccountVpcs; }
            set { this._crossAccountVpcs = value; }
        }

        // Check to see if CrossAccountVpcs property is set
        internal bool IsSetCrossAccountVpcs()
        {
            return this._crossAccountVpcs != null && (this._crossAccountVpcs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateArn. 
        /// <para>
        /// The custom domain name’s certificate Amazon resource name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CustomDomainCertificateArn
        {
            get { return this._customDomainCertificateArn; }
            set { this._customDomainCertificateArn = value; }
        }

        // Check to see if CustomDomainCertificateArn property is set
        internal bool IsSetCustomDomainCertificateArn()
        {
            return this._customDomainCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainCertificateExpiryTime. 
        /// <para>
        /// The expiration time for the certificate.
        /// </para>
        /// </summary>
        public DateTime? CustomDomainCertificateExpiryTime
        {
            get { return this._customDomainCertificateExpiryTime; }
            set { this._customDomainCertificateExpiryTime = value; }
        }

        // Check to see if CustomDomainCertificateExpiryTime property is set
        internal bool IsSetCustomDomainCertificateExpiryTime()
        {
            return this._customDomainCertificateExpiryTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name associated with the workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string CustomDomainName
        {
            get { return this._customDomainName; }
            set { this._customDomainName = value; }
        }

        // Check to see if CustomDomainName property is set
        internal bool IsSetCustomDomainName()
        {
            return this._customDomainName != null;
        }

        /// <summary>
        /// Gets and sets the property Endpoint. 
        /// <para>
        /// The endpoint that is created from the workgroup.
        /// </para>
        /// </summary>
        public Endpoint Endpoint
        {
            get { return this._endpoint; }
            set { this._endpoint = value; }
        }

        // Check to see if Endpoint property is set
        internal bool IsSetEndpoint()
        {
            return this._endpoint != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedVpcRouting. 
        /// <para>
        /// The value that specifies whether to enable enhanced virtual private cloud (VPC) routing,
        /// which forces Amazon Redshift Serverless to route traffic through your VPC.
        /// </para>
        /// </summary>
        public bool? EnhancedVpcRouting
        {
            get { return this._enhancedVpcRouting; }
            set { this._enhancedVpcRouting = value; }
        }

        // Check to see if EnhancedVpcRouting property is set
        internal bool IsSetEnhancedVpcRouting()
        {
            return this._enhancedVpcRouting.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IpAddressType. 
        /// <para>
        /// The IP address type that the workgroup supports. Possible values are <c>ipv4</c> and
        /// <c>dualstack</c>.
        /// </para>
        /// </summary>
        public string IpAddressType
        {
            get { return this._ipAddressType; }
            set { this._ipAddressType = value; }
        }

        // Check to see if IpAddressType property is set
        internal bool IsSetIpAddressType()
        {
            return this._ipAddressType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The maximum data-warehouse capacity Amazon Redshift Serverless uses to serve queries.
        /// The max capacity is specified in RPUs.
        /// </para>
        /// </summary>
        public int? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamespaceName. 
        /// <para>
        /// The namespace the workgroup is associated with.
        /// </para>
        /// </summary>
        public string NamespaceName
        {
            get { return this._namespaceName; }
            set { this._namespaceName = value; }
        }

        // Check to see if NamespaceName property is set
        internal bool IsSetNamespaceName()
        {
            return this._namespaceName != null;
        }

        /// <summary>
        /// Gets and sets the property PatchVersion. 
        /// <para>
        /// The patch version of your Amazon Redshift Serverless workgroup. For more information
        /// about patch versions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/cluster-versions.html">Cluster
        /// versions for Amazon Redshift</a>.
        /// </para>
        /// </summary>
        public string PatchVersion
        {
            get { return this._patchVersion; }
            set { this._patchVersion = value; }
        }

        // Check to see if PatchVersion property is set
        internal bool IsSetPatchVersion()
        {
            return this._patchVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PendingTrackName. 
        /// <para>
        /// The name for the track that you want to assign to the workgroup. When the track changes,
        /// the workgroup is switched to the latest workgroup release available for the track.
        /// At this point, the track name is applied.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string PendingTrackName
        {
            get { return this._pendingTrackName; }
            set { this._pendingTrackName = value; }
        }

        // Check to see if PendingTrackName property is set
        internal bool IsSetPendingTrackName()
        {
            return this._pendingTrackName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The custom port to use when connecting to a workgroup. Valid port ranges are 5431-5455
        /// and 8191-8215. The default is 5439.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PricePerformanceTarget. 
        /// <para>
        /// An object that represents the price performance target settings for the workgroup.
        /// </para>
        /// </summary>
        public PerformanceTarget PricePerformanceTarget
        {
            get { return this._pricePerformanceTarget; }
            set { this._pricePerformanceTarget = value; }
        }

        // Check to see if PricePerformanceTarget property is set
        internal bool IsSetPricePerformanceTarget()
        {
            return this._pricePerformanceTarget != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// A value that specifies whether the workgroup can be accessible from a public network.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// An array of security group IDs to associate with the workgroup.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the workgroup.
        /// </para>
        /// </summary>
        public WorkgroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// An array of subnet IDs the workgroup is associated with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrackName. 
        /// <para>
        /// The name of the track for the workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string TrackName
        {
            get { return this._trackName; }
            set { this._trackName = value; }
        }

        // Check to see if TrackName property is set
        internal bool IsSetTrackName()
        {
            return this._trackName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that links to the workgroup.
        /// </para>
        /// </summary>
        public string WorkgroupArn
        {
            get { return this._workgroupArn; }
            set { this._workgroupArn = value; }
        }

        // Check to see if WorkgroupArn property is set
        internal bool IsSetWorkgroupArn()
        {
            return this._workgroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupId. 
        /// <para>
        /// The unique identifier of the workgroup.
        /// </para>
        /// </summary>
        public string WorkgroupId
        {
            get { return this._workgroupId; }
            set { this._workgroupId = value; }
        }

        // Check to see if WorkgroupId property is set
        internal bool IsSetWorkgroupId()
        {
            return this._workgroupId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The name of the workgroup.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=64)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupVersion. 
        /// <para>
        /// The Amazon Redshift Serverless version of your workgroup. For more information about
        /// Amazon Redshift Serverless versions, see<a href="https://docs.aws.amazon.com/redshift/latest/mgmt/cluster-versions.html">Cluster
        /// versions for Amazon Redshift</a>.
        /// </para>
        /// </summary>
        public string WorkgroupVersion
        {
            get { return this._workgroupVersion; }
            set { this._workgroupVersion = value; }
        }

        // Check to see if WorkgroupVersion property is set
        internal bool IsSetWorkgroupVersion()
        {
            return this._workgroupVersion != null;
        }

    }
}