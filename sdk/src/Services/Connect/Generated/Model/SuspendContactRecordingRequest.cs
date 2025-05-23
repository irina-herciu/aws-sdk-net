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
    /// Container for the parameters to the SuspendContactRecording operation.
    /// When a contact is being recorded, this API suspends recording whatever is selected
    /// in the flow configuration: call (IVR or agent), screen, or both. If only call recording
    /// or only screen recording is enabled, then it would be suspended. For example, you
    /// might suspend the screen recording while collecting sensitive information, such as
    /// a credit card number. Then use <a href="https://docs.aws.amazon.com/connect/latest/APIReference/API_ResumeContactRecording.html">ResumeContactRecording</a>
    /// to restart recording the screen.
    /// 
    ///  
    /// <para>
    /// The period of time that the recording is suspended is filled with silence in the final
    /// recording. 
    /// </para>
    ///  
    /// <para>
    ///  Voice (IVR, agent) and screen recordings are supported.
    /// </para>
    /// </summary>
    public partial class SuspendContactRecordingRequest : AmazonConnectRequest
    {
        private string _contactId;
        private ContactRecordingType _contactRecordingType;
        private string _initialContactId;
        private string _instanceId;

        /// <summary>
        /// Gets and sets the property ContactId. 
        /// <para>
        /// The identifier of the contact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ContactId
        {
            get { return this._contactId; }
            set { this._contactId = value; }
        }

        // Check to see if ContactId property is set
        internal bool IsSetContactId()
        {
            return this._contactId != null;
        }

        /// <summary>
        /// Gets and sets the property ContactRecordingType. 
        /// <para>
        /// The type of recording being operated on.
        /// </para>
        /// </summary>
        public ContactRecordingType ContactRecordingType
        {
            get { return this._contactRecordingType; }
            set { this._contactRecordingType = value; }
        }

        // Check to see if ContactRecordingType property is set
        internal bool IsSetContactRecordingType()
        {
            return this._contactRecordingType != null;
        }

        /// <summary>
        /// Gets and sets the property InitialContactId. 
        /// <para>
        /// The identifier of the contact. This is the identifier of the contact associated with
        /// the first interaction with the contact center.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string InitialContactId
        {
            get { return this._initialContactId; }
            set { this._initialContactId = value; }
        }

        // Check to see if InitialContactId property is set
        internal bool IsSetInitialContactId()
        {
            return this._initialContactId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}