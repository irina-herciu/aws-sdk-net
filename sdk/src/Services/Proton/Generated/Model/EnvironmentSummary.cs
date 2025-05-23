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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// Summary data of an Proton environment resource. An Proton environment is a set of
    /// resources shared across Proton services.
    /// </summary>
    public partial class EnvironmentSummary
    {
        private string _arn;
        private string _componentRoleArn;
        private DateTime? _createdAt;
        private DeploymentStatus _deploymentStatus;
        private string _deploymentStatusMessage;
        private string _description;
        private string _environmentAccountConnectionId;
        private string _environmentAccountId;
        private string _lastAttemptedDeploymentId;
        private DateTime? _lastDeploymentAttemptedAt;
        private DateTime? _lastDeploymentSucceededAt;
        private string _lastSucceededDeploymentId;
        private string _name;
        private string _protonServiceRoleArn;
        private Provisioning _provisioning;
        private string _templateMajorVersion;
        private string _templateMinorVersion;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ComponentRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role that Proton uses when provisioning
        /// directly defined components in this environment. It determines the scope of infrastructure
        /// that a component can provision.
        /// </para>
        ///  
        /// <para>
        /// The environment must have a <c>componentRoleArn</c> to allow directly defined components
        /// to be associated with the environment.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ComponentRoleArn
        {
            get { return this._componentRoleArn; }
            set { this._componentRoleArn = value; }
        }

        // Check to see if ComponentRoleArn property is set
        internal bool IsSetComponentRoleArn()
        {
            return this._componentRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time when the environment was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// The environment deployment status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeploymentStatus DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatusMessage. 
        /// <para>
        /// An environment deployment status message.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string DeploymentStatusMessage
        {
            get { return this._deploymentStatusMessage; }
            set { this._deploymentStatusMessage = value; }
        }

        // Check to see if DeploymentStatusMessage property is set
        internal bool IsSetDeploymentStatusMessage()
        {
            return this._deploymentStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentAccountConnectionId. 
        /// <para>
        /// The ID of the environment account connection that the environment is associated with.
        /// </para>
        /// </summary>
        public string EnvironmentAccountConnectionId
        {
            get { return this._environmentAccountConnectionId; }
            set { this._environmentAccountConnectionId = value; }
        }

        // Check to see if EnvironmentAccountConnectionId property is set
        internal bool IsSetEnvironmentAccountConnectionId()
        {
            return this._environmentAccountConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentAccountId. 
        /// <para>
        /// The ID of the environment account that the environment infrastructure resources are
        /// provisioned in.
        /// </para>
        /// </summary>
        public string EnvironmentAccountId
        {
            get { return this._environmentAccountId; }
            set { this._environmentAccountId = value; }
        }

        // Check to see if EnvironmentAccountId property is set
        internal bool IsSetEnvironmentAccountId()
        {
            return this._environmentAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property LastAttemptedDeploymentId. 
        /// <para>
        /// The ID of the last attempted deployment of this environment.
        /// </para>
        /// </summary>
        public string LastAttemptedDeploymentId
        {
            get { return this._lastAttemptedDeploymentId; }
            set { this._lastAttemptedDeploymentId = value; }
        }

        // Check to see if LastAttemptedDeploymentId property is set
        internal bool IsSetLastAttemptedDeploymentId()
        {
            return this._lastAttemptedDeploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentAttemptedAt. 
        /// <para>
        /// The time when a deployment of the environment was last attempted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastDeploymentAttemptedAt
        {
            get { return this._lastDeploymentAttemptedAt; }
            set { this._lastDeploymentAttemptedAt = value; }
        }

        // Check to see if LastDeploymentAttemptedAt property is set
        internal bool IsSetLastDeploymentAttemptedAt()
        {
            return this._lastDeploymentAttemptedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastDeploymentSucceededAt. 
        /// <para>
        /// The time when the environment was last deployed successfully.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastDeploymentSucceededAt
        {
            get { return this._lastDeploymentSucceededAt; }
            set { this._lastDeploymentSucceededAt = value; }
        }

        // Check to see if LastDeploymentSucceededAt property is set
        internal bool IsSetLastDeploymentSucceededAt()
        {
            return this._lastDeploymentSucceededAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSucceededDeploymentId. 
        /// <para>
        /// The ID of the last successful deployment of this environment.
        /// </para>
        /// </summary>
        public string LastSucceededDeploymentId
        {
            get { return this._lastSucceededDeploymentId; }
            set { this._lastSucceededDeploymentId = value; }
        }

        // Check to see if LastSucceededDeploymentId property is set
        internal bool IsSetLastSucceededDeploymentId()
        {
            return this._lastSucceededDeploymentId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property ProtonServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Proton service role that allows Proton to make
        /// calls to other services on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ProtonServiceRoleArn
        {
            get { return this._protonServiceRoleArn; }
            set { this._protonServiceRoleArn = value; }
        }

        // Check to see if ProtonServiceRoleArn property is set
        internal bool IsSetProtonServiceRoleArn()
        {
            return this._protonServiceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Provisioning. 
        /// <para>
        /// When included, indicates that the environment template is for customer provisioned
        /// and managed infrastructure.
        /// </para>
        /// </summary>
        public Provisioning Provisioning
        {
            get { return this._provisioning; }
            set { this._provisioning = value; }
        }

        // Check to see if Provisioning property is set
        internal bool IsSetProvisioning()
        {
            return this._provisioning != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the environment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TemplateMajorVersion
        {
            get { return this._templateMajorVersion; }
            set { this._templateMajorVersion = value; }
        }

        // Check to see if TemplateMajorVersion property is set
        internal bool IsSetTemplateMajorVersion()
        {
            return this._templateMajorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the environment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TemplateMinorVersion
        {
            get { return this._templateMinorVersion; }
            set { this._templateMinorVersion = value; }
        }

        // Check to see if TemplateMinorVersion property is set
        internal bool IsSetTemplateMinorVersion()
        {
            return this._templateMinorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the environment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}