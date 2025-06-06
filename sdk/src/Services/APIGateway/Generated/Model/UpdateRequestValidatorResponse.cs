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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
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
namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// A set of validation rules for incoming Method requests.
    /// </summary>
    public partial class UpdateRequestValidatorResponse : AmazonWebServiceResponse
    {
        private string _id;
        private string _name;
        private bool? _validateRequestBody;
        private bool? _validateRequestParameters;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of this RequestValidator.
        /// </para>
        /// </summary>
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
        /// The name of this RequestValidator
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ValidateRequestBody. 
        /// <para>
        /// A Boolean flag to indicate whether to validate a request body according to the configured
        /// Model schema.
        /// </para>
        /// </summary>
        public bool? ValidateRequestBody
        {
            get { return this._validateRequestBody; }
            set { this._validateRequestBody = value; }
        }

        // Check to see if ValidateRequestBody property is set
        internal bool IsSetValidateRequestBody()
        {
            return this._validateRequestBody.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidateRequestParameters. 
        /// <para>
        /// A Boolean flag to indicate whether to validate request parameters (<c>true</c>) or
        /// not (<c>false</c>).
        /// </para>
        /// </summary>
        public bool? ValidateRequestParameters
        {
            get { return this._validateRequestParameters; }
            set { this._validateRequestParameters = value; }
        }

        // Check to see if ValidateRequestParameters property is set
        internal bool IsSetValidateRequestParameters()
        {
            return this._validateRequestParameters.HasValue; 
        }

    }
}