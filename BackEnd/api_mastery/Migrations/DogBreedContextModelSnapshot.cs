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
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("api_mastery.Models.DogBreed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DogBreedName");

                    b.Property<int>("GroupId");

                    b.HasKey("Id");

                    b.ToTable("DogBreeds");

                    b.HasData(
                        new { Id = 1, DogBreedName = "Husky", GroupId = 1 },
                        new { Id = 2, DogBreedName = "BloodHound", GroupId = 2 },
                        new { Id = 3, DogBreedName = "German Shepherd", GroupId = 3 }
                    );
                });

            modelBuilder.Entity("api_mastery.Models.DogGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DogGroupImg");

                    b.HasKey("Id");

                    b.ToTable("DogGroups");

                    b.HasData(
                        new { Id = 1, DogGroupImg = "/Images/working-group.jpg" },
                        new { Id = 2, DogGroupImg = "/Images/Hounds_group.jpg" },
                        new { Id = 3, DogGroupImg = "/Images/working-group.jpg" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
