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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
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
namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Summary information for a set of featured results. Featured results are placed above
    /// all other results for certain queries. If there's an exact match of a query, then
    /// one or more specific documents are featured in the search results.
    /// </summary>
    public partial class FeaturedResultsSetSummary
    {
        private long? _creationTimestamp;
        private string _featuredResultsSetId;
        private string _featuredResultsSetName;
        private long? _lastUpdatedTimestamp;
        private FeaturedResultsSetStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTimestamp. 
        /// <para>
        /// The Unix timestamp when the set of featured results was created.
        /// </para>
        /// </summary>
        public long? CreationTimestamp
        {
            get { return this._creationTimestamp; }
            set { this._creationTimestamp = value; }
        }

        // Check to see if CreationTimestamp property is set
        internal bool IsSetCreationTimestamp()
        {
            return this._creationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FeaturedResultsSetId. 
        /// <para>
        /// The identifier of the set of featured results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string FeaturedResultsSetId
        {
            get { return this._featuredResultsSetId; }
            set { this._featuredResultsSetId = value; }
        }

        // Check to see if FeaturedResultsSetId property is set
        internal bool IsSetFeaturedResultsSetId()
        {
            return this._featuredResultsSetId != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturedResultsSetName. 
        /// <para>
        /// The name for the set of featured results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string FeaturedResultsSetName
        {
            get { return this._featuredResultsSetName; }
            set { this._featuredResultsSetName = value; }
        }

        // Check to see if FeaturedResultsSetName property is set
        internal bool IsSetFeaturedResultsSetName()
        {
            return this._featuredResultsSetName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The Unix timestamp when the set of featured results was last updated.
        /// </para>
        /// </summary>
        public long? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the set of featured results. When the value is <c>ACTIVE</c>,
        /// featured results are ready for use. You can still configure your settings before setting
        /// the status to <c>ACTIVE</c>. You can set the status to <c>ACTIVE</c> or <c>INACTIVE</c>
        /// using the <a href="https://docs.aws.amazon.com/kendra/latest/dg/API_UpdateFeaturedResultsSet.html">UpdateFeaturedResultsSet</a>
        /// API. The queries you specify for featured results must be unique per featured results
        /// set for each index, whether the status is <c>ACTIVE</c> or <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        public FeaturedResultsSetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}