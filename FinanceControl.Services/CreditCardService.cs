using FinanceControl.Domain.Models;
using FinanceControl.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinanceControl.Services
{
    public class CreditCardService
    {
        private CreditCardRepository creditCardRepository;

        public CreditCardService()
        {
            this.creditCardRepository = new CreditCardRepository();

        }

        public void Create(CreditCard entity)
        {

            // Regras de negócio nessa classe

            creditCardRepository.Insert(entity);
        }

        public IEnumerable<CreditCard> GetAll()
        {
            return creditCardRepository.All().ToList();
        }
    }
}
