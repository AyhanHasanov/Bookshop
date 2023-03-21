using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class insertbookcourrierswrong : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookCourrier",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CourrierPhoneNumber",
                value: "135987455740295");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BookCourrier",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CourrierPhoneNumber",
                value: "+35987455740295");
        }
    }
}
