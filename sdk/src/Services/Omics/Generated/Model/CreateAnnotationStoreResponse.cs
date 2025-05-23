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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the CreateAnnotationStore operation.
    /// </summary>
    public partial class CreateAnnotationStoreResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _id;
        private string _name;
        private ReferenceItem _reference;
        private StoreStatus _status;
        private StoreFormat _storeFormat;
        private StoreOptions _storeOptions;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the store was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The store's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The store's name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Reference. 
        /// <para>
        /// The store's genome reference. Required for all stores except TSV format with generic
        /// annotations.
        /// </para>
        /// </summary>
        public ReferenceItem Reference
        {
            get { return this._reference; }
            set { this._reference = value; }
        }

        // Check to see if Reference property is set
        internal bool IsSetReference()
        {
            return this._reference != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The store's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StoreStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StoreFormat. 
        /// <para>
        /// The annotation file format of the store.
        /// </para>
        /// </summary>
        public StoreFormat StoreFormat
        {
            get { return this._storeFormat; }
            set { this._storeFormat = value; }
        }

        // Check to see if StoreFormat property is set
        internal bool IsSetStoreFormat()
        {
            return this._storeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property StoreOptions. 
        /// <para>
        /// The store's file parsing options.
        /// </para>
        /// </summary>
        public StoreOptions StoreOptions
        {
            get { return this._storeOptions; }
            set { this._storeOptions = value; }
        }

        // Check to see if StoreOptions property is set
        internal bool IsSetStoreOptions()
        {
            return this._storeOptions != null;
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        ///  The name given to an annotation store version to distinguish it from other versions.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}