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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetServiceLastAccessedDetailsWithEntities operation.
    /// After you generate a group or policy report using the <c>GenerateServiceLastAccessedDetails</c>
    /// operation, you can use the <c>JobId</c> parameter in <c>GetServiceLastAccessedDetailsWithEntities</c>.
    /// This operation retrieves the status of your report job and a list of entities that
    /// could have used group or policy permissions to access the specified service.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <b>Group</b> – For a group report, this operation returns a list of users in the
    /// group that could have used the group’s policies in an attempt to access the service.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Policy</b> – For a policy report, this operation returns a list of entities (users
    /// or roles) that could have used the policy in an attempt to access the service.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can also use this operation for user or role reports to retrieve details about
    /// those entities.
    /// </para>
    ///  
    /// <para>
    /// If the operation fails, the <c>GetServiceLastAccessedDetailsWithEntities</c> operation
    /// returns the reason that it failed.
    /// </para>
    ///  
    /// <para>
    /// By default, the list of associated entities is sorted by date, with the most recent
    /// access listed first.
    /// </para>
    /// </summary>
    public partial class GetServiceLastAccessedDetailsWithEntitiesRequest : AmazonIdentityManagementServiceRequest
    {
        private string _jobId;
        private string _marker;
        private int? _maxItems;
        private string _serviceNamespace;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the request generated by the <c>GenerateServiceLastAccessedDetails</c> operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results and only after you receive a response
        /// indicating that the results are truncated. Set it to the value of the <c>Marker</c>
        /// element in the response that you received to indicate where the next call should start.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=320)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this only when paginating results to indicate the maximum number of items you
        /// want in the response. If additional items exist beyond the maximum you specify, the
        /// <c>IsTruncated</c> response element is <c>true</c>.
        /// </para>
        ///  
        /// <para>
        /// If you do not include this parameter, the number of items defaults to 100. Note that
        /// IAM might return fewer results, even when there are more results available. In that
        /// case, the <c>IsTruncated</c> response element returns <c>true</c>, and <c>Marker</c>
        /// contains a value to include in the subsequent call that tells the service where to
        /// continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int? MaxItems
        {
            get { return this._maxItems; }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceNamespace. 
        /// <para>
        /// The service namespace for an Amazon Web Services service. Provide the service namespace
        /// to learn when the IAM entity last attempted to access the specified service.
        /// </para>
        ///  
        /// <para>
        /// To learn the service namespace for a service, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/reference_policies_actions-resources-contextkeys.html">Actions,
        /// resources, and condition keys for Amazon Web Services services</a> in the <i>IAM User
        /// Guide</i>. Choose the name of the service to view details for that service. In the
        /// first paragraph, find the service prefix. For example, <c>(service prefix: a4b)</c>.
        /// For more information about service namespaces, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces">Amazon
        /// Web Services service namespaces</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ServiceNamespace
        {
            get { return this._serviceNamespace; }
            set { this._serviceNamespace = value; }
        }

        // Check to see if ServiceNamespace property is set
        internal bool IsSetServiceNamespace()
        {
            return this._serviceNamespace != null;
        }

    }
}