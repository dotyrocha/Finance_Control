using FinanceControl.Domain.Models;
using System;

namespace ChallengeStone.Domain.Interfaces
{
    public interface IUserRepository: IRepository<User,Guid>
    {
    }
}
