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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// The CPU options for the instance.
    /// </summary>
    public partial class CpuOptions
    {
        private AmdSevSnpSpecification _amdSevSnp;
        private int? _coreCount;
        private int? _threadsPerCore;

        /// <summary>
        /// Gets and sets the property AmdSevSnp. 
        /// <para>
        /// Indicates whether the instance is enabled for AMD SEV-SNP. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/sev-snp.html">AMD SEV-SNP</a>.
        /// </para>
        /// </summary>
        public AmdSevSnpSpecification AmdSevSnp
        {
            get { return this._amdSevSnp; }
            set { this._amdSevSnp = value; }
        }

        // Check to see if AmdSevSnp property is set
        internal bool IsSetAmdSevSnp()
        {
            return this._amdSevSnp != null;
        }

        /// <summary>
        /// Gets and sets the property CoreCount. 
        /// <para>
        /// The number of CPU cores for the instance.
        /// </para>
        /// </summary>
        public int? CoreCount
        {
            get { return this._coreCount; }
            set { this._coreCount = value; }
        }

        // Check to see if CoreCount property is set
        internal bool IsSetCoreCount()
        {
            return this._coreCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThreadsPerCore. 
        /// <para>
        /// The number of threads per CPU core.
        /// </para>
        /// </summary>
        public int? ThreadsPerCore
        {
            get { return this._threadsPerCore; }
            set { this._threadsPerCore = value; }
        }

        // Check to see if ThreadsPerCore property is set
        internal bool IsSetThreadsPerCore()
        {
            return this._threadsPerCore.HasValue; 
        }

    }
}