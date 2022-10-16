namespace Hasura.HasuraQueryable;

public abstract class HasuraContext  
{
    private readonly HasuraConfiguration _configuration;

    protected HasuraContext(HasuraConfiguration configuration)
    {
        _configuration = configuration;
    }


}