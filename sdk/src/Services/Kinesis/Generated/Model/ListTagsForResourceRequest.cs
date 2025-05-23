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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the ListTagsForResource operation.
    /// List all tags added to the specified Kinesis resource. Each tag is a label consisting
    /// of a user-defined key and value. Tags can help you manage, identify, organize, search
    /// for, and filter resources.
    /// 
    ///  
    /// <para>
    /// For more information about tagging Kinesis resources, see <a href="https://docs.aws.amazon.com/streams/latest/dev/tagging.html">Tag
    /// your Amazon Kinesis Data Streams resources</a>.
    /// </para>
    /// </summary>
    public partial class ListTagsForResourceRequest : AmazonKinesisRequest
    {
        private string _resourceARN;

        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Kinesis resource for which to list tags.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

    }
}