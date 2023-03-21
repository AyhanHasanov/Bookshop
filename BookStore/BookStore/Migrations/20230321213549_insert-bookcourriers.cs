using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class insertbookcourriers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookCourrier",
                columns: new[] { "OrderID", "BookId", "CourrierId", "CourrierPhoneNumber", "DeliveryDate" },
                values: new object[] { 1, 2, 3, "+359875740295", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BookCourrier",
                columns: new[] { "OrderID", "BookId", "CourrierId", "CourrierPhoneNumber", "DeliveryDate" },
                values: new object[] { 2, 3, 1, "+35987455740295", new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookCourrier",
                keyColumn: "OrderID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookCourrier",
                keyColumn: "OrderID",
                keyValue: 2);
        }
    }
}
