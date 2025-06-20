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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAutoScalingGroup operation.
    /// <b>We strongly recommend using a launch template when calling this operation to ensure
    /// full functionality for Amazon EC2 Auto Scaling and Amazon EC2.</b> 
    /// 
    ///  
    /// <para>
    /// Creates an Auto Scaling group with the specified name and attributes. 
    /// </para>
    ///  
    /// <para>
    /// If you exceed your maximum limit of Auto Scaling groups, the call fails. To query
    /// this limit, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
    /// API. For information about updating this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
    /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you're new to Amazon EC2 Auto Scaling, see the introductory tutorials in <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/get-started-with-ec2-auto-scaling.html">Get
    /// started with Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Every Auto Scaling group has three size properties (<c>DesiredCapacity</c>, <c>MaxSize</c>,
    /// and <c>MinSize</c>). Usually, you set these sizes based on a specific number of instances.
    /// However, if you configure a mixed instances policy that defines weights for the instance
    /// types, you must specify these sizes with the same units that you use for weighting
    /// instances.
    /// </para>
    /// </summary>
    public partial class CreateAutoScalingGroupRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private AvailabilityZoneDistribution _availabilityZoneDistribution;
        private AvailabilityZoneImpairmentPolicy _availabilityZoneImpairmentPolicy;
        private List<string> _availabilityZones = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _capacityRebalance;
        private CapacityReservationSpecification _capacityReservationSpecification;
        private string _context;
        private int? _defaultCooldown;
        private int? _defaultInstanceWarmup;
        private int? _desiredCapacity;
        private string _desiredCapacityType;
        private int? _healthCheckGracePeriod;
        private string _healthCheckType;
        private string _instanceId;
        private InstanceMaintenancePolicy _instanceMaintenancePolicy;
        private string _launchConfigurationName;
        private LaunchTemplateSpecification _launchTemplate;
        private List<LifecycleHookSpecification> _lifecycleHookSpecificationList = AWSConfigs.InitializeCollections ? new List<LifecycleHookSpecification>() : null;
        private List<string> _loadBalancerNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _maxInstanceLifetime;
        private int? _maxSize;
        private int? _minSize;
        private MixedInstancesPolicy _mixedInstancesPolicy;
        private bool? _newInstancesProtectedFromScaleIn;
        private string _placementGroup;
        private string _serviceLinkedRoleARN;
        private bool? _skipZonalShiftValidation;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _targetGroupARNs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _terminationPolicies = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<TrafficSourceIdentifier> _trafficSources = AWSConfigs.InitializeCollections ? new List<TrafficSourceIdentifier>() : null;
        private string _vpcZoneIdentifier;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group. This name must be unique per Region per account.
        /// </para>
        ///  
        /// <para>
        /// The name can contain any ASCII character 33 to 126 including most punctuation characters,
        /// digits, and upper and lowercased letters.
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot use a colon (:) in the name.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneDistribution. 
        /// <para>
        /// The instance capacity distribution across Availability Zones.
        /// </para>
        /// </summary>
        public AvailabilityZoneDistribution AvailabilityZoneDistribution
        {
            get { return this._availabilityZoneDistribution; }
            set { this._availabilityZoneDistribution = value; }
        }

        // Check to see if AvailabilityZoneDistribution property is set
        internal bool IsSetAvailabilityZoneDistribution()
        {
            return this._availabilityZoneDistribution != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneImpairmentPolicy. 
        /// <para>
        ///  The policy for Availability Zone impairment. 
        /// </para>
        /// </summary>
        public AvailabilityZoneImpairmentPolicy AvailabilityZoneImpairmentPolicy
        {
            get { return this._availabilityZoneImpairmentPolicy; }
            set { this._availabilityZoneImpairmentPolicy = value; }
        }

        // Check to see if AvailabilityZoneImpairmentPolicy property is set
        internal bool IsSetAvailabilityZoneImpairmentPolicy()
        {
            return this._availabilityZoneImpairmentPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// A list of Availability Zones where instances in the Auto Scaling group can be created.
        /// Used for launching into the default VPC subnet in each Availability Zone when not
        /// using the <c>VPCZoneIdentifier</c> property, or for attaching a network interface
        /// when an existing network interface ID is specified in a launch template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && (this._availabilityZones.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityRebalance. 
        /// <para>
        /// Indicates whether Capacity Rebalancing is enabled. Otherwise, Capacity Rebalancing
        /// is disabled. When you turn on Capacity Rebalancing, Amazon EC2 Auto Scaling attempts
        /// to launch a Spot Instance whenever Amazon EC2 notifies that a Spot Instance is at
        /// an elevated risk of interruption. After launching a new instance, it then terminates
        /// an old instance. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-capacity-rebalancing.html">Use
        /// Capacity Rebalancing to handle Amazon EC2 Spot Interruptions</a> in the in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool? CapacityRebalance
        {
            get { return this._capacityRebalance; }
            set { this._capacityRebalance = value; }
        }

        // Check to see if CapacityRebalance property is set
        internal bool IsSetCapacityRebalance()
        {
            return this._capacityRebalance.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        ///  The capacity reservation specification for the Auto Scaling group. 
        /// </para>
        /// </summary>
        public CapacityReservationSpecification CapacityReservationSpecification
        {
            get { return this._capacityReservationSpecification; }
            set { this._capacityReservationSpecification = value; }
        }

        // Check to see if CapacityReservationSpecification property is set
        internal bool IsSetCapacityReservationSpecification()
        {
            return this._capacityReservationSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultCooldown. 
        /// <para>
        ///  <i>Only needed if you use simple scaling policies.</i> 
        /// </para>
        ///  
        /// <para>
        /// The amount of time, in seconds, between one scaling activity ending and another one
        /// starting due to simple scaling policies. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-scaling-cooldowns.html">Scaling
        /// cooldowns for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>300</c> seconds
        /// </para>
        /// </summary>
        public int? DefaultCooldown
        {
            get { return this._defaultCooldown; }
            set { this._defaultCooldown = value; }
        }

        // Check to see if DefaultCooldown property is set
        internal bool IsSetDefaultCooldown()
        {
            return this._defaultCooldown.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultInstanceWarmup. 
        /// <para>
        /// The amount of time, in seconds, until a new instance is considered to have finished
        /// initializing and resource consumption to become stable after it enters the <c>InService</c>
        /// state. 
        /// </para>
        ///  
        /// <para>
        /// During an instance refresh, Amazon EC2 Auto Scaling waits for the warm-up period after
        /// it replaces an instance before it moves on to replacing the next instance. Amazon
        /// EC2 Auto Scaling also waits for the warm-up period before aggregating the metrics
        /// for new instances with existing instances in the Amazon CloudWatch metrics that are
        /// used for scaling, resulting in more reliable usage data. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-default-instance-warmup.html">Set
        /// the default instance warmup for an Auto Scaling group</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To manage various warm-up settings at the group level, we recommend that you set the
        /// default instance warmup, <i>even if it is set to 0 seconds</i>. To remove a value
        /// that you previously set, include the property but specify <c>-1</c> for the value.
        /// However, we strongly recommend keeping the default instance warmup enabled by specifying
        /// a value of <c>0</c> or other nominal value.
        /// </para>
        ///  </important> 
        /// <para>
        /// Default: None 
        /// </para>
        /// </summary>
        public int? DefaultInstanceWarmup
        {
            get { return this._defaultInstanceWarmup; }
            set { this._defaultInstanceWarmup = value; }
        }

        // Check to see if DefaultInstanceWarmup property is set
        internal bool IsSetDefaultInstanceWarmup()
        {
            return this._defaultInstanceWarmup.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacity. 
        /// <para>
        /// The desired capacity is the initial capacity of the Auto Scaling group at the time
        /// of its creation and the capacity it attempts to maintain. It can scale beyond this
        /// capacity if you configure auto scaling. This number must be greater than or equal
        /// to the minimum size of the group and less than or equal to the maximum size of the
        /// group. If you do not specify a desired capacity, the default is the minimum size of
        /// the group.
        /// </para>
        /// </summary>
        public int? DesiredCapacity
        {
            get { return this._desiredCapacity; }
            set { this._desiredCapacity = value; }
        }

        // Check to see if DesiredCapacity property is set
        internal bool IsSetDesiredCapacity()
        {
            return this._desiredCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DesiredCapacityType. 
        /// <para>
        /// The unit of measurement for the value specified for desired capacity. Amazon EC2 Auto
        /// Scaling supports <c>DesiredCapacityType</c> for attribute-based instance type selection
        /// only. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-mixed-instances-group-attribute-based-instance-type-selection.html">Create
        /// a mixed instances group using attribute-based instance type selection</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 Auto Scaling specifies <c>units</c>, which translates into
        /// number of instances.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>units</c> | <c>vcpu</c> | <c>memory-mib</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DesiredCapacityType
        {
            get { return this._desiredCapacityType; }
            set { this._desiredCapacityType = value; }
        }

        // Check to see if DesiredCapacityType property is set
        internal bool IsSetDesiredCapacityType()
        {
            return this._desiredCapacityType != null;
        }

        /// <summary>
        /// Gets and sets the property HealthCheckGracePeriod. 
        /// <para>
        /// The amount of time, in seconds, that Amazon EC2 Auto Scaling waits before checking
        /// the health status of an EC2 instance that has come into service and marking it unhealthy
        /// due to a failed health check. This is useful if your instances do not immediately
        /// pass their health checks after they enter the <c>InService</c> state. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/health-check-grace-period.html">Set
        /// the health check grace period for an Auto Scaling group</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>0</c> seconds
        /// </para>
        /// </summary>
        public int? HealthCheckGracePeriod
        {
            get { return this._healthCheckGracePeriod; }
            set { this._healthCheckGracePeriod = value; }
        }

        // Check to see if HealthCheckGracePeriod property is set
        internal bool IsSetHealthCheckGracePeriod()
        {
            return this._healthCheckGracePeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HealthCheckType. 
        /// <para>
        /// A comma-separated value string of one or more health check types.
        /// </para>
        ///  
        /// <para>
        /// The valid values are <c>EC2</c>, <c>EBS</c>, <c>ELB</c>, and <c>VPC_LATTICE</c>. <c>EC2</c>
        /// is the default health check and cannot be disabled. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-health-checks.html">Health
        /// checks for instances in an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Only specify <c>EC2</c> if you must clear a value that was previously set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string HealthCheckType
        {
            get { return this._healthCheckType; }
            set { this._healthCheckType = value; }
        }

        // Check to see if HealthCheckType property is set
        internal bool IsSetHealthCheckType()
        {
            return this._healthCheckType != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance used to base the launch configuration on. If specified, Amazon
        /// EC2 Auto Scaling uses the configuration values from the specified instance to create
        /// a new launch configuration. To get the instance ID, use the Amazon EC2 <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeInstances.html">DescribeInstances</a>
        /// API operation. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-asg-from-instance.html">Create
        /// an Auto Scaling group using parameters from an existing instance</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceMaintenancePolicy. 
        /// <para>
        /// An instance maintenance policy. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-maintenance-policy.html">Set
        /// instance maintenance policy</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceMaintenancePolicy InstanceMaintenancePolicy
        {
            get { return this._instanceMaintenancePolicy; }
            set { this._instanceMaintenancePolicy = value; }
        }

        // Check to see if InstanceMaintenancePolicy property is set
        internal bool IsSetInstanceMaintenancePolicy()
        {
            return this._instanceMaintenancePolicy != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration to use to launch instances. 
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either a launch template (<c>LaunchTemplate</c> or <c>MixedInstancesPolicy</c>)
        /// or a launch configuration (<c>LaunchConfigurationName</c> or <c>InstanceId</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// Information used to specify the launch template and version to use to launch instances.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Conditional: You must specify either a launch template (<c>LaunchTemplate</c> or <c>MixedInstancesPolicy</c>)
        /// or a launch configuration (<c>LaunchConfigurationName</c> or <c>InstanceId</c>).
        /// </para>
        ///  <note> 
        /// <para>
        /// The launch template that is specified must be configured for use with an Auto Scaling
        /// group. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-template.html">Create
        /// a launch template for an Auto Scaling group</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleHookSpecificationList. 
        /// <para>
        /// One or more lifecycle hooks to add to the Auto Scaling group before instances are
        /// launched.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LifecycleHookSpecification> LifecycleHookSpecificationList
        {
            get { return this._lifecycleHookSpecificationList; }
            set { this._lifecycleHookSpecificationList = value; }
        }

        // Check to see if LifecycleHookSpecificationList property is set
        internal bool IsSetLifecycleHookSpecificationList()
        {
            return this._lifecycleHookSpecificationList != null && (this._lifecycleHookSpecificationList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerNames. 
        /// <para>
        /// A list of Classic Load Balancers associated with this Auto Scaling group. For Application
        /// Load Balancers, Network Load Balancers, and Gateway Load Balancers, specify the <c>TargetGroupARNs</c>
        /// property instead.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> LoadBalancerNames
        {
            get { return this._loadBalancerNames; }
            set { this._loadBalancerNames = value; }
        }

        // Check to see if LoadBalancerNames property is set
        internal bool IsSetLoadBalancerNames()
        {
            return this._loadBalancerNames != null && (this._loadBalancerNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MaxInstanceLifetime. 
        /// <para>
        /// The maximum amount of time, in seconds, that an instance can be in service. The default
        /// is null. If specified, the value must be either 0 or a number equal to or greater
        /// than 86,400 seconds (1 day). For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-max-instance-lifetime.html">Replace
        /// Auto Scaling instances based on maximum instance lifetime</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public int? MaxInstanceLifetime
        {
            get { return this._maxInstanceLifetime; }
            set { this._maxInstanceLifetime = value; }
        }

        // Check to see if MaxInstanceLifetime property is set
        internal bool IsSetMaxInstanceLifetime()
        {
            return this._maxInstanceLifetime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxSize. 
        /// <para>
        /// The maximum size of the group.
        /// </para>
        ///  <note> 
        /// <para>
        /// With a mixed instances policy that uses instance weighting, Amazon EC2 Auto Scaling
        /// may need to go above <c>MaxSize</c> to meet your capacity requirements. In this event,
        /// Amazon EC2 Auto Scaling will never go above <c>MaxSize</c> by more than your largest
        /// instance weight (weights that define how many units each instance contributes to the
        /// desired capacity of the group).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxSize
        {
            get { return this._maxSize; }
            set { this._maxSize = value; }
        }

        // Check to see if MaxSize property is set
        internal bool IsSetMaxSize()
        {
            return this._maxSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinSize. 
        /// <para>
        /// The minimum size of the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinSize
        {
            get { return this._minSize; }
            set { this._minSize = value; }
        }

        // Check to see if MinSize property is set
        internal bool IsSetMinSize()
        {
            return this._minSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy. 
        /// <para>
        /// The mixed instances policy. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-mixed-instances-groups.html">Auto
        /// Scaling groups with multiple instance types and purchase options</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public MixedInstancesPolicy MixedInstancesPolicy
        {
            get { return this._mixedInstancesPolicy; }
            set { this._mixedInstancesPolicy = value; }
        }

        // Check to see if MixedInstancesPolicy property is set
        internal bool IsSetMixedInstancesPolicy()
        {
            return this._mixedInstancesPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property NewInstancesProtectedFromScaleIn. 
        /// <para>
        /// Indicates whether newly launched instances are protected from termination by Amazon
        /// EC2 Auto Scaling when scaling in. For more information about preventing instances
        /// from terminating on scale in, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-instance-protection.html">Use
        /// instance scale-in protection</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public bool? NewInstancesProtectedFromScaleIn
        {
            get { return this._newInstancesProtectedFromScaleIn; }
            set { this._newInstancesProtectedFromScaleIn = value; }
        }

        // Check to see if NewInstancesProtectedFromScaleIn property is set
        internal bool IsSetNewInstancesProtectedFromScaleIn()
        {
            return this._newInstancesProtectedFromScaleIn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PlacementGroup. 
        /// <para>
        /// The name of the placement group into which to launch your instances. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// groups</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A <i>cluster</i> placement group is a logical grouping of instances within a single
        /// Availability Zone. You cannot specify multiple Availability Zones and a cluster placement
        /// group. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string PlacementGroup
        {
            get { return this._placementGroup; }
            set { this._placementGroup = value; }
        }

        // Check to see if PlacementGroup property is set
        internal bool IsSetPlacementGroup()
        {
            return this._placementGroup != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceLinkedRoleARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service-linked role that the Auto Scaling group
        /// uses to call other Amazon Web Services service on your behalf. By default, Amazon
        /// EC2 Auto Scaling uses a service-linked role named <c>AWSServiceRoleForAutoScaling</c>,
        /// which it creates if it does not exist. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-service-linked-role.html">Service-linked
        /// roles</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ServiceLinkedRoleARN
        {
            get { return this._serviceLinkedRoleARN; }
            set { this._serviceLinkedRoleARN = value; }
        }

        // Check to see if ServiceLinkedRoleARN property is set
        internal bool IsSetServiceLinkedRoleARN()
        {
            return this._serviceLinkedRoleARN != null;
        }

        /// <summary>
        /// Gets and sets the property SkipZonalShiftValidation. 
        /// <para>
        ///  If you enable zonal shift with cross-zone disabled load balancers, capacity could
        /// become imbalanced across Availability Zones. To skip the validation, specify <c>true</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-zonal-shift.html">Auto
        /// Scaling group zonal shift</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. 
        /// </para>
        /// </summary>
        public bool? SkipZonalShiftValidation
        {
            get { return this._skipZonalShiftValidation; }
            set { this._skipZonalShiftValidation = value; }
        }

        // Check to see if SkipZonalShiftValidation property is set
        internal bool IsSetSkipZonalShiftValidation()
        {
            return this._skipZonalShiftValidation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags. You can tag your Auto Scaling group and propagate the tags to the
        /// Amazon EC2 instances it launches. Tags are not propagated to Amazon EBS volumes. To
        /// add tags to Amazon EBS volumes, specify the tags in a launch template but use caution.
        /// If the launch template specifies an instance tag with a key that is also specified
        /// for the Auto Scaling group, Amazon EC2 Auto Scaling overrides the value of that instance
        /// tag with the value specified by the Auto Scaling group. For more information, see
        /// <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-tagging.html">Tag
        /// Auto Scaling groups and instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetGroupARNs. 
        /// <para>
        /// The Amazon Resource Names (ARN) of the Elastic Load Balancing target groups to associate
        /// with the Auto Scaling group. Instances are registered as targets with the target groups.
        /// The target groups receive incoming traffic and route requests to one or more registered
        /// targets. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/autoscaling-load-balancer.html">Use
        /// Elastic Load Balancing to distribute traffic across the instances in your Auto Scaling
        /// group</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetGroupARNs
        {
            get { return this._targetGroupARNs; }
            set { this._targetGroupARNs = value; }
        }

        // Check to see if TargetGroupARNs property is set
        internal bool IsSetTargetGroupARNs()
        {
            return this._targetGroupARNs != null && (this._targetGroupARNs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TerminationPolicies. 
        /// <para>
        /// A policy or a list of policies that are used to select the instance to terminate.
        /// These policies are executed in the order that you list them. For more information,
        /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-termination-policies.html">Configure
        /// termination policies for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>Default</c> | <c>AllocationStrategy</c> | <c>ClosestToNextInstanceHour</c>
        /// | <c>NewestInstance</c> | <c>OldestInstance</c> | <c>OldestLaunchConfiguration</c>
        /// | <c>OldestLaunchTemplate</c> | <c>arn:aws:lambda:region:account-id:function:my-function:my-alias</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TerminationPolicies
        {
            get { return this._terminationPolicies; }
            set { this._terminationPolicies = value; }
        }

        // Check to see if TerminationPolicies property is set
        internal bool IsSetTerminationPolicies()
        {
            return this._terminationPolicies != null && (this._terminationPolicies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrafficSources. 
        /// <para>
        /// The list of traffic sources to attach to this Auto Scaling group. You can use any
        /// of the following as traffic sources for an Auto Scaling group: Classic Load Balancer,
        /// Application Load Balancer, Gateway Load Balancer, Network Load Balancer, and VPC Lattice.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TrafficSourceIdentifier> TrafficSources
        {
            get { return this._trafficSources; }
            set { this._trafficSources = value; }
        }

        // Check to see if TrafficSources property is set
        internal bool IsSetTrafficSources()
        {
            return this._trafficSources != null && (this._trafficSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VPCZoneIdentifier. 
        /// <para>
        /// A comma-separated list of subnet IDs for a virtual private cloud (VPC) where instances
        /// in the Auto Scaling group can be created. If you specify <c>VPCZoneIdentifier</c>
        /// with <c>AvailabilityZones</c>, the subnets that you specify must reside in those Availability
        /// Zones.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string VPCZoneIdentifier
        {
            get { return this._vpcZoneIdentifier; }
            set { this._vpcZoneIdentifier = value; }
        }

        // Check to see if VPCZoneIdentifier property is set
        internal bool IsSetVPCZoneIdentifier()
        {
            return this._vpcZoneIdentifier != null;
        }

    }
}