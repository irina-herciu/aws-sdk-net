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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceLFTags operation.
    /// Returns the LF-tags applied to a resource.
    /// </summary>
    public partial class GetResourceLFTagsRequest : AmazonLakeFormationRequest
    {
        private string _catalogId;
        private Resource _resource;
        private bool? _showAssignedLFTags;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your Lake Formation environment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property Resource. 
        /// <para>
        /// The database, table, or column resource for which you want to return LF-tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Resource Resource
        {
            get { return this._resource; }
            set { this._resource = value; }
        }

        // Check to see if Resource property is set
        internal bool IsSetResource()
        {
            return this._resource != null;
        }

        /// <summary>
        /// Gets and sets the property ShowAssignedLFTags. 
        /// <para>
        /// Indicates whether to show the assigned LF-tags.
        /// </para>
        /// </summary>
        public bool? ShowAssignedLFTags
        {
            get { return this._showAssignedLFTags; }
            set { this._showAssignedLFTags = value; }
        }

        // Check to see if ShowAssignedLFTags property is set
        internal bool IsSetShowAssignedLFTags()
        {
            return this._showAssignedLFTags.HasValue; 
        }

    }
}