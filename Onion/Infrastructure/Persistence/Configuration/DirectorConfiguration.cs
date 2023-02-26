using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class DirectorConfiguration : IEntityTypeConfiguration<Director>
    {
        public void Configure(EntityTypeBuilder<Director> builder)
        {
            builder.ToTable("Directors");
            builder.HasKey(d => d.DirectorID);
            builder.Property(d => d.DirectorName).HasMaxLength(50);
            builder.Property(d => d.DirectorSurname).HasMaxLength(50);
        }
    }

}
