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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentityProvider.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CognitoIdentityProvider.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ManagedLoginBrandingType Object
    /// </summary>  
    public class ManagedLoginBrandingTypeUnmarshaller : IUnmarshaller<ManagedLoginBrandingType, XmlUnmarshallerContext>, IUnmarshaller<ManagedLoginBrandingType, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ManagedLoginBrandingType IUnmarshaller<ManagedLoginBrandingType, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ManagedLoginBrandingType Unmarshall(JsonUnmarshallerContext context)
        {
            ManagedLoginBrandingType unmarshalledObject = new ManagedLoginBrandingType();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Assets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AssetType, AssetTypeUnmarshaller>(AssetTypeUnmarshaller.Instance);
                    unmarshalledObject.Assets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreationDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastModifiedDate", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastModifiedDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ManagedLoginBrandingId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ManagedLoginBrandingId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Settings", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Documents.Internal.Transform.DocumentUnmarshaller.Instance;
                    unmarshalledObject.Settings = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UseCognitoProvidedValues", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.UseCognitoProvidedValues = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UserPoolId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.UserPoolId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ManagedLoginBrandingTypeUnmarshaller _instance = new ManagedLoginBrandingTypeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ManagedLoginBrandingTypeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}