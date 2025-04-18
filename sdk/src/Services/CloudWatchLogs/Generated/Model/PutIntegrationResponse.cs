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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This is the response object from the PutIntegration operation.
    /// </summary>
    public partial class PutIntegrationResponse : AmazonWebServiceResponse
    {
        private string _integrationName;
        private IntegrationStatus _integrationStatus;

        /// <summary>
        /// Gets and sets the property IntegrationName. 
        /// <para>
        /// The name of the integration that you just created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string IntegrationName
        {
            get { return this._integrationName; }
            set { this._integrationName = value; }
        }

        // Check to see if IntegrationName property is set
        internal bool IsSetIntegrationName()
        {
            return this._integrationName != null;
        }

        /// <summary>
        /// Gets and sets the property IntegrationStatus. 
        /// <para>
        /// The status of the integration that you just created.
        /// </para>
        ///  
        /// <para>
        /// After you create an integration, it takes a few minutes to complete. During this time,
        /// you'll see the status as <c>PROVISIONING</c>.
        /// </para>
        /// </summary>
        public IntegrationStatus IntegrationStatus
        {
            get { return this._integrationStatus; }
            set { this._integrationStatus = value; }
        }

        // Check to see if IntegrationStatus property is set
        internal bool IsSetIntegrationStatus()
        {
            return this._integrationStatus != null;
        }

    }
}