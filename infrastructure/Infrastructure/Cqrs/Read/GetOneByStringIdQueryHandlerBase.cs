﻿using System.Linq;
using Force.Cqrs;
using Force.Ddd;

namespace Infrastructure.Cqrs.Read
{
    public abstract class GetOneByStringIdQueryHandlerBase<TQuery, TEntity, TDto> :
        GetOneByIdQueryHandlerBase<string, TQuery, TEntity, TDto>
        where TQuery : IQuery<TDto>, IHasId<string>
        where TDto : class, IHasId<string>
        where TEntity : IHasId<string>
    {
        protected GetOneByStringIdQueryHandlerBase(IQueryable<TEntity> queryable) : base(queryable)
        {
        }
    }
}