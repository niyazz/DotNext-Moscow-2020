using Force.Ddd;

namespace Infrastructure.OperationContext
{
    public class QueryByIntIdOperationContextBase<TQuery, TRequest> : QueryByIdOperationContextBase<int, TQuery, TRequest> 
        where TRequest : class, IHasId<int>
    {
        public QueryByIntIdOperationContextBase(TRequest request) : base(request)
        {
        }
    }
}