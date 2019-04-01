using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api_mastery.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DogBreeds",
                columns: table => new
                {
                    DogBreedId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DogBreedName = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogBreeds", x => x.DogBreedId);
                });

            migrationBuilder.CreateTable(
                name: "DogGroups",
                columns: table => new
                {
                    DogGroupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DogGroupImg = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogGroups", x => x.DogGroupId);
                });

            migrationBuilder.InsertData(
                table: "DogBreeds",
                columns: new[] { "DogBreedId", "DogBreedName", "GroupId" },
                values: new object[,]
                {
                    { 1, "Husky", 1 },
                    { 2, "BloodHound", 2 },
                    { 3, "German Shepherd", 3 }
                });

            migrationBuilder.InsertData(
                table: "DogGroups",
                columns: new[] { "DogGroupId", "DogGroupImg" },
                values: new object[,]
                {
                    { 1, "/Images/working-group.jpg" },
                    { 2, "/Images/Hounds_group.jpg" },
                    { 3, "/Images/working-group.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogBreeds");

            migrationBuilder.DropTable(
                name: "DogGroups");
        }
    }
}
