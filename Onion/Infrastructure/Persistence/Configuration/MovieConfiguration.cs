using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(m => m.MovieID);
            builder.Property(m => m.MovieName).HasMaxLength(100);
            builder.HasOne(m => m.MovieGenre).WithMany().HasForeignKey(m => m.GenreID);
            builder.HasOne(m => m.Director).WithMany(d => d.MoviesDirected).HasForeignKey(m => m.DirectorID);
            builder.HasMany(m => m.Actor).WithMany(a => a.Movies).UsingEntity(j => j.ToTable("MovieActor"));
            builder.Property(m => m.MoviePrice).HasColumnType("decimal(18,2)");
            builder.Property(m => m.IsDeleted).HasDefaultValue(false);
            builder.HasIndex(m => m.MovieName);
        }
    }
}
