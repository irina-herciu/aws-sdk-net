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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
namespace Amazon.Textract.Model
{
    /// <summary>
    /// Container for the parameters to the GetExpenseAnalysis operation.
    /// Gets the results for an Amazon Textract asynchronous operation that analyzes invoices
    /// and receipts. Amazon Textract finds contact information, items purchased, and vendor
    /// name, from input invoices and receipts.
    /// 
    ///  
    /// <para>
    /// You start asynchronous invoice/receipt analysis by calling <a>StartExpenseAnalysis</a>,
    /// which returns a job identifier (<c>JobId</c>). Upon completion of the invoice/receipt
    /// analysis, Amazon Textract publishes the completion status to the Amazon Simple Notification
    /// Service (Amazon SNS) topic. This topic must be registered in the initial call to <c>StartExpenseAnalysis</c>.
    /// To get the results of the invoice/receipt analysis operation, first ensure that the
    /// status value published to the Amazon SNS topic is <c>SUCCEEDED</c>. If so, call <c>GetExpenseAnalysis</c>,
    /// and pass the job identifier (<c>JobId</c>) from the initial call to <c>StartExpenseAnalysis</c>.
    /// </para>
    ///  
    /// <para>
    /// Use the MaxResults parameter to limit the number of blocks that are returned. If there
    /// are more results than specified in <c>MaxResults</c>, the value of <c>NextToken</c>
    /// in the operation response contains a pagination token for getting the next set of
    /// results. To get the next page of results, call <c>GetExpenseAnalysis</c>, and populate
    /// the <c>NextToken</c> request parameter with the token value that's returned from the
    /// previous call to <c>GetExpenseAnalysis</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/textract/latest/dg/invoices-receipts.html">Analyzing
    /// Invoices and Receipts</a>.
    /// </para>
    /// </summary>
    public partial class GetExpenseAnalysisRequest : AmazonTextractRequest
    {
        private string _jobId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// A unique identifier for the text detection job. The <c>JobId</c> is returned from
        /// <c>StartExpenseAnalysis</c>. A <c>JobId</c> value is only valid for 7 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per paginated call. The largest value you
        /// can specify is 20. If you specify a value greater than 20, a maximum of 20 results
        /// is returned. The default value is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// If the previous response was incomplete (because there are more blocks to retrieve),
        /// Amazon Textract returns a pagination token in the response. You can use this pagination
        /// token to retrieve the next set of blocks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

    }
}