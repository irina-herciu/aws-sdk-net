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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
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
namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// Container for the parameters to the ListStatements operation.
    /// List of SQL statements. By default, only finished statements are shown. A token is
    /// returned to page through the statement list. 
    /// 
    ///  
    /// <para>
    /// When you use identity-enhanced role sessions to list statements, you must provide
    /// either the <c>cluster-identifier</c> or <c>workgroup-name</c> parameter. This ensures
    /// that the IdC user can only access the Amazon Redshift IdC applications they are assigned.
    /// For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html">
    /// Trusted identity propagation overview</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about the Amazon Redshift Data API and CLI usage examples, see
    /// <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/data-api.html">Using the
    /// Amazon Redshift Data API</a> in the <i>Amazon Redshift Management Guide</i>. 
    /// </para>
    /// </summary>
    public partial class ListStatementsRequest : AmazonRedshiftDataAPIServiceRequest
    {
        private string _clusterIdentifier;
        private string _database;
        private int? _maxResults;
        private string _nextToken;
        private bool? _roleLevel;
        private string _statementName;
        private StatusString _status;
        private string _workgroupName;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The cluster identifier. Only statements that ran on this cluster are returned. When
        /// providing <c>ClusterIdentifier</c>, then <c>WorkgroupName</c> can't be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClusterIdentifier
        {
            get { return this._clusterIdentifier; }
            set { this._clusterIdentifier = value; }
        }

        // Check to see if ClusterIdentifier property is set
        internal bool IsSetClusterIdentifier()
        {
            return this._clusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The name of the database when listing statements run against a <c>ClusterIdentifier</c>
        /// or <c>WorkgroupName</c>. 
        /// </para>
        /// </summary>
        public string Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of SQL statements to return in the response. If more SQL statements
        /// exist than fit in one response, then <c>NextToken</c> is returned to page through
        /// the results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
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
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned NextToken value in the next NextToken parameter
        /// and retrying the command. If the NextToken field is empty, all response records have
        /// been retrieved for the request. 
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
        /// Gets and sets the property RoleLevel. 
        /// <para>
        /// A value that filters which statements to return in the response. If true, all statements
        /// run by the caller's IAM role are returned. If false, only statements run by the caller's
        /// IAM role in the current IAM session are returned. The default is true. 
        /// </para>
        /// </summary>
        public bool? RoleLevel
        {
            get { return this._roleLevel; }
            set { this._roleLevel = value; }
        }

        // Check to see if RoleLevel property is set
        internal bool IsSetRoleLevel()
        {
            return this._roleLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatementName. 
        /// <para>
        /// The name of the SQL statement specified as input to <c>BatchExecuteStatement</c> or
        /// <c>ExecuteStatement</c> to identify the query. You can list multiple statements by
        /// providing a prefix that matches the beginning of the statement name. For example,
        /// to list myStatement1, myStatement2, myStatement3, and so on, then provide the a value
        /// of <c>myStatement</c>. Data API does a case-sensitive match of SQL statement names
        /// to the prefix value you provide. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string StatementName
        {
            get { return this._statementName; }
            set { this._statementName = value; }
        }

        // Check to see if StatementName property is set
        internal bool IsSetStatementName()
        {
            return this._statementName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the SQL statement to list. Status values are defined as follows: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ABORTED - The query run was stopped by the user. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ALL - A status value that includes all query statuses. This value can be used to filter
        /// results. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED - The query run failed. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FINISHED - The query has finished running. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PICKED - The query has been chosen to be run. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STARTED - The query run has started. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SUBMITTED - The query was submitted, but not yet processed. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StatusString Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkgroupName. 
        /// <para>
        /// The serverless workgroup name or Amazon Resource Name (ARN). Only statements that
        /// ran on this workgroup are returned. When providing <c>WorkgroupName</c>, then <c>ClusterIdentifier</c>
        /// can't be specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string WorkgroupName
        {
            get { return this._workgroupName; }
            set { this._workgroupName = value; }
        }

        // Check to see if WorkgroupName property is set
        internal bool IsSetWorkgroupName()
        {
            return this._workgroupName != null;
        }

    }
}