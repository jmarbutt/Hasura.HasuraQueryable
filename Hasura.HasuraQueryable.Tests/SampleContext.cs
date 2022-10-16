namespace Hasura.HasuraQueryable.Tests;

public class SampleContext : HasuraContext
{
    public SampleContext(HasuraConfiguration configuration) : base(configuration)
    {
    }
    
    public HasuraSet<Customer> customers { get; set; }
}

public class Customer
{
    public int id { get; set; }
    
    public string first_name { get; set; }
    
    public string last_name { get; set; }
    
    public string email { get; set; }
    
    public string phone { get; set; }
    
    public string username { get; set; }
    
    public string ip_address { get; set; }
    
    public IQueryable<Order> orders { get; set; }
}

public class Order
{
    public int id { get; set; }
    
    public string transaction_id { get; set; }
    
    public string product { get; set; }
    
    public string purchase_price { get; set; }
    
    public string discount_price { get; set; }
    
    public string order_date { get; set; }
    
    public int customer_id { get; set; }
    
    public Customer customer { get; set; }
    
}