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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// A summary of the data access policy.
    /// </summary>
    public partial class AccessPolicySummary
    {
        private long? _createdDate;
        private string _description;
        private long? _lastModifiedDate;
        private string _name;
        private string _policyVersion;
        private AccessPolicyType _type;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The Epoch time when the access policy was created.
        /// </para>
        /// </summary>
        public long? CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the collection was last modified.
        /// </para>
        /// </summary>
        public long? LastModifiedDate
        {
            get { return this._lastModifiedDate; }
            set { this._lastModifiedDate = value; }
        }

        // Check to see if LastModifiedDate property is set
        internal bool IsSetLastModifiedDate()
        {
            return this._lastModifiedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the access policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=32)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyVersion. 
        /// <para>
        /// The version of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=36)]
        public string PolicyVersion
        {
            get { return this._policyVersion; }
            set { this._policyVersion = value; }
        }

        // Check to see if PolicyVersion property is set
        internal bool IsSetPolicyVersion()
        {
            return this._policyVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of access policy. Currently, the only available type is <c>data</c>.
        /// </para>
        /// </summary>
        public AccessPolicyType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}