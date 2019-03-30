﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_mastery;

namespace api_mastery.Migrations
{
    [DbContext(typeof(DogBreedContext))]
    partial class DogBreedContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api_mastery.Models.DogBreed", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Breed");

                    b.Property<string>("ImageUrl");

                    b.HasKey("ID");

                    b.ToTable("DogBreeds");

                    b.HasData(
                        new { ID = 1, Breed = "Husky", ImageUrl = "/Images/.jpg" },
                        new { ID = 2, Breed = "Lab", ImageUrl = "/Images/.jpg" },
                        new { ID = 3, Breed = "Great Dane", ImageUrl = "/Images/.jpg" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
