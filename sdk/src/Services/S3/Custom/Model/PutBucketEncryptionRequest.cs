﻿/*
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutBucketEncryption operation.
    /// <note> 
    /// <para>
    /// This operation is not supported by directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// This action uses the <code>encryption</code> subresource to configure default encryption
    /// and Amazon S3 Bucket Keys for an existing bucket.
    /// </para>
    ///  
    /// <para>
    /// By default, all buckets have a default encryption configuration that uses server-side
    /// encryption with Amazon S3 managed keys (SSE-S3). You can optionally configure default
    /// encryption for a bucket by using server-side encryption with Key Management Service
    /// (KMS) keys (SSE-KMS) or dual-layer server-side encryption with Amazon Web Services
    /// KMS keys (DSSE-KMS). If you specify default encryption by using SSE-KMS, you can also
    /// configure <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-key.html">Amazon
    /// S3 Bucket Keys</a>. If you use PutBucketEncryption to set your <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">default
    /// bucket encryption</a> to SSE-KMS, you should verify that your KMS key ID is correct.
    /// Amazon S3 does not validate the KMS key ID provided in PutBucketEncryption requests.
    /// </para>
    ///  <important> 
    /// <para>
    /// This action requires Amazon Web Services Signature Version 4. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">
    /// Authenticating Requests (Amazon Web Services Signature Version 4)</a>. 
    /// </para>
    ///  </important> 
    /// <para>
    /// To use this operation, you must have permission to perform the <code>s3:PutEncryptionConfiguration</code>
    /// action. The bucket owner has this permission by default. The bucket owner can grant
    /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// The following operations are related to <code>PutBucketEncryption</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketEncryption.html">GetBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketEncryption.html">DeleteBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public class PutBucketEncryptionRequest : AmazonWebServiceRequest
    {
        private string bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string contentMD5;
        private ServerSideEncryptionConfiguration serverSideEncryptionConfiguration;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// Specifies default encryption for a bucket using server-side encryption with different key options.
        /// </para>
        /// 
        /// <para>
        /// <b>Directory buckets </b> - When you use this operation with a directory bucket, you must use path-style requests 
        /// in the format <c>https://s3express-control.<i>region_code</i>.amazonaws.com/<i>bucket-name</i></c>. 
        /// 
        /// Virtual-hosted-style requests aren't supported. 
        /// Directory bucket names must be unique in the chosen Availability Zone. 
        /// Bucket names must also follow the format <c><i>bucket_base_name</i>--<i>az_id</i>--x-s3</c> (for example, <c><i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). 
        /// 
        /// For information about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory bucket naming rules</a> 
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucketName()
        {
            return !(string.IsNullOrEmpty(this.bucketName));
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum</c>
        /// or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request
        /// with the HTTP status code <c>400 Bad Request</c>. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c>
        /// parameter.
        /// </para>
        /// 
        /// <para>
        /// For directory buckets, when you use Amazon Web Services SDKs, <c>CRC32</c> is the default checksum algorithm that's used for performance.
        /// </para>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the server-side encryption configuration.
        /// </para>
        ///  
        /// <para>
        /// For requests made using the Amazon Web Services Command Line Interface (CLI) or Amazon
        /// Web Services SDKs, this field is calculated automatically.
        /// </para>
        /// 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        /// </summary>
        public string ContentMD5
        {
            get { return this.contentMD5; }
            set { this.contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this.contentMD5 != null;
        }

        /// <summary>
        /// Container for server-side encryption configuration rules. Currently S3 supports one rule only.
        /// </summary>
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this.serverSideEncryptionConfiguration; }
            set { this.serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this.serverSideEncryptionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        /// 
        /// <para>
        /// For directory buckets, this header is not supported in this API operation. 
        /// If you specify this header, the request fails with the HTTP status code <c>501 Not Implemented</c>.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }
    }
}