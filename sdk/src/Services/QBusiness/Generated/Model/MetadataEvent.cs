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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.QBusiness.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// A metadata event for a AI-generated text output message in a Amazon Q Business conversation,
    /// containing associated metadata generated.
    /// </summary>
    public partial class MetadataEvent
        : IEventStreamEvent
    {
        private string _conversationId;
        private string _finalTextMessage;
        private List<SourceAttribution> _sourceAttributions = AWSConfigs.InitializeCollections ? new List<SourceAttribution>() : null;
        private string _systemMessageId;
        private string _userMessageId;

        /// <summary>
        /// Gets and sets the property ConversationId. 
        /// <para>
        /// The identifier of the conversation with which the generated metadata is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string ConversationId
        {
            get { return this._conversationId; }
            set { this._conversationId = value; }
        }

        // Check to see if ConversationId property is set
        internal bool IsSetConversationId()
        {
            return this._conversationId != null;
        }

        /// <summary>
        /// Gets and sets the property FinalTextMessage. 
        /// <para>
        /// The final text output message generated by the system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string FinalTextMessage
        {
            get { return this._finalTextMessage; }
            set { this._finalTextMessage = value; }
        }

        // Check to see if FinalTextMessage property is set
        internal bool IsSetFinalTextMessage()
        {
            return this._finalTextMessage != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAttributions. 
        /// <para>
        /// The source documents used to generate the conversation response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceAttribution> SourceAttributions
        {
            get { return this._sourceAttributions; }
            set { this._sourceAttributions = value; }
        }

        // Check to see if SourceAttributions property is set
        internal bool IsSetSourceAttributions()
        {
            return this._sourceAttributions != null && (this._sourceAttributions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SystemMessageId. 
        /// <para>
        /// The identifier of an Amazon Q Business AI generated message within the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SystemMessageId
        {
            get { return this._systemMessageId; }
            set { this._systemMessageId = value; }
        }

        // Check to see if SystemMessageId property is set
        internal bool IsSetSystemMessageId()
        {
            return this._systemMessageId != null;
        }

        /// <summary>
        /// Gets and sets the property UserMessageId. 
        /// <para>
        /// The identifier of an Amazon Q Business end user text input message within the conversation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string UserMessageId
        {
            get { return this._userMessageId; }
            set { this._userMessageId = value; }
        }

        // Check to see if UserMessageId property is set
        internal bool IsSetUserMessageId()
        {
            return this._userMessageId != null;
        }

    }
}