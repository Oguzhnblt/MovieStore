using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");
            builder.HasKey(c => c.CustomerID);
            builder.Property(c => c.CustomerName).HasMaxLength(50);
            builder.Property(c => c.CustomerSurname).HasMaxLength(50);
        }
    }
}
