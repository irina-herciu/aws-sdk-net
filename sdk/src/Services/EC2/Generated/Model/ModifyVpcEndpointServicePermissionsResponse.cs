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
    /// This is the response object from the ModifyVpcEndpointServicePermissions operation.
    /// </summary>
    public partial class ModifyVpcEndpointServicePermissionsResponse : AmazonWebServiceResponse
    {
        private List<AddedPrincipal> _addedPrincipals = AWSConfigs.InitializeCollections ? new List<AddedPrincipal>() : null;
        private bool? _returnValue;

        /// <summary>
        /// Gets and sets the property AddedPrincipals. 
        /// <para>
        /// Information about the added principals.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AddedPrincipal> AddedPrincipals
        {
            get { return this._addedPrincipals; }
            set { this._addedPrincipals = value; }
        }

        // Check to see if AddedPrincipals property is set
        internal bool IsSetAddedPrincipals()
        {
            return this._addedPrincipals != null && (this._addedPrincipals.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReturnValue. 
        /// <para>
        /// Returns <c>true</c> if the request succeeds; otherwise, it returns an error.
        /// </para>
        /// </summary>
        public bool? ReturnValue
        {
            get { return this._returnValue; }
            set { this._returnValue = value; }
        }

        // Check to see if ReturnValue property is set
        internal bool IsSetReturnValue()
        {
            return this._returnValue.HasValue; 
        }

    }
}