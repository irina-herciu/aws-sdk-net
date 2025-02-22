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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConnectionInput Marshaller
    /// </summary>
    public class ConnectionInputMarshaller : IRequestMarshaller<ConnectionInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConnectionInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAthenaProperties())
            {
                context.Writer.WritePropertyName("AthenaProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectAthenaPropertiesKvp in requestObject.AthenaProperties)
                {
                    context.Writer.WritePropertyName(requestObjectAthenaPropertiesKvp.Key);
                    var requestObjectAthenaPropertiesValue = requestObjectAthenaPropertiesKvp.Value;

                        context.Writer.Write(requestObjectAthenaPropertiesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAuthenticationConfiguration())
            {
                context.Writer.WritePropertyName("AuthenticationConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AuthenticationConfigurationInputMarshaller.Instance;
                marshaller.Marshall(requestObject.AuthenticationConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnectionProperties())
            {
                context.Writer.WritePropertyName("ConnectionProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectConnectionPropertiesKvp in requestObject.ConnectionProperties)
                {
                    context.Writer.WritePropertyName(requestObjectConnectionPropertiesKvp.Key);
                    var requestObjectConnectionPropertiesValue = requestObjectConnectionPropertiesKvp.Value;

                        context.Writer.Write(requestObjectConnectionPropertiesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetConnectionType())
            {
                context.Writer.WritePropertyName("ConnectionType");
                context.Writer.Write(requestObject.ConnectionType);
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetMatchCriteria())
            {
                context.Writer.WritePropertyName("MatchCriteria");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMatchCriteriaListValue in requestObject.MatchCriteria)
                {
                        context.Writer.Write(requestObjectMatchCriteriaListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetPhysicalConnectionRequirements())
            {
                context.Writer.WritePropertyName("PhysicalConnectionRequirements");
                context.Writer.WriteObjectStart();

                var marshaller = PhysicalConnectionRequirementsMarshaller.Instance;
                marshaller.Marshall(requestObject.PhysicalConnectionRequirements, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPythonProperties())
            {
                context.Writer.WritePropertyName("PythonProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPythonPropertiesKvp in requestObject.PythonProperties)
                {
                    context.Writer.WritePropertyName(requestObjectPythonPropertiesKvp.Key);
                    var requestObjectPythonPropertiesValue = requestObjectPythonPropertiesKvp.Value;

                        context.Writer.Write(requestObjectPythonPropertiesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSparkProperties())
            {
                context.Writer.WritePropertyName("SparkProperties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSparkPropertiesKvp in requestObject.SparkProperties)
                {
                    context.Writer.WritePropertyName(requestObjectSparkPropertiesKvp.Key);
                    var requestObjectSparkPropertiesValue = requestObjectSparkPropertiesKvp.Value;

                        context.Writer.Write(requestObjectSparkPropertiesValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetValidateCredentials())
            {
                context.Writer.WritePropertyName("ValidateCredentials");
                context.Writer.Write(requestObject.ValidateCredentials);
            }

            if(requestObject.IsSetValidateForComputeEnvironments())
            {
                context.Writer.WritePropertyName("ValidateForComputeEnvironments");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectValidateForComputeEnvironmentsListValue in requestObject.ValidateForComputeEnvironments)
                {
                        context.Writer.Write(requestObjectValidateForComputeEnvironmentsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConnectionInputMarshaller Instance = new ConnectionInputMarshaller();

    }
}