using System.Collections.Generic;
using System.Linq;
using Force.Cqrs;
using Force.Ddd;

namespace Infrastructure.Cqrs.Read
{
    public abstract class GetStringEnumerableQueryHandlerBase<TQuery, TEntity, TListItem> :
        GetEnumerableQueryHandlerBase<string, TQuery, TEntity, TListItem>
        where TQuery : class, IQuery<IEnumerable<TListItem>>
        where TListItem : IHasId<string>
    {
        protected GetStringEnumerableQueryHandlerBase(IQueryable<TEntity> queryable) : base(queryable)
        {
        }
    }
}