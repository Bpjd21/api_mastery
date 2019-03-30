using api_mastery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_mastery
{
    public class DogContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=Team3Mmemes;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dog>().HasData(
            new Dog()
            {
                ID = -1,
                Breed = "Husky",
                ImageUrl = "/Images/.jpg",
                BreedInfo = "Alaska",
            },
            new Dog()
            {
                ID = -2,
                Breed = "Lab",
                ImageUrl = "/Images/.jpg",
                BreedInfo = "Family!"
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}

