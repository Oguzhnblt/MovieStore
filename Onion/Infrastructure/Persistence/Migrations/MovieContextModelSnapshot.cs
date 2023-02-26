﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Context;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<int>("MoviesMovieID")
                        .HasColumnType("int");

                    b.HasKey("ActorID", "MoviesMovieID");

                    b.HasIndex("MoviesMovieID");

                    b.ToTable("ActorMovie");
                });

            modelBuilder.Entity("CustomerMovie", b =>
                {
                    b.Property<int>("CustomersCustomerID")
                        .HasColumnType("int");

                    b.Property<int>("PurchasedMoviesMovieID")
                        .HasColumnType("int");

                    b.HasKey("CustomersCustomerID", "PurchasedMoviesMovieID");

                    b.HasIndex("PurchasedMoviesMovieID");

                    b.ToTable("CustomerMovie");
                });

            modelBuilder.Entity("Domain.Entities.Actor", b =>
                {
                    b.Property<int>("ActorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorID"));

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ActorSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ActorID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerID"));

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Domain.Entities.Director", b =>
                {
                    b.Property<int>("DirectorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DirectorID"));

                    b.Property<string>("DirectorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DirectorSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DirectorID");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"));

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("GenreID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"));

                    b.Property<int>("ActorID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("DirectorID")
                        .HasColumnType("int");

                    b.Property<int>("GenreID")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("MoviePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("MovieYear")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderID")
                        .HasColumnType("int");

                    b.HasKey("MovieID");

                    b.HasIndex("DirectorID");

                    b.HasIndex("GenreID");

                    b.HasIndex("OrderID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PurchasedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ActorMovie", b =>
                {
                    b.HasOne("Domain.Entities.Actor", null)
                        .WithMany()
                        .HasForeignKey("ActorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesMovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerMovie", b =>
                {
                    b.HasOne("Domain.Entities.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersCustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Movie", null)
                        .WithMany()
                        .HasForeignKey("PurchasedMoviesMovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.HasOne("Domain.Entities.Customer", null)
                        .WithMany("FavoriteGenres")
                        .HasForeignKey("CustomerID");
                });

            modelBuilder.Entity("Domain.Entities.Movie", b =>
                {
                    b.HasOne("Domain.Entities.Director", "Director")
                        .WithMany("MoviesDirected")
                        .HasForeignKey("DirectorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Genre", "MovieGenre")
                        .WithMany("Movies")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Order", null)
                        .WithMany("PurchasedMovie")
                        .HasForeignKey("OrderID");

                    b.Navigation("Director");

                    b.Navigation("MovieGenre");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.HasOne("Domain.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Domain.Entities.Customer", b =>
                {
                    b.Navigation("FavoriteGenres");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Domain.Entities.Director", b =>
                {
                    b.Navigation("MoviesDirected");
                });

            modelBuilder.Entity("Domain.Entities.Genre", b =>
                {
                    b.Navigation("Movies");
                });

            modelBuilder.Entity("Domain.Entities.Order", b =>
                {
                    b.Navigation("PurchasedMovie");
                });
#pragma warning restore 612, 618
        }
    }
}
