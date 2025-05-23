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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that describes a premigration assessment run that you have started
    /// using the <c>StartReplicationTaskAssessmentRun</c> operation.
    /// 
    ///  
    /// <para>
    /// Some of the information appears based on other operations that can return the <c>ReplicationTaskAssessmentRun</c>
    /// object.
    /// </para>
    /// </summary>
    public partial class ReplicationTaskAssessmentRun
    {
        private ReplicationTaskAssessmentRunProgress _assessmentProgress;
        private string _assessmentRunName;
        private bool? _isLatestTaskAssessmentRun;
        private string _lastFailureMessage;
        private string _replicationTaskArn;
        private string _replicationTaskAssessmentRunArn;
        private DateTime? _replicationTaskAssessmentRunCreationDate;
        private string _resultEncryptionMode;
        private string _resultKmsKeyArn;
        private string _resultLocationBucket;
        private string _resultLocationFolder;
        private ReplicationTaskAssessmentRunResultStatistic _resultStatistic;
        private string _serviceAccessRoleArn;
        private string _status;

        /// <summary>
        /// Gets and sets the property AssessmentProgress. 
        /// <para>
        /// Indication of the completion progress for the individual assessments specified to
        /// run.
        /// </para>
        /// </summary>
        public ReplicationTaskAssessmentRunProgress AssessmentProgress
        {
            get { return this._assessmentProgress; }
            set { this._assessmentProgress = value; }
        }

        // Check to see if AssessmentProgress property is set
        internal bool IsSetAssessmentProgress()
        {
            return this._assessmentProgress != null;
        }

        /// <summary>
        /// Gets and sets the property AssessmentRunName. 
        /// <para>
        /// Unique name of the assessment run.
        /// </para>
        /// </summary>
        public string AssessmentRunName
        {
            get { return this._assessmentRunName; }
            set { this._assessmentRunName = value; }
        }

        // Check to see if AssessmentRunName property is set
        internal bool IsSetAssessmentRunName()
        {
            return this._assessmentRunName != null;
        }

        /// <summary>
        /// Gets and sets the property IsLatestTaskAssessmentRun. 
        /// <para>
        /// Indicates that the following PreflightAssessmentRun is the latest for the ReplicationTask.
        /// The status is either true or false.
        /// </para>
        /// </summary>
        public bool? IsLatestTaskAssessmentRun
        {
            get { return this._isLatestTaskAssessmentRun; }
            set { this._isLatestTaskAssessmentRun = value; }
        }

        // Check to see if IsLatestTaskAssessmentRun property is set
        internal bool IsSetIsLatestTaskAssessmentRun()
        {
            return this._isLatestTaskAssessmentRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastFailureMessage. 
        /// <para>
        /// Last message generated by an individual assessment failure.
        /// </para>
        /// </summary>
        public string LastFailureMessage
        {
            get { return this._lastFailureMessage; }
            set { this._lastFailureMessage = value; }
        }

        // Check to see if LastFailureMessage property is set
        internal bool IsSetLastFailureMessage()
        {
            return this._lastFailureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskArn. 
        /// <para>
        /// ARN of the migration task associated with this premigration assessment run.
        /// </para>
        /// </summary>
        public string ReplicationTaskArn
        {
            get { return this._replicationTaskArn; }
            set { this._replicationTaskArn = value; }
        }

        // Check to see if ReplicationTaskArn property is set
        internal bool IsSetReplicationTaskArn()
        {
            return this._replicationTaskArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskAssessmentRunArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of this assessment run.
        /// </para>
        /// </summary>
        public string ReplicationTaskAssessmentRunArn
        {
            get { return this._replicationTaskAssessmentRunArn; }
            set { this._replicationTaskAssessmentRunArn = value; }
        }

        // Check to see if ReplicationTaskAssessmentRunArn property is set
        internal bool IsSetReplicationTaskAssessmentRunArn()
        {
            return this._replicationTaskAssessmentRunArn != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationTaskAssessmentRunCreationDate. 
        /// <para>
        /// Date on which the assessment run was created using the <c>StartReplicationTaskAssessmentRun</c>
        /// operation.
        /// </para>
        /// </summary>
        public DateTime? ReplicationTaskAssessmentRunCreationDate
        {
            get { return this._replicationTaskAssessmentRunCreationDate; }
            set { this._replicationTaskAssessmentRunCreationDate = value; }
        }

        // Check to see if ReplicationTaskAssessmentRunCreationDate property is set
        internal bool IsSetReplicationTaskAssessmentRunCreationDate()
        {
            return this._replicationTaskAssessmentRunCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultEncryptionMode. 
        /// <para>
        /// Encryption mode used to encrypt the assessment run results.
        /// </para>
        /// </summary>
        public string ResultEncryptionMode
        {
            get { return this._resultEncryptionMode; }
            set { this._resultEncryptionMode = value; }
        }

        // Check to see if ResultEncryptionMode property is set
        internal bool IsSetResultEncryptionMode()
        {
            return this._resultEncryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property ResultKmsKeyArn. 
        /// <para>
        /// ARN of the KMS encryption key used to encrypt the assessment run results.
        /// </para>
        /// </summary>
        public string ResultKmsKeyArn
        {
            get { return this._resultKmsKeyArn; }
            set { this._resultKmsKeyArn = value; }
        }

        // Check to see if ResultKmsKeyArn property is set
        internal bool IsSetResultKmsKeyArn()
        {
            return this._resultKmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResultLocationBucket. 
        /// <para>
        /// Amazon S3 bucket where DMS stores the results of this assessment run.
        /// </para>
        /// </summary>
        public string ResultLocationBucket
        {
            get { return this._resultLocationBucket; }
            set { this._resultLocationBucket = value; }
        }

        // Check to see if ResultLocationBucket property is set
        internal bool IsSetResultLocationBucket()
        {
            return this._resultLocationBucket != null;
        }

        /// <summary>
        /// Gets and sets the property ResultLocationFolder. 
        /// <para>
        /// Folder in an Amazon S3 bucket where DMS stores the results of this assessment run.
        /// </para>
        /// </summary>
        public string ResultLocationFolder
        {
            get { return this._resultLocationFolder; }
            set { this._resultLocationFolder = value; }
        }

        // Check to see if ResultLocationFolder property is set
        internal bool IsSetResultLocationFolder()
        {
            return this._resultLocationFolder != null;
        }

        /// <summary>
        /// Gets and sets the property ResultStatistic. 
        /// <para>
        ///  Result statistics for a completed assessment run, showing aggregated statistics of
        /// IndividualAssessments for how many assessments were passed, failed, or encountered
        /// issues such as errors or warnings. 
        /// </para>
        /// </summary>
        public ReplicationTaskAssessmentRunResultStatistic ResultStatistic
        {
            get { return this._resultStatistic; }
            set { this._resultStatistic = value; }
        }

        // Check to see if ResultStatistic property is set
        internal bool IsSetResultStatistic()
        {
            return this._resultStatistic != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// ARN of the service role used to start the assessment run using the <c>StartReplicationTaskAssessmentRun</c>
        /// operation. The role must allow the <c>iam:PassRole</c> action.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Assessment run status. 
        /// </para>
        ///  
        /// <para>
        /// This status can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"cancelling"</c> – The assessment run was canceled by the <c>CancelReplicationTaskAssessmentRun</c>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"deleting"</c> – The assessment run was deleted by the <c>DeleteReplicationTaskAssessmentRun</c>
        /// operation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"failed"</c> – At least one individual assessment completed with a <c>failed</c>
        /// status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"error-provisioning"</c> – An internal error occurred while resources were provisioned
        /// (during <c>provisioning</c> status).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"error-executing"</c> – An internal error occurred while individual assessments
        /// ran (during <c>running</c> status).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"invalid state"</c> – The assessment run is in an unknown state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"passed"</c> – All individual assessments have completed, and none has a <c>failed</c>
        /// status.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"provisioning"</c> – Resources required to run individual assessments are being
        /// provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"running"</c> – Individual assessments are being run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"starting"</c> – The assessment run is starting, but resources are not yet being
        /// provisioned for individual assessments.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>"warning"</c> – At least one individual assessment completed with a <c>warning</c>
        /// status or all individual assessments were skipped (completed with a <c>skipped</c>
        /// status).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}