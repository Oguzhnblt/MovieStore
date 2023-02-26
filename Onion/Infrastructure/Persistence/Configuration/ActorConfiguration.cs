using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("Actors");
            builder.HasKey(a => a.ActorID);
            builder.Property(a => a.ActorName).HasMaxLength(50);
            builder.Property(a => a.ActorSurname).HasMaxLength(50);
        }
    }
}
