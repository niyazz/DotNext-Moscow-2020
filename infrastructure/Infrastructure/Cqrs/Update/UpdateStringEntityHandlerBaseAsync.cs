using System.Threading.Tasks;
using Force.Cqrs;
using Force.Ddd;

namespace Infrastructure.Cqrs.Update
{
    public abstract class UpdateStringEntityHandlerBaseAsync<TEntity, TCommand> :
        UpdateEntityHandlerBaseAsync<string, TEntity, TCommand>
        where TEntity : class, IHasId<string>
        where TCommand : ICommand<Task>, IHasId<string>
    {
    }
}