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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the StartCommandExecution operation.
    /// </summary>
    public partial class StartCommandExecutionResponse : AmazonWebServiceResponse
    {
        private CommandExecution _commandExecution;

        /// <summary>
        /// Gets and sets the property CommandExecution. 
        /// <para>
        /// Information about the requested command executions.
        /// </para>
        /// </summary>
        public CommandExecution CommandExecution
        {
            get { return this._commandExecution; }
            set { this._commandExecution = value; }
        }

        // Check to see if CommandExecution property is set
        internal bool IsSetCommandExecution()
        {
            return this._commandExecution != null;
        }

    }
}