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

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customer entity
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CustomerID);

                entity.Property(e => e.CustomerName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.CustomerSurname).IsRequired().HasMaxLength(50);
            });

            // Director entity
            modelBuilder.Entity<Director>(entity =>
            {
                entity.HasKey(e => e.DirectorID);

                entity.Property(e => e.DirectorName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DirectorSurname).IsRequired().HasMaxLength(50);
            });

            // Actor entity
            modelBuilder.Entity<Actor>(entity =>
            {
                entity.HasKey(e => e.ActorID);

                entity.Property(e => e.ActorName).IsRequired().HasMaxLength(50);
                entity.Property(e => e.ActorSurname).IsRequired().HasMaxLength(50);
            });

            // Genre entity
            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.GenreID);

                entity.Property(e => e.GenreName).IsRequired().HasMaxLength(50);
            });

            // Movie entity
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.HasKey(e => e.MovieID);

                entity.Property(e => e.MovieName).IsRequired().HasMaxLength(100);
                entity.Property(e => e.MovieYear).IsRequired();
                entity.Property(e => e.MoviePrice).IsRequired();
            });

            // Order entity
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderID);

                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.PurchasedDate).IsRequired();
            });

        }






        //public DbSet<Actor>? Actors { get; set; }

        //public DbSet<Customer>? Customers { get; set; }

        //public DbSet<Director>? Directors { get; set; }

        //public DbSet<Movie>? Movies { get; set; }

        //public DbSet<Order>? Orders { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new ActorConfiguration());

        //    modelBuilder.ApplyConfiguration(new CustomerConfiguration());

        //    modelBuilder.ApplyConfiguration(new DirectorConfiguration());

        //    modelBuilder.ApplyConfiguration(new MovieConfiguration());

        //    modelBuilder.ApplyConfiguration(new OrderConfiguration());

        //    base.OnModelCreating(modelBuilder);
        //}


    }
}
