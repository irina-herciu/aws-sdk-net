using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.DocumentModel.Ex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {
        [TestMethod]
        public void TestMethod7()
        {
            var condition = ConditionBuilder.New()
                .WithName("Price").Equal(50)
                .And(ConditionBuilder.New().WithName("Status").Equal("Active")).Build();

            var condition2 = new Expression
            {
                ExpressionStatement = "#0 = :0",
                ExpressionAttributeNames = { ["#0"] = "Price" },
                ExpressionAttributeValues = { [":0"] = 50 }
            };


            Assert.AreEqual("SET #price = :price", condition.ExpressionStatement);
            Assert.IsTrue(condition.ExpressionAttributeNames.ContainsKey("#price"));
            Assert.AreEqual(condition.ExpressionAttributeNames["#price"], "Price");
            Assert.IsTrue(condition.ExpressionAttributeValues.ContainsKey(":price"));
            Assert.AreEqual(condition.ExpressionAttributeValues[":price"], 50);
        }
    }
}