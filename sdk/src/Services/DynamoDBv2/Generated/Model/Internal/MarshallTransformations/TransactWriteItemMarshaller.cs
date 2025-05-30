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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DynamoDBv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// TransactWriteItem Marshaller
    /// </summary>
    public class TransactWriteItemMarshaller : IRequestMarshaller<TransactWriteItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TransactWriteItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetConditionCheck())
            {
                context.Writer.WritePropertyName("ConditionCheck");
                context.Writer.WriteStartObject();

                var marshaller = ConditionCheckMarshaller.Instance;
                marshaller.Marshall(requestObject.ConditionCheck, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDelete())
            {
                context.Writer.WritePropertyName("Delete");
                context.Writer.WriteStartObject();

                var marshaller = DeleteMarshaller.Instance;
                marshaller.Marshall(requestObject.Delete, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPut())
            {
                context.Writer.WritePropertyName("Put");
                context.Writer.WriteStartObject();

                var marshaller = PutMarshaller.Instance;
                marshaller.Marshall(requestObject.Put, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUpdate())
            {
                context.Writer.WritePropertyName("Update");
                context.Writer.WriteStartObject();

                var marshaller = UpdateMarshaller.Instance;
                marshaller.Marshall(requestObject.Update, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TransactWriteItemMarshaller Instance = new TransactWriteItemMarshaller();

    }
}