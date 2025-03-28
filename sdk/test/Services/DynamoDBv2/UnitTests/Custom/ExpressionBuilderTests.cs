using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.DocumentModel.Ex;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {
        [TestMethod]
        public void TestMethod3()
        {
            var condition =
                ConditionalExpression.New().WithName("Price").EqualTo(50)
                .Build();

            Assert.AreEqual("#price = :price", condition.ExpressionStatement);
            Assert.IsTrue(condition.ExpressionAttributeNames.ContainsKey("#price"));
            Assert.AreEqual(condition.ExpressionAttributeNames["#price"], "Price");
            Assert.IsTrue(condition.ExpressionAttributeValues.ContainsKey(":price"));
            Assert.AreEqual(condition.ExpressionAttributeValues[":price"], 50);
        }

        [TestMethod]
        public void TestMethod4()
        {
            var condition = ComposedConditional.New()
                    .WithCondition(ConditionalExpression.New().WithName("Price").EqualTo(50))
                    .And(ConditionalExpression.New().WithName("Id").EqualTo(50))
                    .Build();
          

            Assert.AreEqual("#price = :price AND #id = :id", condition.ExpressionStatement);
            Assert.IsTrue(condition.ExpressionAttributeNames.ContainsKey("#price"));
            Assert.AreEqual(condition.ExpressionAttributeNames["#price"], "Price");
            Assert.IsTrue(condition.ExpressionAttributeValues.ContainsKey(":price"));
            Assert.AreEqual(condition.ExpressionAttributeValues[":price"], 50);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var condition = ComposedConditional.New()
                    .WithCondition(ConditionalExpression.New().WithName("Price").EqualTo(50))
                    .And(FunctionExpression.New().AttributeExists("Test"))
                    .Build();

            Assert.AreEqual("#price = :price AND attribute_exists(#test)", condition.ExpressionStatement);
            Assert.IsTrue(condition.ExpressionAttributeNames.ContainsKey("#price"));
            Assert.AreEqual(condition.ExpressionAttributeNames["#price"], "Price");
            Assert.IsTrue(condition.ExpressionAttributeValues.ContainsKey(":price"));
            Assert.AreEqual(condition.ExpressionAttributeValues[":price"], 50);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var condition = UpdateExpression.New().WithName("Price").EqualTo(50)
                .Build();


            Assert.AreEqual("SET #price = :price", condition.ExpressionStatement);
            Assert.IsTrue(condition.ExpressionAttributeNames.ContainsKey("#price"));
            Assert.AreEqual(condition.ExpressionAttributeNames["#price"], "Price");
            Assert.IsTrue(condition.ExpressionAttributeValues.ContainsKey(":price"));
            Assert.AreEqual(condition.ExpressionAttributeValues[":price"], 50);
        }


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