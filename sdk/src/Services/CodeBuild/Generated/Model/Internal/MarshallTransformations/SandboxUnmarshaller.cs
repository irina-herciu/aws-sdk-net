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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeBuild.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeBuild.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Sandbox Object
    /// </summary>  
    public class SandboxUnmarshaller : IUnmarshaller<Sandbox, XmlUnmarshallerContext>, IUnmarshaller<Sandbox, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        Sandbox IUnmarshaller<Sandbox, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Sandbox Unmarshall(JsonUnmarshallerContext context)
        {
            Sandbox unmarshalledObject = new Sandbox();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("currentSession", targetDepth))
                {
                    var unmarshaller = SandboxSessionUnmarshaller.Instance;
                    unmarshalledObject.CurrentSession = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("encryptionKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.EncryptionKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("endTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("environment", targetDepth))
                {
                    var unmarshaller = ProjectEnvironmentUnmarshaller.Instance;
                    unmarshalledObject.Environment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("fileSystemLocations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProjectFileSystemLocation, ProjectFileSystemLocationUnmarshaller>(ProjectFileSystemLocationUnmarshaller.Instance);
                    unmarshalledObject.FileSystemLocations = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("logConfig", targetDepth))
                {
                    var unmarshaller = LogsConfigUnmarshaller.Instance;
                    unmarshalledObject.LogConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("projectName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProjectName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("queuedTimeoutInMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.QueuedTimeoutInMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("requestTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.RequestTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secondarySources", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProjectSource, ProjectSourceUnmarshaller>(ProjectSourceUnmarshaller.Instance);
                    unmarshalledObject.SecondarySources = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("secondarySourceVersions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ProjectSourceVersion, ProjectSourceVersionUnmarshaller>(ProjectSourceVersionUnmarshaller.Instance);
                    unmarshalledObject.SecondarySourceVersions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("source", targetDepth))
                {
                    var unmarshaller = ProjectSourceUnmarshaller.Instance;
                    unmarshalledObject.Source = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SourceVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeoutInMinutes", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TimeoutInMinutes = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.VpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static SandboxUnmarshaller _instance = new SandboxUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SandboxUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}