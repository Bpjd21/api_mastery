using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_mastery.Migrations
{
    public partial class AddDogGroupModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "DogBreeds",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "DogBreeds",
                newName: "DogBreedName");

            migrationBuilder.RenameColumn(
                name: "Breed",
                table: "DogBreeds",
                newName: "DogBreedImg");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "DogBreeds",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DogGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DogGroupImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogGroups", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DogBreedImg", "DogBreedName" },
                values: new object[] { "/Images/.jpg", "Husky" });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DogBreedImg", "DogBreedName" },
                values: new object[] { "/Images/.jpg", "Lab" });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DogBreedImg", "DogBreedName" },
                values: new object[] { "/Images/.jpg", "Great Dane" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogGroups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "DogBreeds");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DogBreeds",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "DogBreedName",
                table: "DogBreeds",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "DogBreedImg",
                table: "DogBreeds",
                newName: "Breed");

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Breed", "ImageUrl" },
                values: new object[] { "Husky", "/Images/.jpg" });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Breed", "ImageUrl" },
                values: new object[] { "Lab", "/Images/.jpg" });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Breed", "ImageUrl" },
                values: new object[] { "Great Dane", "/Images/.jpg" });
        }
    }
}
