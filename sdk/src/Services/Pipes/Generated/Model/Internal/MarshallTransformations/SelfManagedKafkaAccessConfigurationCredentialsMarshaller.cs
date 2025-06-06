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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pipes.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pipes.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SelfManagedKafkaAccessConfigurationCredentials Marshaller
    /// </summary>
    public class SelfManagedKafkaAccessConfigurationCredentialsMarshaller : IRequestMarshaller<SelfManagedKafkaAccessConfigurationCredentials, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SelfManagedKafkaAccessConfigurationCredentials requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBasicAuth())
            {
                context.Writer.WritePropertyName("BasicAuth");
                context.Writer.WriteStringValue(requestObject.BasicAuth);
            }

            if(requestObject.IsSetClientCertificateTlsAuth())
            {
                context.Writer.WritePropertyName("ClientCertificateTlsAuth");
                context.Writer.WriteStringValue(requestObject.ClientCertificateTlsAuth);
            }

            if(requestObject.IsSetSaslScram256Auth())
            {
                context.Writer.WritePropertyName("SaslScram256Auth");
                context.Writer.WriteStringValue(requestObject.SaslScram256Auth);
            }

            if(requestObject.IsSetSaslScram512Auth())
            {
                context.Writer.WritePropertyName("SaslScram512Auth");
                context.Writer.WriteStringValue(requestObject.SaslScram512Auth);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SelfManagedKafkaAccessConfigurationCredentialsMarshaller Instance = new SelfManagedKafkaAccessConfigurationCredentialsMarshaller();

    }
}