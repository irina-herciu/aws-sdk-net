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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Defines the high-level patch compliance state for a managed node, providing information
    /// about the number of installed, missing, not applicable, and failed patches along with
    /// metadata about the operation when this information was gathered for the managed node.
    /// </summary>
    public partial class InstancePatchState
    {
        private int? _availableSecurityUpdateCount;
        private string _baselineId;
        private int? _criticalNonCompliantCount;
        private int? _failedCount;
        private int? _installedCount;
        private int? _installedOtherCount;
        private int? _installedPendingRebootCount;
        private int? _installedRejectedCount;
        private string _installOverrideList;
        private string _instanceId;
        private DateTime? _lastNoRebootInstallOperationTime;
        private int? _missingCount;
        private int? _notApplicableCount;
        private PatchOperationType _operation;
        private DateTime? _operationEndTime;
        private DateTime? _operationStartTime;
        private int? _otherNonCompliantCount;
        private string _ownerInformation;
        private string _patchGroup;
        private RebootOption _rebootOption;
        private int? _securityNonCompliantCount;
        private string _snapshotId;
        private int? _unreportedNotApplicableCount;

        /// <summary>
        /// Gets and sets the property AvailableSecurityUpdateCount. 
        /// <para>
        /// The number of security-related patches that are available but not approved because
        /// they didn't meet the patch baseline requirements. For example, an updated version
        /// of a patch might have been released before the specified auto-approval period was
        /// over.
        /// </para>
        ///  
        /// <para>
        /// Applies to Windows Server managed nodes only.
        /// </para>
        /// </summary>
        public int? AvailableSecurityUpdateCount
        {
            get { return this._availableSecurityUpdateCount; }
            set { this._availableSecurityUpdateCount = value; }
        }

        // Check to see if AvailableSecurityUpdateCount property is set
        internal bool IsSetAvailableSecurityUpdateCount()
        {
            return this._availableSecurityUpdateCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BaselineId. 
        /// <para>
        /// The ID of the patch baseline used to patch the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=128)]
        public string BaselineId
        {
            get { return this._baselineId; }
            set { this._baselineId = value; }
        }

        // Check to see if BaselineId property is set
        internal bool IsSetBaselineId()
        {
            return this._baselineId != null;
        }

        /// <summary>
        /// Gets and sets the property CriticalNonCompliantCount. 
        /// <para>
        /// The number of patches per node that are specified as <c>Critical</c> for compliance
        /// reporting in the patch baseline aren't installed. These patches might be missing,
        /// have failed installation, were rejected, or were installed but awaiting a required
        /// managed node reboot. The status of these managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? CriticalNonCompliantCount
        {
            get { return this._criticalNonCompliantCount; }
            set { this._criticalNonCompliantCount = value; }
        }

        // Check to see if CriticalNonCompliantCount property is set
        internal bool IsSetCriticalNonCompliantCount()
        {
            return this._criticalNonCompliantCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedCount. 
        /// <para>
        /// The number of patches from the patch baseline that were attempted to be installed
        /// during the last patching operation, but failed to install.
        /// </para>
        /// </summary>
        public int? FailedCount
        {
            get { return this._failedCount; }
            set { this._failedCount = value; }
        }

        // Check to see if FailedCount property is set
        internal bool IsSetFailedCount()
        {
            return this._failedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledCount. 
        /// <para>
        /// The number of patches from the patch baseline that are installed on the managed node.
        /// </para>
        /// </summary>
        public int? InstalledCount
        {
            get { return this._installedCount; }
            set { this._installedCount = value; }
        }

        // Check to see if InstalledCount property is set
        internal bool IsSetInstalledCount()
        {
            return this._installedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledOtherCount. 
        /// <para>
        /// The number of patches not specified in the patch baseline that are installed on the
        /// managed node.
        /// </para>
        /// </summary>
        public int? InstalledOtherCount
        {
            get { return this._installedOtherCount; }
            set { this._installedOtherCount = value; }
        }

        // Check to see if InstalledOtherCount property is set
        internal bool IsSetInstalledOtherCount()
        {
            return this._installedOtherCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledPendingRebootCount. 
        /// <para>
        /// The number of patches installed by Patch Manager since the last time the managed node
        /// was rebooted.
        /// </para>
        /// </summary>
        public int? InstalledPendingRebootCount
        {
            get { return this._installedPendingRebootCount; }
            set { this._installedPendingRebootCount = value; }
        }

        // Check to see if InstalledPendingRebootCount property is set
        internal bool IsSetInstalledPendingRebootCount()
        {
            return this._installedPendingRebootCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstalledRejectedCount. 
        /// <para>
        /// The number of patches installed on a managed node that are specified in a <c>RejectedPatches</c>
        /// list. Patches with a status of <c>InstalledRejected</c> were typically installed before
        /// they were added to a <c>RejectedPatches</c> list.
        /// </para>
        ///  <note> 
        /// <para>
        /// If <c>ALLOW_AS_DEPENDENCY</c> is the specified option for <c>RejectedPatchesAction</c>,
        /// the value of <c>InstalledRejectedCount</c> will always be <c>0</c> (zero).
        /// </para>
        ///  </note>
        /// </summary>
        public int? InstalledRejectedCount
        {
            get { return this._installedRejectedCount; }
            set { this._installedRejectedCount = value; }
        }

        // Check to see if InstalledRejectedCount property is set
        internal bool IsSetInstalledRejectedCount()
        {
            return this._installedRejectedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstallOverrideList. 
        /// <para>
        /// An https URL or an Amazon Simple Storage Service (Amazon S3) path-style URL to a list
        /// of patches to be installed. This patch installation list, which you maintain in an
        /// S3 bucket in YAML format and specify in the SSM document <c>AWS-RunPatchBaseline</c>,
        /// overrides the patches specified by the default patch baseline.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>InstallOverrideList</c> parameter, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/patch-manager-about-aws-runpatchbaseline.html">SSM
        /// Command document for patching: <c>AWS-RunPatchBaseline</c> </a> in the <i>Amazon Web
        /// Services Systems Manager User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string InstallOverrideList
        {
            get { return this._installOverrideList; }
            set { this._installOverrideList = value; }
        }

        // Check to see if InstallOverrideList property is set
        internal bool IsSetInstallOverrideList()
        {
            return this._installOverrideList != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the managed node the high-level patch compliance information was collected
        /// for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property LastNoRebootInstallOperationTime. 
        /// <para>
        /// The time of the last attempt to patch the managed node with <c>NoReboot</c> specified
        /// as the reboot option.
        /// </para>
        /// </summary>
        public DateTime? LastNoRebootInstallOperationTime
        {
            get { return this._lastNoRebootInstallOperationTime; }
            set { this._lastNoRebootInstallOperationTime = value; }
        }

        // Check to see if LastNoRebootInstallOperationTime property is set
        internal bool IsSetLastNoRebootInstallOperationTime()
        {
            return this._lastNoRebootInstallOperationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MissingCount. 
        /// <para>
        /// The number of patches from the patch baseline that are applicable for the managed
        /// node but aren't currently installed.
        /// </para>
        /// </summary>
        public int? MissingCount
        {
            get { return this._missingCount; }
            set { this._missingCount = value; }
        }

        // Check to see if MissingCount property is set
        internal bool IsSetMissingCount()
        {
            return this._missingCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotApplicableCount. 
        /// <para>
        /// The number of patches from the patch baseline that aren't applicable for the managed
        /// node and therefore aren't installed on the node. This number may be truncated if the
        /// list of patch names is very large. The number of patches beyond this limit are reported
        /// in <c>UnreportedNotApplicableCount</c>.
        /// </para>
        /// </summary>
        public int? NotApplicableCount
        {
            get { return this._notApplicableCount; }
            set { this._notApplicableCount = value; }
        }

        // Check to see if NotApplicableCount property is set
        internal bool IsSetNotApplicableCount()
        {
            return this._notApplicableCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Operation. 
        /// <para>
        /// The type of patching operation that was performed: or 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SCAN</c> assesses the patch compliance state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTALL</c> installs missing patches.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public PatchOperationType Operation
        {
            get { return this._operation; }
            set { this._operation = value; }
        }

        // Check to see if Operation property is set
        internal bool IsSetOperation()
        {
            return this._operation != null;
        }

        /// <summary>
        /// Gets and sets the property OperationEndTime. 
        /// <para>
        /// The time the most recent patching operation completed on the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? OperationEndTime
        {
            get { return this._operationEndTime; }
            set { this._operationEndTime = value; }
        }

        // Check to see if OperationEndTime property is set
        internal bool IsSetOperationEndTime()
        {
            return this._operationEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OperationStartTime. 
        /// <para>
        /// The time the most recent patching operation was started on the managed node.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? OperationStartTime
        {
            get { return this._operationStartTime; }
            set { this._operationStartTime = value; }
        }

        // Check to see if OperationStartTime property is set
        internal bool IsSetOperationStartTime()
        {
            return this._operationStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OtherNonCompliantCount. 
        /// <para>
        /// The number of patches per node that are specified as other than <c>Critical</c> or
        /// <c>Security</c> but aren't compliant with the patch baseline. The status of these
        /// managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? OtherNonCompliantCount
        {
            get { return this._otherNonCompliantCount; }
            set { this._otherNonCompliantCount = value; }
        }

        // Check to see if OtherNonCompliantCount property is set
        internal bool IsSetOtherNonCompliantCount()
        {
            return this._otherNonCompliantCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerInformation. 
        /// <para>
        /// Placeholder information. This field will always be empty in the current release of
        /// the service.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
        public string OwnerInformation
        {
            get { return this._ownerInformation; }
            set { this._ownerInformation = value; }
        }

        // Check to see if OwnerInformation property is set
        internal bool IsSetOwnerInformation()
        {
            return this._ownerInformation != null;
        }

        /// <summary>
        /// Gets and sets the property PatchGroup. 
        /// <para>
        /// The name of the patch group the managed node belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string PatchGroup
        {
            get { return this._patchGroup; }
            set { this._patchGroup = value; }
        }

        // Check to see if PatchGroup property is set
        internal bool IsSetPatchGroup()
        {
            return this._patchGroup != null;
        }

        /// <summary>
        /// Gets and sets the property RebootOption. 
        /// <para>
        /// Indicates the reboot option specified in the patch baseline.
        /// </para>
        ///  <note> 
        /// <para>
        /// Reboot options apply to <c>Install</c> operations only. Reboots aren't attempted for
        /// Patch Manager <c>Scan</c> operations.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <c>RebootIfNeeded</c>: Patch Manager tries to reboot the managed node if it installed
        /// any patches, or if any patches are detected with a status of <c>InstalledPendingReboot</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NoReboot</c>: Patch Manager attempts to install missing packages without trying
        /// to reboot the system. Patches installed with this option are assigned a status of
        /// <c>InstalledPendingReboot</c>. These patches might not be in effect until a reboot
        /// is performed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RebootOption RebootOption
        {
            get { return this._rebootOption; }
            set { this._rebootOption = value; }
        }

        // Check to see if RebootOption property is set
        internal bool IsSetRebootOption()
        {
            return this._rebootOption != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityNonCompliantCount. 
        /// <para>
        /// The number of patches per node that are specified as <c>Security</c> in a patch advisory
        /// aren't installed. These patches might be missing, have failed installation, were rejected,
        /// or were installed but awaiting a required managed node reboot. The status of these
        /// managed nodes is <c>NON_COMPLIANT</c>.
        /// </para>
        /// </summary>
        public int? SecurityNonCompliantCount
        {
            get { return this._securityNonCompliantCount; }
            set { this._securityNonCompliantCount = value; }
        }

        // Check to see if SecurityNonCompliantCount property is set
        internal bool IsSetSecurityNonCompliantCount()
        {
            return this._securityNonCompliantCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the patch baseline snapshot used during the patching operation when this
        /// compliance data was collected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property UnreportedNotApplicableCount. 
        /// <para>
        /// The number of patches beyond the supported limit of <c>NotApplicableCount</c> that
        /// aren't reported by name to Inventory. Inventory is a tool in Amazon Web Services Systems
        /// Manager.
        /// </para>
        /// </summary>
        public int? UnreportedNotApplicableCount
        {
            get { return this._unreportedNotApplicableCount; }
            set { this._unreportedNotApplicableCount = value; }
        }

        // Check to see if UnreportedNotApplicableCount property is set
        internal bool IsSetUnreportedNotApplicableCount()
        {
            return this._unreportedNotApplicableCount.HasValue; 
        }

    }
}