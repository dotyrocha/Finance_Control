
using FinanceControl.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceControl.Infrastructure.Mapping
{
    public class UserMap
    {
        public UserMap(EntityTypeBuilder<User> entityBuild)
        {
            entityBuild.ToTable("TFC_USER"); 

            entityBuild.HasKey(x => x.Id);

            entityBuild.Property(t=>t.Name).IsRequired();

            entityBuild.Property(t => t.Email).IsRequired().HasMaxLength(50);

        }
    }
}
