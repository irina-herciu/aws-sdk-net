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
 * Do not modify this file. This file is generated from the supplychain-2024-01-01.normal.json service model.
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
namespace Amazon.SupplyChain.Model
{
    /// <summary>
    /// The target dataset configuration for a DATASET event type.
    /// </summary>
    public partial class DataIntegrationEventDatasetTargetConfiguration
    {
        private string _datasetIdentifier;
        private DataIntegrationEventDatasetOperationType _operationType;

        /// <summary>
        /// Gets and sets the property DatasetIdentifier. 
        /// <para>
        /// The datalake dataset ARN identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string DatasetIdentifier
        {
            get { return this._datasetIdentifier; }
            set { this._datasetIdentifier = value; }
        }

        // Check to see if DatasetIdentifier property is set
        internal bool IsSetDatasetIdentifier()
        {
            return this._datasetIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property OperationType. 
        /// <para>
        /// The target dataset load operation type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataIntegrationEventDatasetOperationType OperationType
        {
            get { return this._operationType; }
            set { this._operationType = value; }
        }

        // Check to see if OperationType property is set
        internal bool IsSetOperationType()
        {
            return this._operationType != null;
        }

    }
}