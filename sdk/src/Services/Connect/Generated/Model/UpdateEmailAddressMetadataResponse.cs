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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the UpdateEmailAddressMetadata operation.
    /// </summary>
    public partial class UpdateEmailAddressMetadataResponse : AmazonWebServiceResponse
    {
        private string _emailAddressArn;
        private string _emailAddressId;

        /// <summary>
        /// Gets and sets the property EmailAddressArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the email address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string EmailAddressArn
        {
            get { return this._emailAddressArn; }
            set { this._emailAddressArn = value; }
        }

        // Check to see if EmailAddressArn property is set
        internal bool IsSetEmailAddressArn()
        {
            return this._emailAddressArn != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddressId. 
        /// <para>
        /// The identifier of the email address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=500)]
        public string EmailAddressId
        {
            get { return this._emailAddressId; }
            set { this._emailAddressId = value; }
        }

        // Check to see if EmailAddressId property is set
        internal bool IsSetEmailAddressId()
        {
            return this._emailAddressId != null;
        }

    }
}