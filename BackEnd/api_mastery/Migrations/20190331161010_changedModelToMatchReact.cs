using Microsoft.EntityFrameworkCore.Migrations;

namespace api_mastery.Migrations
{
    public partial class changedModelToMatchReact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogGroupName",
                table: "DogGroups");

            migrationBuilder.DropColumn(
                name: "DogBreedImg",
                table: "DogBreeds");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DogGroupName",
                table: "DogGroups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DogBreedImg",
                table: "DogBreeds",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "DogBreedImg",
                value: "/Images/.jpg");

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 2,
                column: "DogBreedImg",
                value: "/Images/.jpg");

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 3,
                column: "DogBreedImg",
                value: "/Images/.jpg");

            migrationBuilder.UpdateData(
                table: "DogGroups",
                keyColumn: "Id",
                keyValue: 1,
                column: "DogGroupName",
                value: "Working");

            migrationBuilder.UpdateData(
                table: "DogGroups",
                keyColumn: "Id",
                keyValue: 2,
                column: "DogGroupName",
                value: "Hound");

            migrationBuilder.UpdateData(
                table: "DogGroups",
                keyColumn: "Id",
                keyValue: 3,
                column: "DogGroupName",
                value: "Herding");
        }
    }
}
