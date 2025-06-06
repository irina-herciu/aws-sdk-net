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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;
using Amazon.S3.Util;
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutObjectLegalHold Request Marshaller
    /// </summary>       
    public class PutObjectLegalHoldRequestMarshaller : IMarshaller<IRequest, PutObjectLegalHoldRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutObjectLegalHoldRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutObjectLegalHoldRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "AmazonS3");
            request.HttpMethod = "PUT";
            request.AddSubResource("legal-hold");

            if (publicRequest.IsSetChecksumAlgorithm())
                request.Headers.Add(S3Constants.AmzHeaderSdkChecksumAlgorithm, S3Transforms.ToStringValue(publicRequest.ChecksumAlgorithm));
            if (publicRequest.IsSetContentMD5())
                request.Headers.Add(HeaderKeys.ContentMD5Header, S3Transforms.ToStringValue(publicRequest.ContentMD5));
            if (publicRequest.IsSetRequestPayer())
                request.Headers.Add(S3Constants.AmzHeaderRequestPayer, S3Transforms.ToStringValue(publicRequest.RequestPayer.ToString()));
            if (publicRequest.IsSetExpectedBucketOwner())
                request.Headers.Add(S3Constants.AmzHeaderExpectedBucketOwner, S3Transforms.ToStringValue(publicRequest.ExpectedBucketOwner));
            if (!publicRequest.IsSetBucketName())
                throw new System.ArgumentException("BucketName is a required property and must be set before making this call.", "publicRequest.BucketName");
            if (!publicRequest.IsSetKey())
                throw new System.ArgumentException("Key is a required property and must be set before making this call.", "publicRequest.Key");
            
            if (publicRequest.IsSetVersionId())
                request.Parameters.Add("versionId", StringUtils.FromString(publicRequest.VersionId));
            request.AddPathResource("{Key+}", S3Transforms.ToStringValue(publicRequest.Key));
			request.ResourcePath = "/{Key+}";

            var stringWriter = new XMLEncodedStringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true, NewLineHandling = NewLineHandling.Entitize }))
            {   
                if (publicRequest.IsSetLegalHold())
                {
                    xmlWriter.WriteStartElement("LegalHold", S3Constants.S3RequestXmlNamespace);
                    if(publicRequest.LegalHold.IsSetStatus())
                        xmlWriter.WriteElementString("Status", StringUtils.FromString(publicRequest.LegalHold.Status));
    
                    xmlWriter.WriteEndElement();
                }
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers[HeaderKeys.ContentTypeHeader] = "application/xml";

                ChecksumUtils.SetChecksumData(
                    request, 
                    publicRequest.ChecksumAlgorithm, 
                    fallbackToMD5: false, 
                    isRequestChecksumRequired: true,
                    headerName: S3Constants.AmzHeaderSdkChecksumAlgorithm
                );
            }
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            request.UseQueryString = true;
            return request;
        }
        
        private static PutObjectLegalHoldRequestMarshaller _instance;

        /// <summary>
        /// Singleton for marshaller
        /// </summary>
        public static PutObjectLegalHoldRequestMarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutObjectLegalHoldRequestMarshaller();
                }
                return _instance;
            }
        }

    }    
}