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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the GetPlugin operation.
    /// </summary>
    public partial class GetPluginResponse : AmazonWebServiceResponse
    {
        private string _applicationId;
        private PluginAuthConfiguration _authConfiguration;
        private PluginBuildStatus _buildStatus;
        private DateTime? _createdAt;
        private CustomPluginConfiguration _customPluginConfiguration;
        private string _displayName;
        private string _pluginArn;
        private string _pluginId;
        private string _serverUrl;
        private PluginState _state;
        private PluginType _type;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The identifier of the application which contains the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property AuthConfiguration.
        /// </summary>
        public PluginAuthConfiguration AuthConfiguration
        {
            get { return this._authConfiguration; }
            set { this._authConfiguration = value; }
        }

        // Check to see if AuthConfiguration property is set
        internal bool IsSetAuthConfiguration()
        {
            return this._authConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property BuildStatus. 
        /// <para>
        /// The current status of a plugin. A plugin is modified asynchronously.
        /// </para>
        /// </summary>
        public PluginBuildStatus BuildStatus
        {
            get { return this._buildStatus; }
            set { this._buildStatus = value; }
        }

        // Check to see if BuildStatus property is set
        internal bool IsSetBuildStatus()
        {
            return this._buildStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp for when the plugin was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomPluginConfiguration. 
        /// <para>
        /// Configuration information required to create a custom plugin.
        /// </para>
        /// </summary>
        public CustomPluginConfiguration CustomPluginConfiguration
        {
            get { return this._customPluginConfiguration; }
            set { this._customPluginConfiguration = value; }
        }

        // Check to see if CustomPluginConfiguration property is set
        internal bool IsSetCustomPluginConfiguration()
        {
            return this._customPluginConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The name of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }

        // Check to see if DisplayName property is set
        internal bool IsSetDisplayName()
        {
            return this._displayName != null;
        }

        /// <summary>
        /// Gets and sets the property PluginArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role with permission to access resources needed
        /// to create the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1284)]
        public string PluginArn
        {
            get { return this._pluginArn; }
            set { this._pluginArn = value; }
        }

        // Check to see if PluginArn property is set
        internal bool IsSetPluginArn()
        {
            return this._pluginArn != null;
        }

        /// <summary>
        /// Gets and sets the property PluginId. 
        /// <para>
        /// The identifier of the plugin.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string PluginId
        {
            get { return this._pluginId; }
            set { this._pluginId = value; }
        }

        // Check to see if PluginId property is set
        internal bool IsSetPluginId()
        {
            return this._pluginId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerUrl. 
        /// <para>
        /// The source URL used for plugin configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ServerUrl
        {
            get { return this._serverUrl; }
            set { this._serverUrl = value; }
        }

        // Check to see if ServerUrl property is set
        internal bool IsSetServerUrl()
        {
            return this._serverUrl != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the plugin.
        /// </para>
        /// </summary>
        public PluginState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the plugin.
        /// </para>
        /// </summary>
        public PluginType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp for when the plugin was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}