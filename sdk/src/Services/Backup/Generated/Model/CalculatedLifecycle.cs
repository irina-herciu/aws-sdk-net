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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// Contains <c>DeleteAt</c> and <c>MoveToColdStorageAt</c> timestamps, which are used
    /// to specify a lifecycle for a recovery point.
    /// 
    ///  
    /// <para>
    /// The lifecycle defines when a protected resource is transitioned to cold storage and
    /// when it expires. Backup transitions and expires backups automatically according to
    /// the lifecycle that you define.
    /// </para>
    ///  
    /// <para>
    /// Backups transitioned to cold storage must be stored in cold storage for a minimum
    /// of 90 days. Therefore, the “retention” setting must be 90 days greater than the “transition
    /// to cold after days” setting. The “transition to cold after days” setting cannot be
    /// changed after a backup has been transitioned to cold.
    /// </para>
    ///  
    /// <para>
    /// Resource types that can transition to cold storage are listed in the <a href="https://docs.aws.amazon.com/aws-backup/latest/devguide/backup-feature-availability.html#features-by-resource">Feature
    /// availability by resource</a> table. Backup ignores this expression for other resource
    /// types.
    /// </para>
    /// </summary>
    public partial class CalculatedLifecycle
    {
        private DateTime? _deleteAt;
        private DateTime? _moveToColdStorageAt;

        /// <summary>
        /// Gets and sets the property DeleteAt. 
        /// <para>
        /// A timestamp that specifies when to delete a recovery point.
        /// </para>
        /// </summary>
        public DateTime? DeleteAt
        {
            get { return this._deleteAt; }
            set { this._deleteAt = value; }
        }

        // Check to see if DeleteAt property is set
        internal bool IsSetDeleteAt()
        {
            return this._deleteAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MoveToColdStorageAt. 
        /// <para>
        /// A timestamp that specifies when to transition a recovery point to cold storage.
        /// </para>
        /// </summary>
        public DateTime? MoveToColdStorageAt
        {
            get { return this._moveToColdStorageAt; }
            set { this._moveToColdStorageAt = value; }
        }

        // Check to see if MoveToColdStorageAt property is set
        internal bool IsSetMoveToColdStorageAt()
        {
            return this._moveToColdStorageAt.HasValue; 
        }

    }
}