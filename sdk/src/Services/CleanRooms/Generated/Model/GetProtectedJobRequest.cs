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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Container for the parameters to the GetProtectedJob operation.
    /// Returns job processing metadata.
    /// </summary>
    public partial class GetProtectedJobRequest : AmazonCleanRoomsRequest
    {
        private string _membershipIdentifier;
        private string _protectedJobIdentifier;

        /// <summary>
        /// Gets and sets the property MembershipIdentifier. 
        /// <para>
        ///  The identifier for a membership in a protected job instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string MembershipIdentifier
        {
            get { return this._membershipIdentifier; }
            set { this._membershipIdentifier = value; }
        }

        // Check to see if MembershipIdentifier property is set
        internal bool IsSetMembershipIdentifier()
        {
            return this._membershipIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ProtectedJobIdentifier. 
        /// <para>
        ///  The identifier for the protected job instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ProtectedJobIdentifier
        {
            get { return this._protectedJobIdentifier; }
            set { this._protectedJobIdentifier = value; }
        }

        // Check to see if ProtectedJobIdentifier property is set
        internal bool IsSetProtectedJobIdentifier()
        {
            return this._protectedJobIdentifier != null;
        }

    }
}