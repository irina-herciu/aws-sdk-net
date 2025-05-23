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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  ListVersions response and response metadata.
    /// </summary>
    public class ListVersionsResponse : AmazonWebServiceResponse
    {

        private bool? isTruncated;
        private string keyMarker;
        private string versionIdMarker;
        private string nextKeyMarker;
        private string nextVersionIdMarker;
        private List<S3ObjectVersion> versions = AWSConfigs.InitializeCollections ? new List<S3ObjectVersion>() : null;
        private string name;
        private string prefix;
        private int? maxKeys;
        private List<string> commonPrefixes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string delimiter;
        private RequestCharged _requestCharged;

        /// <summary>
        /// Gets and sets the property IsTruncated. 
        /// <para>
        /// A flag that indicates whether Amazon S3 returned all of the results that satisfied
        /// the search criteria. If your results were truncated, you can make a follow-up paginated
        /// request by using the <code>NextKeyMarker</code> and <code>NextVersionIdMarker</code>
        /// response parameters as a starting place in another request to return the rest of the
        /// results.
        /// </para>
        /// </summary>
        public bool? IsTruncated
        {
            get { return this.isTruncated; }
            set { this.isTruncated = value; }
        }

        // Check to see if IsTruncated property is set
        internal bool IsSetIsTruncated()
        {
            return this.isTruncated.HasValue;
        }

        /// <summary>
        /// Marks the last Key returned in a truncated response.
        ///  
        /// </summary>
        public string KeyMarker
        {
            get { return this.keyMarker; }
            set { this.keyMarker = value; }
        }

        // Check to see if KeyMarker property is set
        internal bool IsSetKeyMarker()
        {
            return this.keyMarker != null;
        }

        /// <summary>
        /// Gets and sets the VersionIdMarker property.
        /// Marks the last Version-Id returned in a truncated response.
        /// </summary>
        public string VersionIdMarker
        {
            get { return this.versionIdMarker; }
            set { this.versionIdMarker = value; }
        }

        // Check to see if VersionIdMarker property is set
        internal bool IsSetVersionIdMarker()
        {
            return this.versionIdMarker != null;
        }

        /// <summary>
        /// Use this value for the key marker request parameter in a subsequent request.
        ///  
        /// </summary>
        public string NextKeyMarker
        {
            get { return this.nextKeyMarker; }
            set { this.nextKeyMarker = value; }
        }

        // Check to see if NextKeyMarker property is set
        internal bool IsSetNextKeyMarker()
        {
            return this.nextKeyMarker != null;
        }

        /// <summary>
        /// Gets and sets the property NextVersionIdMarker. 
        /// <para>
        /// When the number of responses exceeds the value of <code>MaxKeys</code>, <code>NextVersionIdMarker</code>
        /// specifies the first object version not returned that satisfies the search criteria.
        /// Use this value for the <code>version-id-marker</code> request parameter in a subsequent
        /// request.
        /// </para>
        /// </summary>
        public string NextVersionIdMarker
        {
            get { return this.nextVersionIdMarker; }
            set { this.nextVersionIdMarker = value; }
        }

        // Check to see if NextVersionIdMarker property is set
        internal bool IsSetNextVersionIdMarker()
        {
            return this.nextVersionIdMarker != null;
        }

        /// <summary>
        /// Gets and sets the Versions property. This is a list of 
        /// object versions in the bucket that match your search criteria.
        /// </summary>
        public List<S3ObjectVersion> Versions
        {
            get { return this.versions; }
            set { this.versions = value; }
        }

        // Check to see if Versions property is set
        internal bool IsSetVersions()
        {
            return this.versions != null && (this.versions.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// <para>The bucket name.</para>
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

        /// <summary>
        /// Gets and sets the Prefix property.
        /// Keys that begin with the indicated prefix are listed.
        /// </summary>
        public string Prefix
        {
            get { return this.prefix; }
            set { this.prefix = value; }
        }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return this.prefix != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the MaxKeys property.
        /// This is the maximum number of keys in the S3ObjectVersions collection.
        /// The value is derived from the MaxKeys parameter to ListVersionsRequest.
        /// </summary>
        public int? MaxKeys
        {
            get { return this.maxKeys; }
            set { this.maxKeys = value; }
        }

        // Check to see if MaxKeys property is set
        internal bool IsSetMaxKeys()
        {
            return this.maxKeys.HasValue;
        }

        /// <summary>
        /// Gets the CommonPrefixes property. 
        /// A response can contain CommonPrefixes only if you specify a delimiter. 
        /// When you do, CommonPrefixes contains all (if there are any) keys between 
        /// Prefix and the next occurrence of the string specified by delimiter.
        /// </summary>
        public List<string> CommonPrefixes
        {
            get { return this.commonPrefixes; }
            set { this.commonPrefixes = value; }
        }

        // Check to see if CommonPrefixes property is set
        internal bool IsSetCommonPrefixes()
        {
            return this.commonPrefixes != null && (this.commonPrefixes.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the Delimiter property.
        /// <para>
        /// The delimiter grouping the included keys. A delimiter is a character that you specify
        /// to group keys. All keys that contain the same string between the prefix and the first
        /// occurrence of the delimiter are grouped under a single result element in <code>CommonPrefixes</code>.
        /// These groups are counted as one result against the <code>max-keys</code> limitation.
        /// These keys are not returned elsewhere in the response.
        /// </para>
        /// </summary>
        /// <remarks>
        /// These rolled-up keys are not returned elsewhere in the response.
        /// </remarks>
        public string Delimiter
        {
            get { return this.delimiter; }
            set { this.delimiter = value; }
        }
    }
}
    
