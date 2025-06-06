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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteApplicationOutput operation.
    /// Deletes the output destination configuration from your SQL-based Kinesis Data Analytics
    /// application's configuration. Kinesis Data Analytics will no longer write data from
    /// the corresponding in-application stream to the external output destination.
    /// </summary>
    public partial class DeleteApplicationOutputRequest : AmazonKinesisAnalyticsV2Request
    {
        private string _applicationName;
        private long? _currentApplicationVersionId;
        private string _outputId;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentApplicationVersionId. 
        /// <para>
        /// The application version. You can use the <a>DescribeApplication</a> operation to get
        /// the current application version. If the version specified is not the current version,
        /// the <c>ConcurrentModificationException</c> is returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=999999999)]
        public long? CurrentApplicationVersionId
        {
            get { return this._currentApplicationVersionId; }
            set { this._currentApplicationVersionId = value; }
        }

        // Check to see if CurrentApplicationVersionId property is set
        internal bool IsSetCurrentApplicationVersionId()
        {
            return this._currentApplicationVersionId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputId. 
        /// <para>
        /// The ID of the configuration to delete. Each output configuration that is added to
        /// the application (either when the application is created or later) using the <a>AddApplicationOutput</a>
        /// operation has a unique ID. You need to provide the ID to uniquely identify the output
        /// configuration that you want to delete from the application configuration. You can
        /// use the <a>DescribeApplication</a> operation to get the specific <c>OutputId</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public string OutputId
        {
            get { return this._outputId; }
            set { this._outputId = value; }
        }

        // Check to see if OutputId property is set
        internal bool IsSetOutputId()
        {
            return this._outputId != null;
        }

    }
}