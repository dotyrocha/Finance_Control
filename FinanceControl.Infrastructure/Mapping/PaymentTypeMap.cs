using FinanceControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.Infrastructure.Mapping
{
    internal class PaymentTypeMap
    {
        public PaymentTypeMap(EntityTypeBuilder<PaymentType> entityBuild)
        {
            entityBuild.ToTable("TFC_CREDITCARD");

            entityBuild.HasKey(x => x.Id);

            entityBuild.Property(t => t.HouseAccounts).IsRequired();

            entityBuild.Property(t => t.Investing).IsRequired();

            entityBuild.Property(t => t.Lifestyle).IsRequired();
        }
    }
    }
}
