﻿using Force.Cqrs;
using Force.Ddd;

namespace Infrastructure.Cqrs.Delete
{
    public class DeleteLongEntityHandlerBase<TEntity, TCommand> : DeleteEntityHandlerBase<long, TEntity, TCommand>
        where TCommand : ICommand, IHasId<long>
        where TEntity : class, IHasId<long>
    {
    }
}