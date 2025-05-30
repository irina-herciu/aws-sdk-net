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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreAnalysis operation.
    /// Restores an analysis.
    /// </summary>
    public partial class RestoreAnalysisRequest : AmazonQuickSightRequest
    {
        private string _analysisId;
        private string _awsAccountId;
        private bool? _restoreToFolders;

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The ID of the analysis that you're restoring.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AnalysisId
        {
            get { return this._analysisId; }
            set { this._analysisId = value; }
        }

        // Check to see if AnalysisId property is set
        internal bool IsSetAnalysisId()
        {
            return this._analysisId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreToFolders. 
        /// <para>
        /// A boolean value that determines if the analysis will be restored to folders that it
        /// previously resided in. A <c>True</c> value restores analysis back to all folders that
        /// it previously resided in. A <c>False</c> value restores the analysis but does not
        /// restore the analysis back to all previously resided folders. Restoring a restricted
        /// analysis requires this parameter to be set to <c>True</c>.
        /// </para>
        /// </summary>
        public bool? RestoreToFolders
        {
            get { return this._restoreToFolders; }
            set { this._restoreToFolders = value; }
        }

        // Check to see if RestoreToFolders property is set
        internal bool IsSetRestoreToFolders()
        {
            return this._restoreToFolders.HasValue; 
        }

    }
}