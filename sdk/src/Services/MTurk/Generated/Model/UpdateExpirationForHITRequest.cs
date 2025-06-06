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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
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
namespace Amazon.MTurk.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateExpirationForHIT operation.
    /// The <c>UpdateExpirationForHIT</c> operation allows you update the expiration time
    /// of a HIT. If you update it to a time in the past, the HIT will be immediately expired.
    /// </summary>
    public partial class UpdateExpirationForHITRequest : AmazonMTurkRequest
    {
        private DateTime? _expireAt;
        private string _hitId;

        /// <summary>
        /// Gets and sets the property ExpireAt. 
        /// <para>
        ///  The date and time at which you want the HIT to expire 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? ExpireAt
        {
            get { return this._expireAt; }
            set { this._expireAt = value; }
        }

        // Check to see if ExpireAt property is set
        internal bool IsSetExpireAt()
        {
            return this._expireAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HITId. 
        /// <para>
        ///  The HIT to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string HITId
        {
            get { return this._hitId; }
            set { this._hitId = value; }
        }

        // Check to see if HITId property is set
        internal bool IsSetHITId()
        {
            return this._hitId != null;
        }

    }
}