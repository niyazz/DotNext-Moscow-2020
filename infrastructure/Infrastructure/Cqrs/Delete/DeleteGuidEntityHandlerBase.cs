﻿using System;
using Force.Cqrs;
using Force.Ddd;

namespace Infrastructure.Cqrs.Delete
{
    public class DeleteGuidEntityHandlerBase<TEntity, TCommand> : DeleteEntityHandlerBase<Guid, TEntity, TCommand>
        where TCommand : ICommand, IHasId<Guid>
        where TEntity : class, IHasId<Guid>
    {
    }
}