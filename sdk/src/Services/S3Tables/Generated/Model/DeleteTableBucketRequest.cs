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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteTableBucket operation.
    /// Deletes a table bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-tables-buckets-delete.html">Deleting
    /// a table bucket</a> in the <i>Amazon Simple Storage Service User Guide</i>.
    /// 
    ///  <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have the <c>s3tables:DeleteTableBucket</c> permission to use this operation.
    /// 
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial class DeleteTableBucketRequest : AmazonS3TablesRequest
    {
        private string _tableBucketARN;

        /// <summary>
        /// Gets and sets the property TableBucketARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the table bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableBucketARN
        {
            get { return this._tableBucketARN; }
            set { this._tableBucketARN = value; }
        }

        // Check to see if TableBucketARN property is set
        internal bool IsSetTableBucketARN()
        {
            return this._tableBucketARN != null;
        }

    }
}