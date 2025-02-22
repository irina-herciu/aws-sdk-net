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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains summary information about a flow.
    /// 
    ///  
    /// <para>
    /// You can also create and update flows using the <a href="https://docs.aws.amazon.com/connect/latest/APIReference/flow-language.html">Amazon
    /// Connect Flow language</a>.
    /// </para>
    /// </summary>
    public partial class ContactFlowSummary
    {
        private string _arn;
        private ContactFlowState _contactFlowState;
        private ContactFlowStatus _contactFlowStatus;
        private ContactFlowType _contactFlowType;
        private string _id;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowState. 
        /// <para>
        /// The type of flow.
        /// </para>
        /// </summary>
        public ContactFlowState ContactFlowState
        {
            get { return this._contactFlowState; }
            set { this._contactFlowState = value; }
        }

        // Check to see if ContactFlowState property is set
        internal bool IsSetContactFlowState()
        {
            return this._contactFlowState != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowStatus. 
        /// <para>
        /// The status of the flow.
        /// </para>
        /// </summary>
        public ContactFlowStatus ContactFlowStatus
        {
            get { return this._contactFlowStatus; }
            set { this._contactFlowStatus = value; }
        }

        // Check to see if ContactFlowStatus property is set
        internal bool IsSetContactFlowStatus()
        {
            return this._contactFlowStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ContactFlowType. 
        /// <para>
        /// The type of flow.
        /// </para>
        /// </summary>
        public ContactFlowType ContactFlowType
        {
            get { return this._contactFlowType; }
            set { this._contactFlowType = value; }
        }

        // Check to see if ContactFlowType property is set
        internal bool IsSetContactFlowType()
        {
            return this._contactFlowType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Max=500)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the flow.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}