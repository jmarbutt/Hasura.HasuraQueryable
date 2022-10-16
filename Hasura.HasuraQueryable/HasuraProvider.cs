using System.Linq.Expressions;

namespace Hasura.HasuraQueryable;

public class HasuraProvider : IQueryProvider
{
    private readonly HasuraConfiguration _configuration;


    public HasuraProvider(HasuraConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IQueryable CreateQuery(Expression expression)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TElement> CreateQuery<TElement>(Expression expression)
    {
        throw new NotImplementedException();
    }

    public object? Execute(Expression expression)
    {
        throw new NotImplementedException();
    }

    public TResult Execute<TResult>(Expression expression)
    {
        throw new NotImplementedException();
    }
}