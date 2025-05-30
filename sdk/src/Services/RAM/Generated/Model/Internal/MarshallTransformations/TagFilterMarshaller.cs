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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.RAM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RAM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TagFilter Marshaller
    /// </summary>
    public class TagFilterMarshaller : IRequestMarshaller<TagFilter, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TagFilter requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetTagKey())
            {
                context.Writer.WritePropertyName("tagKey");
                context.Writer.WriteStringValue(requestObject.TagKey);
            }

            if(requestObject.IsSetTagValues())
            {
                context.Writer.WritePropertyName("tagValues");
                context.Writer.WriteStartArray();
                foreach(var requestObjectTagValuesListValue in requestObject.TagValues)
                {
                        context.Writer.WriteStringValue(requestObjectTagValuesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TagFilterMarshaller Instance = new TagFilterMarshaller();

    }
}