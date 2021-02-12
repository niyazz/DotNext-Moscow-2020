using HightechAngular.Core.Entities;
using JetBrains.Annotations;

namespace HightechAngular.Core.Services
{
    public interface IUserContext
    {
        [CanBeNull]
        public User User { get; }

        public bool IsAuthenticated => User != null;
    }
}