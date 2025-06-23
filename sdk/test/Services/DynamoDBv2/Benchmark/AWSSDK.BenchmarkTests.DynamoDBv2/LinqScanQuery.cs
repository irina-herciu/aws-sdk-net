using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class LinqScanQuery
{
    private DynamoDBContext _context;

    public void Setup()
    {
        _context = new DynamoDBContextBuilder()
            .WithDynamoDBClient(() => new AmazonDynamoDBClient(RegionEndpoint.USEast1))
            .ConfigureContext(x =>
            {
                x.IsEmptyStringValueEnabled = false;
                x.Conversion = DynamoDBEntryConversion.V2;
                x.DisableFetchingTableMetadata = false;
            })
            .Build();
    }

    public void ScanWithFilterExpression()
    {
        // Existing scenario: equality
        var exprAgeEq = new ContextExpression();
        exprAgeEq.SetFilter<AnnotatedEmployee>(e => e.Age == 45);
        var ageEqResult = _context.ScanAsync<AnnotatedEmployee>(exprAgeEq);

        // 1. Greater than and less than
        var exprAgeRange = new ContextExpression();
        exprAgeRange.SetFilter<AnnotatedEmployee>(e => e.Age > 20 && e.Age < 50);
        var ageRangeResult = _context.ScanAsync<AnnotatedEmployee>(exprAgeRange);

        // 2. String property comparison
        var exprCompany = new ContextExpression();
        exprCompany.SetFilter<AnnotatedEmployee>(e => e.CompanyName == "test1");
        var companyResult = _context.ScanAsync<AnnotatedEmployee>(exprCompany);

        // 3. Enum comparison
        var exprStatus = new ContextExpression();
        exprStatus.SetFilter<AnnotatedEmployee>(e => e.CurrentStatus == Status.Active);
        var statusResult = _context.ScanAsync<AnnotatedEmployee>(exprStatus);

        // 4. Logical OR
        var exprOr = new ContextExpression();
        exprOr.SetFilter<AnnotatedEmployee>(e => e.Age < 30 || e.Name == "Bob");
        var orResult = _context.ScanAsync<AnnotatedEmployee>(exprOr);

        // 5. String method: StartsWith
        var exprStartsWith = new ContextExpression();
        exprStartsWith.SetFilter<AnnotatedEmployee>(e => e.Name.StartsWith("S"));
        var startsWithResult = _context.ScanAsync<AnnotatedEmployee>(exprStartsWith);

        // 6. String method: Contains (if supported)
        var exprContains = new ContextExpression();
        exprContains.SetFilter<AnnotatedEmployee>(e => e.CompanyName.Contains("test"));
        var containsResult = _context.ScanAsync<AnnotatedEmployee>(exprContains);

        // 7. Negation
        var exprNot = new ContextExpression();
        exprNot.SetFilter<AnnotatedEmployee>(e => !(e.Age == 20));
        var notResult = _context.ScanAsync<AnnotatedEmployee>(exprNot);

        // 8. Between (if supported by your LINQ provider)
        var exprBetween = new ContextExpression();
        exprBetween.SetFilter<AnnotatedEmployee>(e => e.Age >= 20 && e.Age <= 45);
        var betweenResult = _context.ScanAsync<AnnotatedEmployee>(exprBetween);

        // 9. Attribute exists (if supported)
        var exprExists = new ContextExpression();
        exprExists.SetFilter<AnnotatedEmployee>(e => e.MiddleName != null);
        var existsResult = _context.ScanAsync<AnnotatedEmployee>(exprExists);

        // 10. List property: Aliases contains value (if supported)
        var exprListContains = new ContextExpression();
        exprListContains.SetFilter<AnnotatedEmployee>(e => e.Aliases != null && e.Aliases.Contains("Bob"));
        var listContainsResult = _context.ScanAsync<AnnotatedEmployee>(exprListContains);

        // 11. Constant value as a local variable
        int localAge = 45;
        var exprLocalVar = new ContextExpression();
        exprLocalVar.SetFilter<AnnotatedEmployee>(e => e.Age == localAge);
        var localVarResult = _context.ScanAsync<AnnotatedEmployee>(exprLocalVar);

        // 12. Constant value as a property access on a variable
        var filterObj = new { Company = "test1" };
        var exprPropertyAccess = new ContextExpression();
        exprPropertyAccess.SetFilter<AnnotatedEmployee>(e => e.CompanyName == filterObj.Company);
        var propertyAccessResult = _context.ScanAsync<AnnotatedEmployee>(exprPropertyAccess);

        // 13. Enum as a local variable
        Status localStatus = Status.Inactive;
        var exprEnumLocal = new ContextExpression();
        exprEnumLocal.SetFilter<AnnotatedEmployee>(e => e.CurrentStatus == localStatus);
        var enumLocalResult = _context.ScanAsync<AnnotatedEmployee>(exprEnumLocal);

        // 14. Enum as a property access
        var statusHolder = new { Status = Status.Upcoming };
        var exprEnumProperty = new ContextExpression();
        exprEnumProperty.SetFilter<AnnotatedEmployee>(e => e.CurrentStatus == statusHolder.Status);
        var enumPropertyResult = _context.ScanAsync<AnnotatedEmployee>(exprEnumProperty);

        // 15. String as a property of a class instance
        var employeeRef = new AnnotatedEmployee { Name = "Sam" };
        var exprClassProperty = new ContextExpression();
        exprClassProperty.SetFilter<AnnotatedEmployee>(e => e.Name == employeeRef.Name);
        var classPropertyResult = _context.ScanAsync<AnnotatedEmployee>(exprClassProperty);

    }

    public void QueryWithExpressionFilter()
    {
        var expr = new ContextExpression();
        expr.SetFilter<AnnotatedEmployee>(e => e.CompanyName == "test");

        var queryConfig = new QueryConfig
        {
            Expression = expr
        };
        var search = _context.QueryAsync<AnnotatedEmployee>("Bob", queryConfig);

        // 1. Constant value as a local variable
        string localCompany = "test1";
        var exprLocalVar = new ContextExpression();
        exprLocalVar.SetFilter<AnnotatedEmployee>(e => e.CompanyName == localCompany);
        var queryConfigLocal = new QueryConfig { Expression = exprLocalVar };
        var searchLocal = _context.QueryAsync<AnnotatedEmployee>("Cob", queryConfigLocal);

        // 2. Constant value as a property access on a variable
        var filterObj = new { Company = "test2" };
        var exprPropertyAccess = new ContextExpression();
        exprPropertyAccess.SetFilter<AnnotatedEmployee>(e => e.CompanyName == filterObj.Company);
        var queryConfigProperty = new QueryConfig { Expression = exprPropertyAccess };
        var searchProperty = _context.QueryAsync<AnnotatedEmployee>("Sam", queryConfigProperty);

        // 3. Enum as a local variable
        Status localStatus = Status.Inactive;
        var exprEnumLocal = new ContextExpression();
        exprEnumLocal.SetFilter<AnnotatedEmployee>(e => e.CurrentStatus == localStatus);
        var queryConfigEnumLocal = new QueryConfig { Expression = exprEnumLocal };
        var searchEnumLocal = _context.QueryAsync<AnnotatedEmployee>("Cob", queryConfigEnumLocal);

        // 4. Enum as a property access
        var statusHolder = new { Status = Status.Upcoming };
        var exprEnumProperty = new ContextExpression();
        exprEnumProperty.SetFilter<AnnotatedEmployee>(e => e.CurrentStatus == statusHolder.Status);
        var queryConfigEnumProperty = new QueryConfig { Expression = exprEnumProperty };
        var searchEnumProperty = _context.QueryAsync<AnnotatedEmployee>("Sam", queryConfigEnumProperty);

        // 5. String as a property of a class instance
        var employeeRef = new AnnotatedEmployee { Name = "Sam" };
        var exprClassProperty = new ContextExpression();
        exprClassProperty.SetFilter<AnnotatedEmployee>(e => e.Name == employeeRef.Name);
        var queryConfigClassProperty = new QueryConfig { Expression = exprClassProperty };
        var searchClassProperty = _context.QueryAsync<AnnotatedEmployee>("Sam", queryConfigClassProperty);
    }
}

[DynamoDBTable("DotNetTests-HashRangeTable")]
[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.All)]
public class AnnotatedEmployee : Employee
{
    // Hash key
    [DynamoDBHashKey]
    public override string Name { get; set; }

    // Range key
    [DynamoDBRangeKey]
    internal override int Age { get; set; }

    [DynamoDBGlobalSecondaryIndexHashKey("GlobalIndex", AttributeName = "Company")]
    public override string CompanyName { get; set; }

    [DynamoDBGlobalSecondaryIndexRangeKey("GlobalIndex")]
    public override int Score { get; set; }

    [DynamoDBLocalSecondaryIndexRangeKey("LocalIndex", AttributeName = "Manager")]
    public override string ManagerName { get; set; }
}

public class Employee
{
    // Hash key
    public virtual string Name { get; set; }
    public string MiddleName { get; set; }
    // Range key
    internal virtual int Age { get; set; }

    public virtual string CompanyName { get; set; }
    public virtual int Score { get; set; }
    public virtual string ManagerName { get; set; }
    public byte[] Data { get; set; }
    public Status CurrentStatus { get; set; }
    public List<string> Aliases { get; set; }

    public string InternalId { get; set; }
}

public enum Status : long
{
    Active = 256,
    Inactive = 1024,
    Upcoming = 9999,
    Obsolete = -10,
    Removed = 42
}