using api_mastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_mastery
{
    public class DogBreedContext : DbContext
    {
        public DbSet<DogBreed> DogBreeds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=DogBreeds;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DogBreed>().HasData(
            new DogBreed()
            {
                ID = 1,
                Breed = "Husky",
                ImageUrl = "/Images/.jpg",
            },
            new DogBreed()
            {
                ID = 2,
                Breed = "Lab",
                ImageUrl = "/Images/.jpg",
            },
            new DogBreed()
            {
                ID = 3,
                Breed = "Great Dane",
                ImageUrl = "/Images/.jpg"
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}

