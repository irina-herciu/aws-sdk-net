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
    /// This is the response object from the ListDataCellsFilter operation.
    /// </summary>
    public partial class ListDataCellsFilterResponse : AmazonWebServiceResponse
    {
        private List<DataCellsFilter> _dataCellsFilters = new List<DataCellsFilter>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DataCellsFilters. 
        /// <para>
        /// A list of <code>DataCellFilter</code> structures.
        /// </para>
        /// </summary>
        public List<DataCellsFilter> DataCellsFilters
        {
            get { return this._dataCellsFilters; }
            set { this._dataCellsFilters = value; }
        }

        // Check to see if DataCellsFilters property is set
        internal bool IsSetDataCellsFilters()
        {
            return this._dataCellsFilters != null && this._dataCellsFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, if not all requested data cell filters have been returned.
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

    }
}