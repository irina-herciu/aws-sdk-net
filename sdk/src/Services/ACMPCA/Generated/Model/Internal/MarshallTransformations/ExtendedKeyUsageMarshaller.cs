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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ExtendedKeyUsage Marshaller
    /// </summary>
    public class ExtendedKeyUsageMarshaller : IRequestMarshaller<ExtendedKeyUsage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ExtendedKeyUsage requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetExtendedKeyUsageObjectIdentifier())
            {
                context.Writer.WritePropertyName("ExtendedKeyUsageObjectIdentifier");
                context.Writer.WriteStringValue(requestObject.ExtendedKeyUsageObjectIdentifier);
            }

            if(requestObject.IsSetExtendedKeyUsageType())
            {
                context.Writer.WritePropertyName("ExtendedKeyUsageType");
                context.Writer.WriteStringValue(requestObject.ExtendedKeyUsageType);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ExtendedKeyUsageMarshaller Instance = new ExtendedKeyUsageMarshaller();

    }
}