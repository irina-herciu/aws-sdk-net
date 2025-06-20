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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that controls whether CloudFront caches the response to requests using
    /// the specified HTTP methods. There are two choices:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// CloudFront caches responses to <c>GET</c> and <c>HEAD</c> requests.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CloudFront caches responses to <c>GET</c>, <c>HEAD</c>, and <c>OPTIONS</c> requests.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If you pick the second choice for your Amazon S3 Origin, you may need to forward Access-Control-Request-Method,
    /// Access-Control-Request-Headers, and Origin headers for the responses to be cached
    /// correctly.
    /// </para>
    /// </summary>
    public partial class CachedMethods
    {
        private List<string> _items = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains the HTTP methods that you want CloudFront to cache responses
        /// to. Valid values for <c>CachedMethods</c> include <c>GET</c>, <c>HEAD</c>, and <c>OPTIONS</c>,
        /// depending on which caching option you choose. For more information, see the preceding
        /// section.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && (this._items.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of HTTP methods for which you want CloudFront to cache responses. Valid
        /// values are <c>2</c> (for caching responses to <c>GET</c> and <c>HEAD</c> requests)
        /// and <c>3</c> (for caching responses to <c>GET</c>, <c>HEAD</c>, and <c>OPTIONS</c>
        /// requests).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}