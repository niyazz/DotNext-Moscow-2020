﻿using System.Collections.Generic;
using System.Linq;
using Force.Cqrs;
using Force.Ddd;

namespace Infrastructure.Cqrs.Read
{
    public abstract class GetIntEnumerableQueryHandlerBase<TQuery, TEntity, TListItem> :
        GetEnumerableQueryHandlerBase<int, TQuery, TEntity, TListItem>
        where TQuery : class, IQuery<IEnumerable<TListItem>>
        where TListItem : IHasId<int>
    {
        protected GetIntEnumerableQueryHandlerBase(IQueryable<TEntity> queryable) : base(queryable)
        {
        }
    }
}