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
 * Do not modify this file. This file is generated from the personalize-events-2018-03-22.normal.json service model.
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
namespace Amazon.PersonalizeEvents.Model
{
    /// <summary>
    /// Container for the parameters to the PutEvents operation.
    /// Records item interaction event data. For more information see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-item-interaction-events.html">Recording
    /// item interaction events</a>.
    /// </summary>
    public partial class PutEventsRequest : AmazonPersonalizeEventsRequest
    {
        private List<Event> _eventList = AWSConfigs.InitializeCollections ? new List<Event>() : null;
        private string _sessionId;
        private string _trackingId;
        private string _userId;

        /// <summary>
        /// Gets and sets the property EventList. 
        /// <para>
        /// A list of event data from the session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<Event> EventList
        {
            get { return this._eventList; }
            set { this._eventList = value; }
        }

        // Check to see if EventList property is set
        internal bool IsSetEventList()
        {
            return this._eventList != null && (this._eventList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SessionId. 
        /// <para>
        /// The session ID associated with the user's visit. Your application generates the sessionId
        /// when a user first visits your website or uses your application. Amazon Personalize
        /// uses the sessionId to associate events with the user before they log in. For more
        /// information, see <a href="https://docs.aws.amazon.com/personalize/latest/dg/recording-item-interaction-events.html">Recording
        /// item interaction events</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string SessionId
        {
            get { return this._sessionId; }
            set { this._sessionId = value; }
        }

        // Check to see if SessionId property is set
        internal bool IsSetSessionId()
        {
            return this._sessionId != null;
        }

        /// <summary>
        /// Gets and sets the property TrackingId. 
        /// <para>
        /// The tracking ID for the event. The ID is generated by a call to the <a href="https://docs.aws.amazon.com/personalize/latest/dg/API_CreateEventTracker.html">CreateEventTracker</a>
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string TrackingId
        {
            get { return this._trackingId; }
            set { this._trackingId = value; }
        }

        // Check to see if TrackingId property is set
        internal bool IsSetTrackingId()
        {
            return this._trackingId != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The user associated with the event.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}