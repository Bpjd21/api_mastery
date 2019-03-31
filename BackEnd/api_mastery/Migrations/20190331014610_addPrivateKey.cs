using Microsoft.EntityFrameworkCore.Migrations;

namespace api_mastery.Migrations
{
    public partial class addPrivateKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DogGroupName",
                table: "DogGroups",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DogBreedName", "GroupId" },
                values: new object[] { "BloodHound", 2 });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DogBreedName", "GroupId" },
                values: new object[] { "German Shepherd", 3 });

            migrationBuilder.InsertData(
                table: "DogGroups",
                columns: new[] { "Id", "DogGroupImg", "DogGroupName" },
                values: new object[,]
                {
                    { 1, "/Images/working-group.jpg", "Working" },
                    { 2, "/Images/Hounds_group.jpg", "Hound" },
                    { 3, "/Images/working-group.jpg", "Herding" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DogGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DogGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DogGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "DogGroupName",
                table: "DogGroups");

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 1,
                column: "GroupId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DogBreedName", "GroupId" },
                values: new object[] { "Lab", 0 });

            migrationBuilder.UpdateData(
                table: "DogBreeds",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DogBreedName", "GroupId" },
                values: new object[] { "Great Dane", 0 });
        }
    }
}
