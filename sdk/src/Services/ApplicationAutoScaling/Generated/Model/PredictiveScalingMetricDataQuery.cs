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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
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
namespace Amazon.ApplicationAutoScaling.Model
{
    /// <summary>
    /// The metric data to return. Also defines whether this call is returning data for one
    /// metric only, or whether it is performing a math expression on the values of returned
    /// metric statistics to create a new time series. A time series is a series of data points,
    /// each of which is associated with a timestamp.
    /// </summary>
    public partial class PredictiveScalingMetricDataQuery
    {
        private string _expression;
        private string _id;
        private string _label;
        private PredictiveScalingMetricStat _metricStat;
        private bool? _returnData;

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        ///  The math expression to perform on the returned data, if this object is performing
        /// a math expression. This expression can use the <c>Id</c> of the other metrics to refer
        /// to those metrics, and can also use the <c>Id</c> of other expressions to use the result
        /// of those expressions. 
        /// </para>
        ///  
        /// <para>
        /// Conditional: Within each <c>MetricDataQuery</c> object, you must specify either <c>Expression</c>
        /// or <c>MetricStat</c>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  A short name that identifies the object's results in the response. This name must
        /// be unique among all <c>MetricDataQuery</c> objects specified for a single scaling
        /// policy. If you are performing math expressions on this set of data, this name represents
        /// that data and can serve as a variable in the mathematical expression. The valid characters
        /// are letters, numbers, and underscores. The first character must be a lowercase letter.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  A human-readable label for this metric or expression. This is especially useful if
        /// this is a math expression, so that you know what the value represents. 
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property MetricStat. 
        /// <para>
        ///  Information about the metric data to return. 
        /// </para>
        ///  
        /// <para>
        /// Conditional: Within each <c>MetricDataQuery</c> object, you must specify either <c>Expression</c>
        /// or <c>MetricStat</c>, but not both.
        /// </para>
        /// </summary>
        public PredictiveScalingMetricStat MetricStat
        {
            get { return this._metricStat; }
            set { this._metricStat = value; }
        }

        // Check to see if MetricStat property is set
        internal bool IsSetMetricStat()
        {
            return this._metricStat != null;
        }

        /// <summary>
        /// Gets and sets the property ReturnData. 
        /// <para>
        ///  Indicates whether to return the timestamps and raw data values of this metric. 
        /// </para>
        ///  
        /// <para>
        /// If you use any math expressions, specify <c>true</c> for this value for only the final
        /// math expression that the metric specification is based on. You must specify <c>false</c>
        /// for <c>ReturnData</c> for all the other metrics and expressions used in the metric
        /// specification.
        /// </para>
        ///  
        /// <para>
        /// If you are only retrieving metrics and not performing any math expressions, do not
        /// specify anything for <c>ReturnData</c>. This sets it to its default (<c>true</c>).
        /// </para>
        /// </summary>
        public bool? ReturnData
        {
            get { return this._returnData; }
            set { this._returnData = value; }
        }

        // Check to see if ReturnData property is set
        internal bool IsSetReturnData()
        {
            return this._returnData.HasValue; 
        }

    }
}