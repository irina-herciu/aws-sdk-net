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

using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using System.Text;
using Amazon;
using System.Threading.Tasks;
using System;
using System.Diagnostics;
using System.IO;
using Amazon.SQS;
using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using System.Text.Json;
namespace AWSSDK.Benchmarks
{
    [MemoryDiagnoser]
    public class MarshallAndUnmarshallBenchmarks
    {
        #region marshalling
        private const string _sqsQueueUrl = "https://sqs.us-east-1.amazonaws.com/404186920727/LoadTestingQueue";
        private SendMessageRequest _sendMessageRequest;

        [GlobalSetup(Target = nameof(SQSSend100KBMessage))]
        public void SQSSend100KBMessageSetup()
        {
            //create 100 KB message

            var messageBody = Utils.CreateMessage(Constants.KiloSize * 100);
            _sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = _sqsQueueUrl,
                MessageBody = messageBody
            };
        }

        [Benchmark]
        public void SQSSend100KBMessage()
        {
            SendMessageRequestMarshaller.Instance.Marshall(_sendMessageRequest);
        }

        [GlobalSetup(Target = nameof(SQSSendMessage50KB))]
        public void SQSSend50KBMessageSetup()
        {
            var messageBody = Utils.CreateMessage(Constants.KiloSize * 50);
            _sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = _sqsQueueUrl,
                MessageBody = messageBody
            };
        }

        [Benchmark]
        public void SQSSendMessage50KB()
        {
            SendMessageRequestMarshaller.Instance.Marshall(_sendMessageRequest);
        }

        [GlobalSetup(Target = nameof(SQSSendMessage10KB))]
        public void SQSSend10KBMessageSetup()
        {
            var messageBody = Utils.CreateMessage(Constants.KiloSize * 10);
            _sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = _sqsQueueUrl,
                MessageBody = messageBody
            };
        }

        [Benchmark]
        public void SQSSendMessage10KB()
        {
            SendMessageRequestMarshaller.Instance.Marshall(_sendMessageRequest);
        }

        [GlobalSetup(Target = nameof(SQSSendMessage250KB))]
        public void SQSSend250KBMessageSetup()
        {
            var messageBody = Utils.CreateMessage(Constants.KiloSize * 250);
            _sendMessageRequest = new SendMessageRequest
            {
                QueueUrl = _sqsQueueUrl,
                MessageBody = messageBody,
            };
        }

        [Benchmark]
        public void SQSSendMessage250KB()
        {
            SendMessageRequestMarshaller.Instance.Marshall(_sendMessageRequest);
        }
        #endregion

        #region unmarshalling
        JsonUnmarshallerContext _context;
        MemoryStream stream;
        string payload;

        [GlobalSetup(Target = nameof(SQSSTJReceiveMessage10KB))]
        public void SQSSTJReceiveMessage10KBSetup()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"Messages\":[{\"Body\":\"");
            sb.Append(Utils.CreateMessage(Constants.KiloSize * 10));
            sb.Append("\"}]}");
            payload = sb.ToString();
            stream = new MemoryStream(Encoding.UTF8.GetBytes(payload));
        }

        [Benchmark]
        public void SQSSTJReceiveMessage10KB()
        {
            _context = new JsonUnmarshallerContext(stream, false, null);
            ReceiveMessageResponseUnmarshaller.Instance.Unmarshall(_context);
            _context.Stream.Position = 0;
        }

        [GlobalSetup(Target = nameof(SQSSTJReceiveMessage100KB))]
        public void SQSSTJReceiveMessage100KBSetup()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"Messages\":[{\"Body\":\"");
            sb.Append(Utils.CreateMessage(Constants.KiloSize * 100));
            sb.Append("\"}]}");
            payload = sb.ToString();
            stream = new MemoryStream(Encoding.UTF8.GetBytes(payload));
        }

        [Benchmark]
        public void SQSSTJReceiveMessage100KB()
        {
            _context = new JsonUnmarshallerContext(stream, false, null);
            ReceiveMessageResponseUnmarshaller.Instance.Unmarshall(_context);
            _context.Stream.Position = 0;
        }

        [GlobalSetup(Target = nameof(SQSSTJReceiveMessage250KB))]
        public void SQSSTJReceiveMessage250KBSetup()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"Messages\":[{\"Body\":\"");
            sb.Append(Utils.CreateMessage(Constants.KiloSize * 250));
            sb.Append("\"}]}");
            payload = sb.ToString();
            stream = new MemoryStream(Encoding.UTF8.GetBytes(payload));
        }

        [Benchmark]
        public void SQSSTJReceiveMessage250KB()
        {
            _context = new JsonUnmarshallerContext(stream, false, null);
            ReceiveMessageResponseUnmarshaller.Instance.Unmarshall(_context);
            _context.Stream.Position = 0;
        }

        // v4-dev has a different coding pattern, the stream is created inside the unmarshallercontext

        [GlobalSetup(Target = nameof(V4DevReceiveMessage10KB))]
        public void V4DevReceiveMessage10KBSetup()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"Messages\":[{\"Body\":\"");
            sb.Append(Utils.CreateMessage(Constants.KiloSize * 10));
            sb.Append("\"}]}");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString()));
        }

        [Benchmark]
        public void V4DevReceiveMessage10KB()
        {
            _context = new JsonUnmarshallerContext(stream, false, null);
            ReceiveMessageResponseUnmarshaller.Instance.Unmarshall(_context);
            stream.Position = 0;
        }

        [GlobalSetup(Target = nameof(V4DevReceiveMessage100KB))]
        public void V4DevReceiveMessage100KBSetup()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"Messages\":[{\"Body\":\"");
            sb.Append(Utils.CreateMessage(Constants.KiloSize * 100));
            sb.Append("\"}]}");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString()));
        }

        [Benchmark]
        public void V4DevReceiveMessage100KB()
        {
            _context = new JsonUnmarshallerContext(stream, false, null);
            ReceiveMessageResponseUnmarshaller.Instance.Unmarshall(_context);
            stream.Position = 0;
        }

        [GlobalSetup(Target = nameof(V4DevReceiveMessage250KB))]
        public void V4DevReceiveMessage250KBSetup()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{\"Messages\":[{\"Body\":\"");
            sb.Append(Utils.CreateMessage(Constants.KiloSize * 250));
            sb.Append("\"}]}");
            stream = new MemoryStream(Encoding.UTF8.GetBytes(sb.ToString()));
        }

        [Benchmark]
        public void V4DevReceiveMessage250KB()
        {
            _context = new JsonUnmarshallerContext(stream, false, null);
            ReceiveMessageResponseUnmarshaller.Instance.Unmarshall(_context);
            stream.Position = 0;
        }
    #endregion
    }
}