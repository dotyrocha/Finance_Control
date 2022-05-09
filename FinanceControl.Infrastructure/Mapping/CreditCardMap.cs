using FinanceControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceControl.Infrastructure.Mapping
{
    public class CreditCardMap
    {
        public CreditCardMap(EntityTypeBuilder<CreditCard> entityBuild)
        {
            entityBuild.ToTable("TFC_CREDITCARD");

            entityBuild.HasKey(x => x.Id);

            entityBuild.Property(t => t.Name).IsRequired();

            entityBuild.Property(t => t.dueDate).IsRequired();

            entityBuild.Property(t => t.BSD).IsRequired();
        }
    }
}
