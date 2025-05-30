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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Returns details of a resource evaluation.
    /// </summary>
    public partial class ResourceEvaluation
    {
        private EvaluationMode _evaluationMode;
        private DateTime? _evaluationStartTimestamp;
        private string _resourceEvaluationId;

        /// <summary>
        /// Gets and sets the property EvaluationMode. 
        /// <para>
        /// The mode of an evaluation. The valid values are Detective or Proactive.
        /// </para>
        /// </summary>
        public EvaluationMode EvaluationMode
        {
            get { return this._evaluationMode; }
            set { this._evaluationMode = value; }
        }

        // Check to see if EvaluationMode property is set
        internal bool IsSetEvaluationMode()
        {
            return this._evaluationMode != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationStartTimestamp. 
        /// <para>
        /// The starting time of an execution.
        /// </para>
        /// </summary>
        public DateTime? EvaluationStartTimestamp
        {
            get { return this._evaluationStartTimestamp; }
            set { this._evaluationStartTimestamp = value; }
        }

        // Check to see if EvaluationStartTimestamp property is set
        internal bool IsSetEvaluationStartTimestamp()
        {
            return this._evaluationStartTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceEvaluationId. 
        /// <para>
        /// The ResourceEvaluationId of a evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ResourceEvaluationId
        {
            get { return this._resourceEvaluationId; }
            set { this._resourceEvaluationId = value; }
        }

        // Check to see if ResourceEvaluationId property is set
        internal bool IsSetResourceEvaluationId()
        {
            return this._resourceEvaluationId != null;
        }

    }
}