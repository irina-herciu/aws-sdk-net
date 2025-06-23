namespace AWSSDK.BenchmarkTests.DynamoDBv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exp = new LinqScanQuery();
            exp.Setup();
            exp.ScanWithFilterExpression();
            exp.QueryWithExpressionFilter();
        }

    }
}
