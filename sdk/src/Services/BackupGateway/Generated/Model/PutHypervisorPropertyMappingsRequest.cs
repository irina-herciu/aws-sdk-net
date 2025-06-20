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
 * Do not modify this file. This file is generated from the backup-gateway-2021-01-01.normal.json service model.
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
namespace Amazon.BackupGateway.Model
{
    /// <summary>
    /// Container for the parameters to the PutHypervisorPropertyMappings operation.
    /// This action sets the property mappings for the specified hypervisor. A hypervisor
    /// property mapping displays the relationship of entity properties available from the
    /// on-premises hypervisor to the properties available in Amazon Web Services.
    /// </summary>
    public partial class PutHypervisorPropertyMappingsRequest : AmazonBackupGatewayRequest
    {
        private string _hypervisorArn;
        private string _iamRoleArn;
        private List<VmwareToAwsTagMapping> _vmwareToAwsTagMappings = AWSConfigs.InitializeCollections ? new List<VmwareToAwsTagMapping>() : null;

        /// <summary>
        /// Gets and sets the property HypervisorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hypervisor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=50, Max=500)]
        public string HypervisorArn
        {
            get { return this._hypervisorArn; }
            set { this._hypervisorArn = value; }
        }

        // Check to see if HypervisorArn property is set
        internal bool IsSetHypervisorArn()
        {
            return this._hypervisorArn != null;
        }

        /// <summary>
        /// Gets and sets the property IamRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string IamRoleArn
        {
            get { return this._iamRoleArn; }
            set { this._iamRoleArn = value; }
        }

        // Check to see if IamRoleArn property is set
        internal bool IsSetIamRoleArn()
        {
            return this._iamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property VmwareToAwsTagMappings. 
        /// <para>
        /// This action requests the mappings of on-premises VMware tags to the Amazon Web Services
        /// tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VmwareToAwsTagMapping> VmwareToAwsTagMappings
        {
            get { return this._vmwareToAwsTagMappings; }
            set { this._vmwareToAwsTagMappings = value; }
        }

        // Check to see if VmwareToAwsTagMappings property is set
        internal bool IsSetVmwareToAwsTagMappings()
        {
            return this._vmwareToAwsTagMappings != null && (this._vmwareToAwsTagMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}