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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// A list of additional configuration which will be configured for the organization.
    /// </summary>
    public partial class OrganizationAdditionalConfigurationResult
    {
        private OrgFeatureStatus _autoEnable;
        private OrgFeatureAdditionalConfiguration _name;

        /// <summary>
        /// Gets and sets the property AutoEnable. 
        /// <para>
        /// Describes the status of the additional configuration that is configured for the member
        /// accounts within the organization. One of the following values is the status for the
        /// entire organization:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW</c>: Indicates that when a new account joins the organization, they will have
        /// the additional configuration enabled automatically. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c>: Indicates that all accounts in the organization have the additional configuration
        /// enabled automatically. This includes <c>NEW</c> accounts that join the organization
        /// and accounts that may have been suspended or removed from the organization in GuardDuty.
        /// </para>
        ///  
        /// <para>
        /// It may take up to 24 hours to update the configuration for all the member accounts.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NONE</c>: Indicates that the additional configuration will not be automatically
        /// enabled for any account in the organization. The administrator must manage the additional
        /// configuration for each account individually.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OrgFeatureStatus AutoEnable
        {
            get { return this._autoEnable; }
            set { this._autoEnable = value; }
        }

        // Check to see if AutoEnable property is set
        internal bool IsSetAutoEnable()
        {
            return this._autoEnable != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the additional configuration that is configured for the member accounts
        /// within the organization. These values are applicable to only Runtime Monitoring protection
        /// plan.
        /// </para>
        /// </summary>
        public OrgFeatureAdditionalConfiguration Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}