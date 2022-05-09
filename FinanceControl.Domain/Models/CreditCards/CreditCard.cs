using System;

namespace FinanceControl.Domain.Models
{
    public class CreditCard : BaseEntity
    {

        public CreditCard()
        {

        }

        
        public string Name { get; set; }

        public DateTime dueDate { get; set; }

        public DateTime BSD { get; set; } //BSD = Best Shopping Day


    }
}
