using System.Collections;
using System.Linq.Expressions;

namespace Hasura.HasuraQueryable;

public class HasuraSet<T> : IOrderedQueryable<T>
{
    public HasuraSet(HasuraConfiguration configuration)
    {
        Provider = new HasuraProvider(configuration);
        Expression = Expression.Constant(this);
    }
    
    public IEnumerator<T> GetEnumerator()
    {
        return Provider.Execute<IEnumerable<T>>(Expression).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Type ElementType => typeof(T);

    public Expression Expression { get; private set; }
    public IQueryProvider Provider { get; private set; }
}