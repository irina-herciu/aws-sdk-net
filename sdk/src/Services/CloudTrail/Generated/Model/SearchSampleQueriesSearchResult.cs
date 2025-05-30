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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A search result returned by the <c>SearchSampleQueries</c> operation.
    /// </summary>
    public partial class SearchSampleQueriesSearchResult
    {
        private string _description;
        private string _name;
        private float? _relevance;
        private string _sql;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A longer description of a sample query. 
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of a sample query. 
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Relevance. 
        /// <para>
        ///  A value between 0 and 1 indicating the similarity between the search phrase and result.
        /// 
        /// </para>
        /// </summary>
        public float? Relevance
        {
            get { return this._relevance; }
            set { this._relevance = value; }
        }

        // Check to see if Relevance property is set
        internal bool IsSetRelevance()
        {
            return this._relevance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SQL. 
        /// <para>
        ///  The SQL code of the sample query. 
        /// </para>
        /// </summary>
        public string SQL
        {
            get { return this._sql; }
            set { this._sql = value; }
        }

        // Check to see if SQL property is set
        internal bool IsSetSQL()
        {
            return this._sql != null;
        }

    }
}