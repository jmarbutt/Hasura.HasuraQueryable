namespace Hasura.HasuraQueryable.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var config = new HasuraConfiguration()
        {
            Url = "http://localhost:8080/v1/graphql"
        };

        var context = new SampleContext(config);

        var customers = from c in context.customers
            select c;
    }
}