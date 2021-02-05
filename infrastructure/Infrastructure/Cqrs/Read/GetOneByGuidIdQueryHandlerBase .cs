﻿using System;
using System.Linq;
using Force.Cqrs;
using Force.Ddd;

namespace Infrastructure.Cqrs.Read
{
    public abstract class GetOneByGuidIdQueryHandlerBase<TQuery, TEntity, TDto> :
        GetOneByIdQueryHandlerBase<Guid, TQuery, TEntity, TDto>
        where TQuery : IQuery<TDto>, IHasId<Guid>
        where TDto : class, IHasId<Guid>
    {
        protected GetOneByGuidIdQueryHandlerBase(IQueryable<TEntity> queryable) : base(queryable)
        {
        }
    }
}