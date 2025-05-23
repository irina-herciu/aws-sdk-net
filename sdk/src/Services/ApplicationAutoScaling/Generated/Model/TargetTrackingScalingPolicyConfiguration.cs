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
    /// Represents a target tracking scaling policy configuration to use with Application
    /// Auto Scaling.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html">Target
    /// tracking scaling policies</a> in the <i>Application Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class TargetTrackingScalingPolicyConfiguration
    {
        private CustomizedMetricSpecification _customizedMetricSpecification;
        private bool? _disableScaleIn;
        private PredefinedMetricSpecification _predefinedMetricSpecification;
        private int? _scaleInCooldown;
        private int? _scaleOutCooldown;
        private double? _targetValue;

        /// <summary>
        /// Gets and sets the property CustomizedMetricSpecification. 
        /// <para>
        /// A customized metric. You can specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public CustomizedMetricSpecification CustomizedMetricSpecification
        {
            get { return this._customizedMetricSpecification; }
            set { this._customizedMetricSpecification = value; }
        }

        // Check to see if CustomizedMetricSpecification property is set
        internal bool IsSetCustomizedMetricSpecification()
        {
            return this._customizedMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DisableScaleIn. 
        /// <para>
        /// Indicates whether scale in by the target tracking scaling policy is disabled. If the
        /// value is <c>true</c>, scale in is disabled and the target tracking scaling policy
        /// won't remove capacity from the scalable target. Otherwise, scale in is enabled and
        /// the target tracking scaling policy can remove capacity from the scalable target. The
        /// default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DisableScaleIn
        {
            get { return this._disableScaleIn; }
            set { this._disableScaleIn = value; }
        }

        // Check to see if DisableScaleIn property is set
        internal bool IsSetDisableScaleIn()
        {
            return this._disableScaleIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredefinedMetricSpecification. 
        /// <para>
        /// A predefined metric. You can specify either a predefined metric or a customized metric.
        /// </para>
        /// </summary>
        public PredefinedMetricSpecification PredefinedMetricSpecification
        {
            get { return this._predefinedMetricSpecification; }
            set { this._predefinedMetricSpecification = value; }
        }

        // Check to see if PredefinedMetricSpecification property is set
        internal bool IsSetPredefinedMetricSpecification()
        {
            return this._predefinedMetricSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ScaleInCooldown. 
        /// <para>
        /// The amount of time, in seconds, after a scale-in activity completes before another
        /// scale-in activity can start. For more information and for default values, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/target-tracking-scaling-policy-overview.html#target-tracking-cooldown">Define
        /// cooldown periods</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int? ScaleInCooldown
        {
            get { return this._scaleInCooldown; }
            set { this._scaleInCooldown = value; }
        }

        // Check to see if ScaleInCooldown property is set
        internal bool IsSetScaleInCooldown()
        {
            return this._scaleInCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScaleOutCooldown. 
        /// <para>
        /// The amount of time, in seconds, to wait for a previous scale-out activity to take
        /// effect. For more information and for default values, see <a href="https://docs.aws.amazon.com/autoscaling/application/userguide/target-tracking-scaling-policy-overview.html#target-tracking-cooldown">Define
        /// cooldown periods</a> in the <i>Application Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int? ScaleOutCooldown
        {
            get { return this._scaleOutCooldown; }
            set { this._scaleOutCooldown = value; }
        }

        // Check to see if ScaleOutCooldown property is set
        internal bool IsSetScaleOutCooldown()
        {
            return this._scaleOutCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The target value for the metric. Although this property accepts numbers of type Double,
        /// it won't accept values that are either too small or too large. Values must be in the
        /// range of -2^360 to 2^360. The value must be a valid number based on the choice of
        /// metric. For example, if the metric is CPU utilization, then the target value is a
        /// percent value that represents how much of the CPU can be used before scaling out.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If the scaling policy specifies the <c>ALBRequestCountPerTarget</c> predefined metric,
        /// specify the target utilization as the optimal average request count per target during
        /// any one-minute interval.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public double? TargetValue
        {
            get { return this._targetValue; }
            set { this._targetValue = value; }
        }

        // Check to see if TargetValue property is set
        internal bool IsSetTargetValue()
        {
            return this._targetValue.HasValue; 
        }

    }
}