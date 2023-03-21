using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class insertcourriers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courriers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Econt" },
                    { 2, "Speedy" },
                    { 3, "FedEx" },
                    { 4, "EuropaRoads" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courriers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courriers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courriers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courriers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
