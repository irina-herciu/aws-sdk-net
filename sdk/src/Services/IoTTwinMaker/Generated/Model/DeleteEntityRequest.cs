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
 * Do not modify this file. This file is generated from the iottwinmaker-2021-11-29.normal.json service model.
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
namespace Amazon.IoTTwinMaker.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteEntity operation.
    /// Deletes an entity.
    /// </summary>
    public partial class DeleteEntityRequest : AmazonIoTTwinMakerRequest
    {
        private string _entityId;
        private bool? _isRecursive;
        private string _workspaceId;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// The ID of the entity to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property IsRecursive. 
        /// <para>
        /// A Boolean value that specifies whether the operation deletes child entities.
        /// </para>
        /// </summary>
        public bool? IsRecursive
        {
            get { return this._isRecursive; }
            set { this._isRecursive = value; }
        }

        // Check to see if IsRecursive property is set
        internal bool IsSetIsRecursive()
        {
            return this._isRecursive.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The ID of the workspace that contains the entity to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

    }
}