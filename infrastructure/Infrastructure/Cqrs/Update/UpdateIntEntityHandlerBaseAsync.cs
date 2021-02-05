using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;

namespace Infrastructure.Cqrs.Update
{
    public abstract class UpdateIntEntityHandlerBaseAsync<TEntity, TCommand> :
        UpdateEntityHandlerBaseAsync<int, TEntity, TCommand>
        where TEntity : class, IHasId<int>
        where TCommand : ICommand<Task>, IHasId<int>
    {
    }
}