using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;
using Force.Extensions;
using Force.Linq.Pagination;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Cqrs.Read
{
    /// <summary>
    /// Base handler for Async IEnumerable data
    /// </summary>
    /// <typeparam name="TKey">Id type</typeparam>
    /// <typeparam name="TQuery">Input query</typeparam>
    /// <typeparam name="TEntity">Domain entity</typeparam>
    /// <typeparam name="TListItem">Output list of dto items</typeparam>
    public abstract class GetEnumerableQueryHandlerBaseAsync<TKey, TQuery, TEntity, TListItem> :
        GetEnumerableBase<TQuery, TEntity, TListItem>,
        IQueryHandler<TQuery, Task<IEnumerable<TListItem>>>
        where TQuery : class, IQuery<Task<IEnumerable<TListItem>>>
        where TListItem : IHasId<TKey>
        where TKey : IEquatable<TKey>
    {
        protected GetEnumerableQueryHandlerBaseAsync(IQueryable<TEntity> queryable) : base(queryable)
        {
        }

        public async Task<IEnumerable<TListItem>> Handle(TQuery input) =>
            await MapFilterAndSort(input).PipeTo(p => Fetch(p, input));

        protected virtual async Task<IEnumerable<TListItem>> Fetch(IOrderedQueryable<TListItem> sorted, TQuery query) =>
            query switch
            {
                IPaging paging => await Task.FromResult(sorted.ToPagedEnumerable(paging)),
                _ => await sorted.ToListAsync()
            };
    }
}