using Force.Ccc;
using Force.Cqrs;
using HightechAngular.Core.Entities;
using HightechAngular.Core.Services;

namespace HightechAngular.Account.Features.Account
{
    public class CreateOrderCommandHandler : ICommandHandler<CreateOrderCommand, int>
    {
        private readonly ICartStorage _cartStorage;
        private readonly IUnitOfWork _unitOfWork;

        public CreateOrderCommandHandler(
            ICartStorage cartStorage,
            IUnitOfWork unitOfWork)
        {
            _cartStorage = cartStorage;
            _unitOfWork = unitOfWork;
        }

        public int Handle(CreateOrderCommand input)
        {
            var order = new Order(_cartStorage.Cart);
            _unitOfWork.Add(order);
            _cartStorage.EmptyCart();
            _unitOfWork.Commit();

            return order.Id;
        }
    }
}
