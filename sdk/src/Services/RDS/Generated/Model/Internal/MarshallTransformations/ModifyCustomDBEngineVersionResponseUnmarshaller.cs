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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ModifyCustomDBEngineVersion operation
    /// </summary>  
    public class ModifyCustomDBEngineVersionResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ModifyCustomDBEngineVersionResponse response = new ModifyCustomDBEngineVersionResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("ModifyCustomDBEngineVersionResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, ModifyCustomDBEngineVersionResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("CreateTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        response.CreateTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomDBEngineVersionManifest", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CustomDBEngineVersionManifest = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DatabaseInstallationFilesS3BucketName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DatabaseInstallationFilesS3BucketName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DatabaseInstallationFilesS3Prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DatabaseInstallationFilesS3Prefix = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBEngineDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBEngineDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBEngineMediaType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBEngineMediaType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBEngineVersionArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBEngineVersionArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBEngineVersionDescription", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBEngineVersionDescription = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBParameterGroupFamily", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBParameterGroupFamily = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DefaultCharacterSet", targetDepth))
                    {
                        var unmarshaller = CharacterSetUnmarshaller.Instance;
                        response.DefaultCharacterSet = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Engine", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Engine = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.EngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExportableLogTypes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.ExportableLogTypes == null)
                        {
                            response.ExportableLogTypes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ExportableLogTypes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Image", targetDepth))
                    {
                        var unmarshaller = CustomDBEngineVersionAMIUnmarshaller.Instance;
                        response.Image = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("KMSKeyId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.KMSKeyId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MajorEngineVersion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.MajorEngineVersion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServerlessV2FeaturesSupport", targetDepth))
                    {
                        var unmarshaller = ServerlessV2FeaturesSupportUnmarshaller.Instance;
                        response.ServerlessV2FeaturesSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportedCACertificateIdentifiers/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.SupportedCACertificateIdentifiers == null)
                        {
                            response.SupportedCACertificateIdentifiers = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.SupportedCACertificateIdentifiers.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedCharacterSets/CharacterSet", targetDepth))
                    {
                        var unmarshaller = CharacterSetUnmarshaller.Instance;
                        if (response.SupportedCharacterSets == null)
                        {
                            response.SupportedCharacterSets = new List<CharacterSet>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.SupportedCharacterSets.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedEngineModes/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.SupportedEngineModes == null)
                        {
                            response.SupportedEngineModes = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.SupportedEngineModes.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedFeatureNames/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (response.SupportedFeatureNames == null)
                        {
                            response.SupportedFeatureNames = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.SupportedFeatureNames.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedNcharCharacterSets/CharacterSet", targetDepth))
                    {
                        var unmarshaller = CharacterSetUnmarshaller.Instance;
                        if (response.SupportedNcharCharacterSets == null)
                        {
                            response.SupportedNcharCharacterSets = new List<CharacterSet>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.SupportedNcharCharacterSets.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportedTimezones/Timezone", targetDepth))
                    {
                        var unmarshaller = TimezoneUnmarshaller.Instance;
                        if (response.SupportedTimezones == null)
                        {
                            response.SupportedTimezones = new List<Timezone>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.SupportedTimezones.Add(item);
                        continue;
                    }
                    if (context.TestExpression("SupportsBabelfish", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsBabelfish = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsCertificateRotationWithoutRestart", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsCertificateRotationWithoutRestart = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsGlobalDatabases", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsGlobalDatabases = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsIntegrations", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsIntegrations = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsLimitlessDatabase", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsLimitlessDatabase = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsLocalWriteForwarding", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsLocalWriteForwarding = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsLogExportsToCloudwatchLogs", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsLogExportsToCloudwatchLogs = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsParallelQuery", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsParallelQuery = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SupportsReadReplica", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.SupportsReadReplica = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TagList/Tag", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (response.TagList == null)
                        {
                            response.TagList = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.TagList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ValidUpgradeTarget/UpgradeTarget", targetDepth))
                    {
                        var unmarshaller = UpgradeTargetUnmarshaller.Instance;
                        if (response.ValidUpgradeTarget == null)
                        {
                            response.ValidUpgradeTarget = new List<UpgradeTarget>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.ValidUpgradeTarget.Add(item);
                        continue;
                    }
                } 
           }

            return;
        }


        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("CustomDBEngineVersionNotFoundFault"))
                {
                    return CustomDBEngineVersionNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidCustomDBEngineVersionStateFault"))
                {
                    return InvalidCustomDBEngineVersionStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonRDSException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static ModifyCustomDBEngineVersionResponseUnmarshaller _instance = new ModifyCustomDBEngineVersionResponseUnmarshaller();        

        internal static ModifyCustomDBEngineVersionResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyCustomDBEngineVersionResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}