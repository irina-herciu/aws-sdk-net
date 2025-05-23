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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that controls whether access logs are written for this streaming distribution.
    /// </summary>
    public partial class StreamingLoggingConfig
    {
        private string _bucket;
        private bool? _enabled;
        private string _prefix;

        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The Amazon S3 bucket to store the access logs in, for example, <c>amzn-s3-demo-bucket.s3.amazonaws.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Bucket
        {
            get { return this._bucket; }
            set { this._bucket = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this._bucket != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether you want CloudFront to save access logs to an Amazon S3 bucket.
        /// If you don't want to enable logging when you create a streaming distribution or if
        /// you want to disable logging for an existing streaming distribution, specify <c>false</c>
        /// for <c>Enabled</c>, and specify <c>empty Bucket</c> and <c>Prefix</c> elements. If
        /// you specify <c>false</c> for <c>Enabled</c> but you specify values for <c>Bucket</c>
        /// and <c>Prefix</c>, the values are automatically deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// An optional string that you want CloudFront to prefix to the access log filenames
        /// for this streaming distribution, for example, <c>myprefix/</c>. If you want to enable
        /// logging, but you don't want to specify a prefix, you still must include an empty <c>Prefix</c>
        /// element in the <c>Logging</c> element.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Prefix
        {
            get { return this._prefix; }
            set { this._prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this._prefix != null;
        }

    }
}