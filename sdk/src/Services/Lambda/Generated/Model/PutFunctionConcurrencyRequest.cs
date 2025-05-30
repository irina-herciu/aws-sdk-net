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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the PutFunctionConcurrency operation.
    /// Sets the maximum number of simultaneous executions for a function, and reserves capacity
    /// for that concurrency level.
    /// 
    ///  
    /// <para>
    /// Concurrency settings apply to the function as a whole, including all published versions
    /// and the unpublished version. Reserving concurrency both ensures that your function
    /// has capacity to process the specified number of events simultaneously, and prevents
    /// it from scaling beyond that level. Use <a>GetFunction</a> to see the current setting
    /// for a function.
    /// </para>
    ///  
    /// <para>
    /// Use <a>GetAccountSettings</a> to see your Regional concurrency limit. You can reserve
    /// concurrency for as many functions as you like, as long as you leave at least 100 simultaneous
    /// executions unreserved for functions that aren't configured with a per-function limit.
    /// For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/invocation-scaling.html">Lambda
    /// function scaling</a>.
    /// </para>
    /// </summary>
    public partial class PutFunctionConcurrencyRequest : AmazonLambdaRequest
    {
        private string _functionName;
        private int? _reservedConcurrentExecutions;

        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The name or ARN of the Lambda function.
        /// </para>
        ///  
        /// <para>
        ///  <b>Name formats</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Function name</b> – <c>my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Function ARN</b> – <c>arn:aws:lambda:us-west-2:123456789012:function:my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Partial ARN</b> – <c>123456789012:function:my-function</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=140)]
        public string FunctionName
        {
            get { return this._functionName; }
            set { this._functionName = value; }
        }

        // Check to see if FunctionName property is set
        internal bool IsSetFunctionName()
        {
            return this._functionName != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedConcurrentExecutions. 
        /// <para>
        /// The number of simultaneous executions to reserve for the function.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int? ReservedConcurrentExecutions
        {
            get { return this._reservedConcurrentExecutions; }
            set { this._reservedConcurrentExecutions = value; }
        }

        // Check to see if ReservedConcurrentExecutions property is set
        internal bool IsSetReservedConcurrentExecutions()
        {
            return this._reservedConcurrentExecutions.HasValue; 
        }

    }
}