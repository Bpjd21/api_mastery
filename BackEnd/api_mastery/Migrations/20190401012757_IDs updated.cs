using Microsoft.EntityFrameworkCore.Migrations;

namespace api_mastery.Migrations
{
    public partial class IDsupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DogGroups",
                newName: "DogGroupId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DogBreeds",
                newName: "DogBreedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DogGroupId",
                table: "DogGroups",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DogBreedId",
                table: "DogBreeds",
                newName: "Id");
        }
    }
}
