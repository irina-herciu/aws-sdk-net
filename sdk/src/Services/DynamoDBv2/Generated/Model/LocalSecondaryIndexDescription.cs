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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Represents the properties of a local secondary index.
    /// </summary>
    public partial class LocalSecondaryIndexDescription
    {
        private string _indexArn;
        private string _indexName;
        private long? _indexSizeBytes;
        private long? _itemCount;
        private List<KeySchemaElement> _keySchema = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;
        private Projection _projection;

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies the index.
        /// </para>
        /// </summary>
        public string IndexArn
        {
            get { return this._indexArn; }
            set { this._indexArn = value; }
        }

        // Check to see if IndexArn property is set
        internal bool IsSetIndexArn()
        {
            return this._indexArn != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// Represents the name of the local secondary index.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexSizeBytes. 
        /// <para>
        /// The total size of the specified index, in bytes. DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? IndexSizeBytes
        {
            get { return this._indexSizeBytes; }
            set { this._indexSizeBytes = value; }
        }

        // Check to see if IndexSizeBytes property is set
        internal bool IsSetIndexSizeBytes()
        {
            return this._indexSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items in the specified index. DynamoDB updates this value approximately
        /// every six hours. Recent changes might not be reflected in this value.
        /// </para>
        /// </summary>
        public long? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The complete key schema for the local secondary index, consisting of one or more pairs
        /// of attribute names and key types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HASH</c> - partition key
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RANGE</c> - sort key
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The partition key of an item is also known as its <i>hash attribute</i>. The term
        /// "hash attribute" derives from DynamoDB's usage of an internal hash function to evenly
        /// distribute data items across partitions, based on their partition key values.
        /// </para>
        ///  
        /// <para>
        /// The sort key of an item is also known as its <i>range attribute</i>. The term "range
        /// attribute" derives from the way DynamoDB stores items with the same partition key
        /// physically close together, in sorted order by the sort key value.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
        public List<KeySchemaElement> KeySchema
        {
            get { return this._keySchema; }
            set { this._keySchema = value; }
        }

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this._keySchema != null && (this._keySchema.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Projection. 
        /// <para>
        /// Represents attributes that are copied (projected) from the table into the global secondary
        /// index. These are in addition to the primary key attributes and index key attributes,
        /// which are automatically projected. 
        /// </para>
        /// </summary>
        public Projection Projection
        {
            get { return this._projection; }
            set { this._projection = value; }
        }

        // Check to see if Projection property is set
        internal bool IsSetProjection()
        {
            return this._projection != null;
        }

    }
}