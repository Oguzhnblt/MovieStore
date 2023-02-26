using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Configuration;

namespace Persistence.Context
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
        }

        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<Genre>? Genres { get; set; }
        public DbSet<Director>? Directors { get; set; }
        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Order>? Orders { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActorConfiguration());

            modelBuilder.ApplyConfiguration(new CustomerConfiguration());

            modelBuilder.ApplyConfiguration(new DirectorConfiguration());

            modelBuilder.ApplyConfiguration(new MovieConfiguration());

            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new GenreConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
