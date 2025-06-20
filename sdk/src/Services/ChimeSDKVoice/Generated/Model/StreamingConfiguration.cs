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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
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
namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// The streaming configuration associated with an Amazon Chime SDK Voice Connector. Specifies
    /// whether media streaming is enabled for sending to Amazon Kinesis, and shows the retention
    /// period for the Amazon Kinesis data, in hours.
    /// </summary>
    public partial class StreamingConfiguration
    {
        private int? _dataRetentionInHours;
        private bool? _disabled;
        private MediaInsightsConfiguration _mediaInsightsConfiguration;
        private List<StreamingNotificationTarget> _streamingNotificationTargets = AWSConfigs.InitializeCollections ? new List<StreamingNotificationTarget>() : null;

        /// <summary>
        /// Gets and sets the property DataRetentionInHours. 
        /// <para>
        /// The amount of time, in hours, to the Kinesis data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? DataRetentionInHours
        {
            get { return this._dataRetentionInHours; }
            set { this._dataRetentionInHours = value; }
        }

        // Check to see if DataRetentionInHours property is set
        internal bool IsSetDataRetentionInHours()
        {
            return this._dataRetentionInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Disabled. 
        /// <para>
        /// When true, streaming to Kinesis is off.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Disabled
        {
            get { return this._disabled; }
            set { this._disabled = value; }
        }

        // Check to see if Disabled property is set
        internal bool IsSetDisabled()
        {
            return this._disabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MediaInsightsConfiguration. 
        /// <para>
        /// The call analytics configuration.
        /// </para>
        /// </summary>
        public MediaInsightsConfiguration MediaInsightsConfiguration
        {
            get { return this._mediaInsightsConfiguration; }
            set { this._mediaInsightsConfiguration = value; }
        }

        // Check to see if MediaInsightsConfiguration property is set
        internal bool IsSetMediaInsightsConfiguration()
        {
            return this._mediaInsightsConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingNotificationTargets. 
        /// <para>
        /// The streaming notification targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=3)]
        public List<StreamingNotificationTarget> StreamingNotificationTargets
        {
            get { return this._streamingNotificationTargets; }
            set { this._streamingNotificationTargets = value; }
        }

        // Check to see if StreamingNotificationTargets property is set
        internal bool IsSetStreamingNotificationTargets()
        {
            return this._streamingNotificationTargets != null && (this._streamingNotificationTargets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}