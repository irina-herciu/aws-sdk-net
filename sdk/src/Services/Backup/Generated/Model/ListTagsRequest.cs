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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Container for the parameters to the ListTags operation.
    /// Returns the tags assigned to the resource, such as a target recovery point, backup
    /// plan, or backup vault.
    /// 
    ///  
    /// <para>
    /// This operation returns results depending on the resource type used in the value for
    /// <c>resourceArn</c>. For example, recovery points of Amazon DynamoDB with Advanced
    /// Settings have an ARN (Amazon Resource Name) that begins with <c>arn:aws:backup</c>.
    /// Recovery points (backups) of DynamoDB without Advanced Settings enabled have an ARN
    /// that begins with <c>arn:aws:dynamodb</c>.
    /// </para>
    ///  
    /// <para>
    /// When this operation is called and when you include values of <c>resourceArn</c> that
    /// have an ARN other than <c>arn:aws:backup</c>, it may return one of the exceptions
    /// listed below. To prevent this exception, include only values representing resource
    /// types that are fully managed by Backup. These have an ARN that begins <c>arn:aws:backup</c>
    /// and they are noted in the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
    /// availability by resource</a> table.
    /// </para>
    /// </summary>
    public partial class ListTagsRequest : AmazonBackupRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to be returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next item following a partial list of returned items. For example, if a request
        /// is made to return <c>MaxResults</c> number of items, <c>NextToken</c> allows you to
        /// return more items in your list starting at the location pointed to by the next token.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a resource. The format of the
        /// ARN depends on the type of resource. Valid targets for <c>ListTags</c> are recovery
        /// points, backup plans, and backup vaults.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}