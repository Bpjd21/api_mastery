using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_mastery.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogBreeds",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Breed = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogBreeds", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "ID", "Breed", "ImageUrl" },
                values: new object[] { 1, "Husky", "/Images/.jpg" });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "ID", "Breed", "ImageUrl" },
                values: new object[] { 2, "Lab", "/Images/.jpg" });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "ID", "Breed", "ImageUrl" },
                values: new object[] { 3, "Great Dane", "/Images/.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogBreeds");
        }
    }
}
