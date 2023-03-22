using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class amendmentsintables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourrierPhoneNumber",
                table: "BookCourriers");

            migrationBuilder.AddColumn<string>(
                name: "CourrierPhoneNumber",
                table: "Courriers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "BookCourriers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "Quantity",
                value: 6);

            migrationBuilder.UpdateData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "Quantity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Courriers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CourrierPhoneNumber",
                value: "+359876760245");

            migrationBuilder.UpdateData(
                table: "Courriers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CourrierPhoneNumber",
                value: "+359123456789");

            migrationBuilder.UpdateData(
                table: "Courriers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CourrierPhoneNumber",
                value: "+359741258963");

            migrationBuilder.UpdateData(
                table: "Courriers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CourrierPhoneNumber",
                value: "+359002121215");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourrierPhoneNumber",
                table: "Courriers");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "BookCourriers");

            migrationBuilder.AddColumn<string>(
                name: "CourrierPhoneNumber",
                table: "BookCourriers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 1,
                column: "CourrierPhoneNumber",
                value: "+359875740295");

            migrationBuilder.UpdateData(
                table: "BookCourriers",
                keyColumn: "OrderID",
                keyValue: 2,
                column: "CourrierPhoneNumber",
                value: "135987455740295");
        }
    }
}
