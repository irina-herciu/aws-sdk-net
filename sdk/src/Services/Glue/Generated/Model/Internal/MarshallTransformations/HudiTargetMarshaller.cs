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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HudiTarget Marshaller
    /// </summary>
    public class HudiTargetMarshaller : IRequestMarshaller<HudiTarget, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(HudiTarget requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConnectionName())
            {
                context.Writer.WritePropertyName("ConnectionName");
                context.Writer.WriteStringValue(requestObject.ConnectionName);
            }

            if(requestObject.IsSetExclusions())
            {
                context.Writer.WritePropertyName("Exclusions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectExclusionsListValue in requestObject.Exclusions)
                {
                        context.Writer.WriteStringValue(requestObjectExclusionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMaximumTraversalDepth())
            {
                context.Writer.WritePropertyName("MaximumTraversalDepth");
                context.Writer.WriteNumberValue(requestObject.MaximumTraversalDepth.Value);
            }

            if(requestObject.IsSetPaths())
            {
                context.Writer.WritePropertyName("Paths");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPathsListValue in requestObject.Paths)
                {
                        context.Writer.WriteStringValue(requestObjectPathsListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static HudiTargetMarshaller Instance = new HudiTargetMarshaller();

    }
}