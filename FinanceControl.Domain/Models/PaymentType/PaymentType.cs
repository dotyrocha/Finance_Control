using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceControl.Domain.Models
{
    public class PaymentType
    {
        public PaymentType()
        {

        }

        public int Id { get; set; }
        public string HouseAccounts { get; set; }
        public string Investing { get; set; }
        public string Lifestyle { get; set; }


    }
}
