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
    /// Container for the parameters to the GetComplianceDetailsByConfigRule operation.
    /// Returns the evaluation results for the specified Config rule. The results indicate
    /// which Amazon Web Services resources were evaluated by the rule, when each resource
    /// was last evaluated, and whether each resource complies with the rule.
    /// </summary>
    public partial class GetComplianceDetailsByConfigRuleRequest : AmazonConfigServiceRequest
    {
        private List<string> _complianceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _configRuleName;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ComplianceTypes. 
        /// <para>
        /// Filters the results by compliance.
        /// </para>
        ///  
        /// <para>
        ///  <c>INSUFFICIENT_DATA</c> is a valid <c>ComplianceType</c> that is returned when an
        /// Config rule cannot be evaluated. However, <c>INSUFFICIENT_DATA</c> cannot be used
        /// as a <c>ComplianceType</c> for filtering results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> ComplianceTypes
        {
            get { return this._complianceTypes; }
            set { this._complianceTypes = value; }
        }

        // Check to see if ComplianceTypes property is set
        internal bool IsSetComplianceTypes()
        {
            return this._complianceTypes != null && (this._complianceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule for which you want compliance information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of evaluation results returned on each page. The default is 10.
        /// You cannot specify a number greater than 100. If you specify 0, Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
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