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
        public DbSet<DogGroup> DogGroups { get; set; }

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
                Id = 1,
                DogBreedName = "Husky",
                GroupId = 1,
            },
            new DogBreed()
            {
                Id = 2,
                DogBreedName = "BloodHound",
                GroupId = 2,
            },
            new DogBreed()
            {
                Id = 3,
                DogBreedName = "German Shepherd",
                GroupId = 3,
            });

            modelBuilder.Entity<DogGroup>().HasData(
            new DogGroup() {
                Id = 1,
                DogGroupImg = "/Images/working-group.jpg"
            },

            new DogGroup() {
                Id = 2,
                DogGroupImg = "/Images/Hounds_group.jpg"
            },

            new DogGroup() {
                Id = 3,
                DogGroupImg = "/Images/working-group.jpg"
            });        

            base.OnModelCreating(modelBuilder);
        }
    }
}

