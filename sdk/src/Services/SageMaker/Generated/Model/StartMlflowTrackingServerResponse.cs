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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the StartMlflowTrackingServer operation.
    /// </summary>
    public partial class StartMlflowTrackingServerResponse : AmazonWebServiceResponse
    {
        private string _trackingServerArn;

        /// <summary>
        /// Gets and sets the property TrackingServerArn. 
        /// <para>
        /// The ARN of the started tracking server.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string TrackingServerArn
        {
            get { return this._trackingServerArn; }
            set { this._trackingServerArn = value; }
        }

        // Check to see if TrackingServerArn property is set
        internal bool IsSetTrackingServerArn()
        {
            return this._trackingServerArn != null;
        }

    }
}