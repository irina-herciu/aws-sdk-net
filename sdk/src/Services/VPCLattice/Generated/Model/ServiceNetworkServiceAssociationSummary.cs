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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Summary information about an association between a service network and a service.
    /// </summary>
    public partial class ServiceNetworkServiceAssociationSummary
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _customDomainName;
        private DnsEntry _dnsEntry;
        private string _id;
        private string _serviceArn;
        private string _serviceId;
        private string _serviceName;
        private string _serviceNetworkArn;
        private string _serviceNetworkId;
        private string _serviceNetworkName;
        private ServiceNetworkServiceAssociationStatus _status;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the association was created, in ISO-8601 format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The account that created the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property CustomDomainName. 
        /// <para>
        /// The custom domain name of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
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
        /// Gets and sets the property DnsEntry. 
        /// <para>
        /// The DNS information.
        /// </para>
        /// </summary>
        public DnsEntry DnsEntry
        {
            get { return this._dnsEntry; }
            set { this._dnsEntry = value; }
        }

        // Check to see if DnsEntry property is set
        internal bool IsSetDnsEntry()
        {
            return this._dnsEntry != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=17, Max=2048)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceId. 
        /// <para>
        /// The ID of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string ServiceId
        {
            get { return this._serviceId; }
            set { this._serviceId = value; }
        }

        // Check to see if ServiceId property is set
        internal bool IsSetServiceId()
        {
            return this._serviceId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceName. 
        /// <para>
        /// The name of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=40)]
        public string ServiceName
        {
            get { return this._serviceName; }
            set { this._serviceName = value; }
        }

        // Check to see if ServiceName property is set
        internal bool IsSetServiceName()
        {
            return this._serviceName != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=2048)]
        public string ServiceNetworkArn
        {
            get { return this._serviceNetworkArn; }
            set { this._serviceNetworkArn = value; }
        }

        // Check to see if ServiceNetworkArn property is set
        internal bool IsSetServiceNetworkArn()
        {
            return this._serviceNetworkArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkId. 
        /// <para>
        /// The ID of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
        public string ServiceNetworkId
        {
            get { return this._serviceNetworkId; }
            set { this._serviceNetworkId = value; }
        }

        // Check to see if ServiceNetworkId property is set
        internal bool IsSetServiceNetworkId()
        {
            return this._serviceNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkName. 
        /// <para>
        /// The name of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string ServiceNetworkName
        {
            get { return this._serviceNetworkName; }
            set { this._serviceNetworkName = value; }
        }

        // Check to see if ServiceNetworkName property is set
        internal bool IsSetServiceNetworkName()
        {
            return this._serviceNetworkName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status. If the deletion fails, try to delete again.
        /// </para>
        /// </summary>
        public ServiceNetworkServiceAssociationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}