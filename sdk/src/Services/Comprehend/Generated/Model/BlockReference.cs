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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// A reference to a block.
    /// </summary>
    public partial class BlockReference
    {
        private int? _beginOffset;
        private string _blockId;
        private List<ChildBlock> _childBlocks = AWSConfigs.InitializeCollections ? new List<ChildBlock>() : null;
        private int? _endOffset;

        /// <summary>
        /// Gets and sets the property BeginOffset. 
        /// <para>
        /// Offset of the start of the block within its parent block.
        /// </para>
        /// </summary>
        public int? BeginOffset
        {
            get { return this._beginOffset; }
            set { this._beginOffset = value; }
        }

        // Check to see if BeginOffset property is set
        internal bool IsSetBeginOffset()
        {
            return this._beginOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlockId. 
        /// <para>
        /// Unique identifier for the block.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string BlockId
        {
            get { return this._blockId; }
            set { this._blockId = value; }
        }

        // Check to see if BlockId property is set
        internal bool IsSetBlockId()
        {
            return this._blockId != null;
        }

        /// <summary>
        /// Gets and sets the property ChildBlocks. 
        /// <para>
        /// List of child blocks within this block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ChildBlock> ChildBlocks
        {
            get { return this._childBlocks; }
            set { this._childBlocks = value; }
        }

        // Check to see if ChildBlocks property is set
        internal bool IsSetChildBlocks()
        {
            return this._childBlocks != null && (this._childBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndOffset. 
        /// <para>
        /// Offset of the end of the block within its parent block.
        /// </para>
        /// </summary>
        public int? EndOffset
        {
            get { return this._endOffset; }
            set { this._endOffset = value; }
        }

        // Check to see if EndOffset property is set
        internal bool IsSetEndOffset()
        {
            return this._endOffset.HasValue; 
        }

    }
}