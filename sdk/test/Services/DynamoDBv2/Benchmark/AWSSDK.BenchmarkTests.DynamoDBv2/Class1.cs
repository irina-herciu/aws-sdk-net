using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;

namespace AWSSDK.BenchmarkTests.DynamoDBv2
{
    [MemoryDiagnoser]
    [RankColumn]
    [MinColumn, MaxColumn]
    public class DynamoDbScanBenchmark
    {
        private DynamoDBContext _context;

        [GlobalSetup]
        public void Setup()
        {
            var client = new AmazonDynamoDBClient(); // Use LocalStack or real AWS, configure accordingly
            _context = new DynamoDBContext(client, new DynamoDBContextConfig { Conversion = DynamoDBEntryConversion.V2 });
            var scan = _context.ScanAsync<Employee>(new List<ScanCondition>()
            {
                new ScanCondition("Age", ScanOperator.GreaterThan, 40),
                new ScanCondition("CompanyName", ScanOperator.Equal, "test")
            }, new ScanConfig { RetrieveDateTimeInUtc = true });

            var scan2 = _context.ScanAsync<Employee>(e => e.Age > 40 && e.CompanyName == "test");
        }

        [Benchmark]
        public void OldImplementation()
        {
            var scan = _context.ScanAsync<Employee>(new List<ScanCondition>()
            {
                new ScanCondition("Age", ScanOperator.GreaterThan, 40),
                new ScanCondition("CompanyName", ScanOperator.Equal, "test")
            }, new ScanConfig { RetrieveDateTimeInUtc = true });
            //var s = await scan.GetNextSetAsync();
        }

        [Benchmark(Baseline = true)]
        public void NewImplementation() {

            var scan = _context.ScanAsync<Employee>(e => e.Age > 40 && e.CompanyName == "test");
           // var s=await scan.GetNextSetAsync();
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
        //    try
        //    {
        //        var bm = new DynamoDbScanBenchmark();
        //        bm.Setup();
        //        bm.OldImplementation().GetAwaiter().GetResult();
        //        bm.NewImplementation().GetAwaiter().GetResult();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error running benchmark: {ex.Message}");
        //    }
            BenchmarkRunner.Run<DynamoDbScanBenchmark>();

        }
    }

    [DynamoDBTable("DotNetTests-HashRangeTable")]
    public class Employee
    {
        // Hash key
        [DynamoDBHashKey]
        public  string Name { get; set; }
        public string MiddleName { get; set; }
        // Range key
        [DynamoDBRangeKey]
        internal  int Age { get; set; }

        public  string CompanyName { get; set; }
        public  int Score { get; set; }
        public string ManagerName { get; set; }
        public byte[] Data { get; set; }

        public List<string> Aliases { get; set; }

        public string InternalId { get; set; }
    }
    }
