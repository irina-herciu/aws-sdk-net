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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the UnassignPrivateNatGatewayAddress operation.
    /// Unassigns secondary private IPv4 addresses from a private NAT gateway. You cannot
    /// unassign your primary private IP. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/nat-gateway-working-with.html#nat-gateway-edit-secondary">Edit
    /// secondary IP address associations</a> in the <i>Amazon VPC User Guide</i>.
    /// 
    ///  
    /// <para>
    /// While unassigning is in progress, you cannot assign/unassign additional IP addresses
    /// while the connections are being drained. You are, however, allowed to delete the NAT
    /// gateway.
    /// </para>
    ///  
    /// <para>
    /// A private IP address will only be released at the end of MaxDrainDurationSeconds.
    /// The private IP addresses stay associated and support the existing connections, but
    /// do not support any new connections (new connections are distributed across the remaining
    /// assigned private IP address). After the existing connections drain out, the private
    /// IP addresses are released.
    /// </para>
    /// </summary>
    public partial class UnassignPrivateNatGatewayAddressRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private int? _maxDrainDurationSeconds;
        private string _natGatewayId;
        private List<string> _privateIpAddresses = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDrainDurationSeconds. 
        /// <para>
        /// The maximum amount of time to wait (in seconds) before forcibly releasing the IP addresses
        /// if connections are still in progress. Default value is 350 seconds.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4000)]
        public int? MaxDrainDurationSeconds
        {
            get { return this._maxDrainDurationSeconds; }
            set { this._maxDrainDurationSeconds = value; }
        }

        // Check to see if MaxDrainDurationSeconds property is set
        internal bool IsSetMaxDrainDurationSeconds()
        {
            return this._maxDrainDurationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NatGatewayId. 
        /// <para>
        /// The ID of the NAT gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string NatGatewayId
        {
            get { return this._natGatewayId; }
            set { this._natGatewayId = value; }
        }

        // Check to see if NatGatewayId property is set
        internal bool IsSetNatGatewayId()
        {
            return this._natGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddresses. 
        /// <para>
        /// The private IPv4 addresses you want to unassign.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PrivateIpAddresses
        {
            get { return this._privateIpAddresses; }
            set { this._privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this._privateIpAddresses != null && (this._privateIpAddresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}