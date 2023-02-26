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
            builder.HasOne(o => o.Customer).WithMany(c => c.Orders).HasForeignKey(o => o.CustomerID);
            builder.HasOne(o => o.PurchasedMovie).WithMany().HasForeignKey(o => o.MovieID);
            builder.Property(o => o.Price).HasColumnType("decimal(18,2)");
            builder.Property(o => o.PurchasedDate).HasColumnType("datetime");
        }
    }

}
