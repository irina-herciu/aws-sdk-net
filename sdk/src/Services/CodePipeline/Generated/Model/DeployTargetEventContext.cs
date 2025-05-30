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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// The context for the event for the deploy action.
    /// </summary>
    public partial class DeployTargetEventContext
    {
        private string _message;
        private string _ssmCommandId;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The context message for the event for the deploy action.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property SsmCommandId. 
        /// <para>
        /// The command ID for the event for the deploy action.
        /// </para>
        /// </summary>
        public string SsmCommandId
        {
            get { return this._ssmCommandId; }
            set { this._ssmCommandId = value; }
        }

        // Check to see if SsmCommandId property is set
        internal bool IsSetSsmCommandId()
        {
            return this._ssmCommandId != null;
        }

    }
}