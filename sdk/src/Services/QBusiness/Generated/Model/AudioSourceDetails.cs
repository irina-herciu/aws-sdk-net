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
    /// Details about an audio source, including its identifier, format, and time information.
    /// </summary>
    public partial class AudioSourceDetails
    {
        private AudioExtractionType _audioExtractionType;
        private long? _endTimeMilliseconds;
        private string _mediaId;
        private string _mediaMimeType;
        private long? _startTimeMilliseconds;

        /// <summary>
        /// Gets and sets the property AudioExtractionType. 
        /// <para>
        /// The type of audio extraction performed on the content.
        /// </para>
        /// </summary>
        public AudioExtractionType AudioExtractionType
        {
            get { return this._audioExtractionType; }
            set { this._audioExtractionType = value; }
        }

        // Check to see if AudioExtractionType property is set
        internal bool IsSetAudioExtractionType()
        {
            return this._audioExtractionType != null;
        }

        /// <summary>
        /// Gets and sets the property EndTimeMilliseconds. 
        /// <para>
        /// The ending timestamp in milliseconds for the relevant audio segment.
        /// </para>
        /// </summary>
        public long? EndTimeMilliseconds
        {
            get { return this._endTimeMilliseconds; }
            set { this._endTimeMilliseconds = value; }
        }

        // Check to see if EndTimeMilliseconds property is set
        internal bool IsSetEndTimeMilliseconds()
        {
            return this._endTimeMilliseconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaId. 
        /// <para>
        /// Unique identifier for the audio media file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string MediaId
        {
            get { return this._mediaId; }
            set { this._mediaId = value; }
        }

        // Check to see if MediaId property is set
        internal bool IsSetMediaId()
        {
            return this._mediaId != null;
        }

        /// <summary>
        /// Gets and sets the property MediaMimeType. 
        /// <para>
        /// The MIME type of the audio file (e.g., audio/mp3, audio/wav).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string MediaMimeType
        {
            get { return this._mediaMimeType; }
            set { this._mediaMimeType = value; }
        }

        // Check to see if MediaMimeType property is set
        internal bool IsSetMediaMimeType()
        {
            return this._mediaMimeType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimeMilliseconds. 
        /// <para>
        /// The starting timestamp in milliseconds for the relevant audio segment.
        /// </para>
        /// </summary>
        public long? StartTimeMilliseconds
        {
            get { return this._startTimeMilliseconds; }
            set { this._startTimeMilliseconds = value; }
        }

        // Check to see if StartTimeMilliseconds property is set
        internal bool IsSetStartTimeMilliseconds()
        {
            return this._startTimeMilliseconds.HasValue; 
        }

    }
}