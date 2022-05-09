using FinanceControl.Domain.Models;
using System;

namespace ChallengeStone.Domain.Interfaces
{
    public interface IPaymentTypeRepository : IRepository<PaymentType,Guid>
    {
    
    }
}