using Microsoft.EntityFrameworkCore.Migrations;

namespace api_mastery.Migrations
{
    public partial class ID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "DogBreeds",
                newName: "DogGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DogGroupId",
                table: "DogBreeds",
                newName: "GroupId");
        }
    }
}
