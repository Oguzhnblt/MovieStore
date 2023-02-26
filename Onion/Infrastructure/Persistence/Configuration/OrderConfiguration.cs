using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.OrderID);
            builder.Property(o => o.Price).HasColumnType("decimal(18,2)");
            builder.Property(o => o.PurchasedDate).HasColumnType("datetime");
        }
    }

}
