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

namespace Amazon.S3.Model
{
    /// <summary>
    /// <para>
    /// The destination information for the metadata table configuration. The destination table bucket
    /// must be in the same Region and Amazon Web Services account as the general purpose bucket. The specified metadata
    /// table name must be unique within the <c>aws_s3_metadata</c> namespace in the destination 
    /// table bucket.
    /// </para>
    /// </summary>
    public class S3TablesDestinationResult
    {
        private string tableBucketArn;
        private string tableArn;
        private string tableName;
        private string tableNamespace;

        /// <summary>
        /// <para>
        /// The Amazon Resource Name(ARN) for the table bucket that's specified as the
        /// destination in the metadata table configuration. The destination table bucket
        /// must be in the same Region and Amazon Web Services account as the general purpose bucket.
        /// </para>
        /// </summary>
        public string TableBucketArn
        {
            get { return this.tableBucketArn; }
            set { this.tableBucketArn = value; }
        }

        /// <summary>
        /// <para>
        /// The Amazon Resource Name(ARN) for the metadata table in the metadata table configuration.The 
        /// specified metadata table name must be unique within the <c>aws_s3_metadata</c> namespace 
        /// in the destination table bucket.
        /// </para>
        /// </summary>
        public string TableArn
        {
            get { return this.tableArn; }
            set { this.tableArn = value; }
        }

        /// <summary>
        /// <para>
        /// The name for the metadata table in your metadata table configuration.The specified metadata
        /// table name must be unique within the <c>aws_s3_metadata</c> namespace in the destination
        /// table bucket.
        /// </para>
        /// </summary>
        public string TableName
    {
        get { return this.tableName; }
        set { this.tableName = value; }
    }

        /// <summary>
        /// <para>
        /// The table bucket namespace for the metadata table in your metadata table configuration.This value 
        /// is always<c> aws_s3_metadata</c>.
        /// </para>
        /// </summary>
        public string TableNamespace
        {
            get { return this.tableNamespace; }
            set { this.tableNamespace = value; }
        }
    }
}
