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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CognitoIdentity.Model;
using Amazon.CognitoIdentity;

namespace AWSSDK_DotNet.UnitTests.TestTools
{
    [TestClass]
    public class CognitoIdentityMethodCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("SimpleMethods"), TestCategory("CognitoIdentity")]
        public void CognitoIdentitySimpleMethodTests()
        {
            EnsureSimpleMethodExists(typeof(Amazon.CognitoIdentity.AmazonCognitoIdentityClient), "DeleteIdentityPool", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CognitoIdentity.AmazonCognitoIdentityClient), "DescribeIdentity", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CognitoIdentity.AmazonCognitoIdentityClient), "DescribeIdentityPool", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CognitoIdentity.AmazonCognitoIdentityClient), "GetCredentialsForIdentity", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CognitoIdentity.AmazonCognitoIdentityClient), "GetCredentialsForIdentity", new Type[] { typeof(string), typeof(Dictionary<string, string>), });
            EnsureSimpleMethodExists(typeof(Amazon.CognitoIdentity.AmazonCognitoIdentityClient), "GetIdentityPoolRoles", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CognitoIdentity.AmazonCognitoIdentityClient), "GetOpenIdToken", new Type[] { typeof(string), });
            EnsureSimpleMethodExists(typeof(Amazon.CognitoIdentity.AmazonCognitoIdentityClient), "SetIdentityPoolRoles", new Type[] { typeof(string), typeof(Dictionary<string, string>), });
        }
        
        void EnsureSimpleMethodExists(Type type, string methodName, Type[] simpleParams)
        {
            Assert.IsNotNull(type.GetMethod(methodName, simpleParams), "Failed to find simple method " + methodName);
        }
    }
}