/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *
 */
namespace Amazon.Runtime.Internal.Endpoints.StandardLibrary
{
    /// <summary>
    /// Generated implementation of partition-specific data.
    /// Based on the data from partitions.json
    /// </summary>
    public partial class Partition
    {
        static Partition()
        {
            var aws = new PartitionAttributesShape
            {
                name = "aws",
                dnsSuffix = "amazonaws.com",
                dualStackDnsSuffix = "api.aws",
                supportsFIPS = true,
                supportsDualStack = true,
                implicitGlobalRegion = "us-east-1"
            };
            _partitionsByRegex.Add(@"^(us|eu|ap|sa|ca|me|af|il|mx)\-\w+\-\d+$", aws);
            _partitionsByRegionName.Add("af-south-1", aws);
            _partitionsByRegionName.Add("ap-east-1", aws);
            _partitionsByRegionName.Add("ap-east-2", aws);
            _partitionsByRegionName.Add("ap-northeast-1", aws);
            _partitionsByRegionName.Add("ap-northeast-2", aws);
            _partitionsByRegionName.Add("ap-northeast-3", aws);
            _partitionsByRegionName.Add("ap-south-1", aws);
            _partitionsByRegionName.Add("ap-south-2", aws);
            _partitionsByRegionName.Add("ap-southeast-1", aws);
            _partitionsByRegionName.Add("ap-southeast-2", aws);
            _partitionsByRegionName.Add("ap-southeast-3", aws);
            _partitionsByRegionName.Add("ap-southeast-4", aws);
            _partitionsByRegionName.Add("ap-southeast-5", aws);
            _partitionsByRegionName.Add("ap-southeast-7", aws);
            _partitionsByRegionName.Add("aws-global", aws);
            _partitionsByRegionName.Add("ca-central-1", aws);
            _partitionsByRegionName.Add("ca-west-1", aws);
            _partitionsByRegionName.Add("eu-central-1", aws);
            _partitionsByRegionName.Add("eu-central-2", aws);
            _partitionsByRegionName.Add("eu-north-1", aws);
            _partitionsByRegionName.Add("eu-south-1", aws);
            _partitionsByRegionName.Add("eu-south-2", aws);
            _partitionsByRegionName.Add("eu-west-1", aws);
            _partitionsByRegionName.Add("eu-west-2", aws);
            _partitionsByRegionName.Add("eu-west-3", aws);
            _partitionsByRegionName.Add("il-central-1", aws);
            _partitionsByRegionName.Add("me-central-1", aws);
            _partitionsByRegionName.Add("me-south-1", aws);
            _partitionsByRegionName.Add("mx-central-1", aws);
            _partitionsByRegionName.Add("sa-east-1", aws);
            _partitionsByRegionName.Add("us-east-1", aws);
            _partitionsByRegionName.Add("us-east-2", aws);
            _partitionsByRegionName.Add("us-west-1", aws);
            _partitionsByRegionName.Add("us-west-2", aws);

            var aws_cn = new PartitionAttributesShape
            {
                name = "aws-cn",
                dnsSuffix = "amazonaws.com.cn",
                dualStackDnsSuffix = "api.amazonwebservices.com.cn",
                supportsFIPS = true,
                supportsDualStack = true,
                implicitGlobalRegion = "cn-northwest-1"
            };
            _partitionsByRegex.Add(@"^cn\-\w+\-\d+$", aws_cn);
            _partitionsByRegionName.Add("aws-cn-global", aws_cn);
            _partitionsByRegionName.Add("cn-north-1", aws_cn);
            _partitionsByRegionName.Add("cn-northwest-1", aws_cn);

            var aws_us_gov = new PartitionAttributesShape
            {
                name = "aws-us-gov",
                dnsSuffix = "amazonaws.com",
                dualStackDnsSuffix = "api.aws",
                supportsFIPS = true,
                supportsDualStack = true,
                implicitGlobalRegion = "us-gov-west-1"
            };
            _partitionsByRegex.Add(@"^us\-gov\-\w+\-\d+$", aws_us_gov);
            _partitionsByRegionName.Add("aws-us-gov-global", aws_us_gov);
            _partitionsByRegionName.Add("us-gov-east-1", aws_us_gov);
            _partitionsByRegionName.Add("us-gov-west-1", aws_us_gov);

            var aws_iso = new PartitionAttributesShape
            {
                name = "aws-iso",
                dnsSuffix = "c2s.ic.gov",
                dualStackDnsSuffix = "c2s.ic.gov",
                supportsFIPS = true,
                supportsDualStack = false,
                implicitGlobalRegion = "us-iso-east-1"
            };
            _partitionsByRegex.Add(@"^us\-iso\-\w+\-\d+$", aws_iso);
            _partitionsByRegionName.Add("aws-iso-global", aws_iso);
            _partitionsByRegionName.Add("us-iso-east-1", aws_iso);
            _partitionsByRegionName.Add("us-iso-west-1", aws_iso);

            var aws_iso_b = new PartitionAttributesShape
            {
                name = "aws-iso-b",
                dnsSuffix = "sc2s.sgov.gov",
                dualStackDnsSuffix = "sc2s.sgov.gov",
                supportsFIPS = true,
                supportsDualStack = false,
                implicitGlobalRegion = "us-isob-east-1"
            };
            _partitionsByRegex.Add(@"^us\-isob\-\w+\-\d+$", aws_iso_b);
            _partitionsByRegionName.Add("aws-iso-b-global", aws_iso_b);
            _partitionsByRegionName.Add("us-isob-east-1", aws_iso_b);

            var aws_iso_e = new PartitionAttributesShape
            {
                name = "aws-iso-e",
                dnsSuffix = "cloud.adc-e.uk",
                dualStackDnsSuffix = "cloud.adc-e.uk",
                supportsFIPS = true,
                supportsDualStack = false,
                implicitGlobalRegion = "eu-isoe-west-1"
            };
            _partitionsByRegex.Add(@"^eu\-isoe\-\w+\-\d+$", aws_iso_e);
            _partitionsByRegionName.Add("aws-iso-e-global", aws_iso_e);
            _partitionsByRegionName.Add("eu-isoe-west-1", aws_iso_e);

            var aws_iso_f = new PartitionAttributesShape
            {
                name = "aws-iso-f",
                dnsSuffix = "csp.hci.ic.gov",
                dualStackDnsSuffix = "csp.hci.ic.gov",
                supportsFIPS = true,
                supportsDualStack = false,
                implicitGlobalRegion = "us-isof-south-1"
            };
            _partitionsByRegex.Add(@"^us\-isof\-\w+\-\d+$", aws_iso_f);
            _partitionsByRegionName.Add("aws-iso-f-global", aws_iso_f);
            _partitionsByRegionName.Add("us-isof-east-1", aws_iso_f);
            _partitionsByRegionName.Add("us-isof-south-1", aws_iso_f);

            var aws_eusc = new PartitionAttributesShape
            {
                name = "aws-eusc",
                dnsSuffix = "amazonaws.eu",
                dualStackDnsSuffix = "amazonaws.eu",
                supportsFIPS = true,
                supportsDualStack = false,
                implicitGlobalRegion = "eusc-de-east-1"
            };
            _partitionsByRegex.Add(@"^eusc\-(de)\-\w+\-\d+$", aws_eusc);
            _partitionsByRegionName.Add("eusc-de-east-1", aws_eusc);

            _defaultPartition = aws;
        }
    }
}