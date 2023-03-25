using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class addedmoreordersData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookCourriers",
                columns: new[] { "OrderID", "BookId", "CourrierId", "DeliveryDate", "Quantity" },
                values: new object[,]
                {
                    { 3, 4, 3, new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 91 },
                    { 4, 3, 3, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 5, 5, 4, new DateTime(2022, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 71 },
                    { 6, 6, 2, new DateTime(2022, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 69 },
                    { 7, 1, 3, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 93 },
                    { 8, 7, 3, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 9, 7, 3, new DateTime(2022, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 23 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 9);
        }
    }
}
