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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Threat protection configuration options for additional authentication types in your
    /// user pool, including custom authentication.
    /// </summary>
    public partial class AdvancedSecurityAdditionalFlowsType
    {
        private AdvancedSecurityEnabledModeType _customAuthMode;

        /// <summary>
        /// Gets and sets the property CustomAuthMode. 
        /// <para>
        /// The operating mode of threat protection in custom authentication with <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pool-lambda-challenge.html">
        /// Custom authentication challenge Lambda triggers</a>. 
        /// </para>
        /// </summary>
        public AdvancedSecurityEnabledModeType CustomAuthMode
        {
            get { return this._customAuthMode; }
            set { this._customAuthMode = value; }
        }

        // Check to see if CustomAuthMode property is set
        internal bool IsSetCustomAuthMode()
        {
            return this._customAuthMode != null;
        }

    }
}