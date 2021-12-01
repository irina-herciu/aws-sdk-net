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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// This is the response object from the DescribeTransaction operation.
    /// </summary>
    public partial class DescribeTransactionResponse : AmazonWebServiceResponse
    {
        private TransactionDescription _transactionDescription;

        /// <summary>
        /// Gets and sets the property TransactionDescription. 
        /// <para>
        /// Returns a <code>TransactionDescription</code> object containing information about
        /// the transaction.
        /// </para>
        /// </summary>
        public TransactionDescription TransactionDescription
        {
            get { return this._transactionDescription; }
            set { this._transactionDescription = value; }
        }

        // Check to see if TransactionDescription property is set
        internal bool IsSetTransactionDescription()
        {
            return this._transactionDescription != null;
        }

    }
}