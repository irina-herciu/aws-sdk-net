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
 * Do not modify this file. This file is generated from the workspaces-thin-client-2023-08-22.normal.json service model.
 */

using System;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Util.Internal;
using Amazon.WorkSpacesThinClient.Internal;

namespace Amazon.WorkSpacesThinClient
{
    /// <summary>
    /// Configuration for accessing Amazon WorkSpacesThinClient service
    /// </summary>
    [AWSSignerType("v4")]
    public partial class AmazonWorkSpacesThinClientConfig : ClientConfig
    {
        private static readonly string UserAgentString =
            InternalSDKUtils.BuildUserAgentString("WorkSpaces Thin Client", "3.7.403.10");

        private string _userAgent = UserAgentString;
        ///<summary>
        /// The ServiceId, which is the unique identifier for a service.
        ///</summary>
        public static new string ServiceId
        {
            get
            {
                return "WorkSpaces Thin Client";
            }
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonWorkSpacesThinClientConfig()
            : base(new Amazon.Runtime.Internal.DefaultConfigurationProvider(AmazonWorkSpacesThinClientDefaultConfiguration.GetAllConfigurations()))
        {
            base.ServiceId = "WorkSpaces Thin Client";
            this.AuthenticationServiceName = "thinclient";
            this.EndpointProvider = new AmazonWorkSpacesThinClientEndpointProvider();
        }

        /// <summary>
        /// The constant used to lookup in the region hash the endpoint.
        /// </summary>
        public override string RegionEndpointServiceName
        {
            get
            {
                return "thinclient";
            }
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2023-08-22";
            }
        }

        /// <summary>
        /// Gets the value of UserAgent property.
        /// </summary>
        public override string UserAgent
        {
            get
            {
                return _userAgent;
            }
        }

    }
}