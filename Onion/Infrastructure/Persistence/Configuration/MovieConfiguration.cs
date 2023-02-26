using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(m => m.MovieID);
            builder.Property(m => m.MovieName).HasMaxLength(100);
            builder.Property(m => m.MoviePrice).HasColumnType("decimal(18,2)");
            builder.Property(m => m.IsDeleted).HasDefaultValue(false);
        }
    }
}
