using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class addedmissingtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCourrier_Books_BookId",
                table: "BookCourrier");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCourrier_Courriers_CourrierId",
                table: "BookCourrier");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCourrier",
                table: "BookCourrier");

            migrationBuilder.RenameTable(
                name: "BookCourrier",
                newName: "BookCourriers");

            migrationBuilder.RenameIndex(
                name: "IX_BookCourrier_CourrierId",
                table: "BookCourriers",
                newName: "IX_BookCourriers_CourrierId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCourrier_BookId",
                table: "BookCourriers",
                newName: "IX_BookCourriers_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCourriers",
                table: "BookCourriers",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCourriers_Books_BookId",
                table: "BookCourriers",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCourriers_Courriers_CourrierId",
                table: "BookCourriers",
                column: "CourrierId",
                principalTable: "Courriers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCourriers_Books_BookId",
                table: "BookCourriers");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCourriers_Courriers_CourrierId",
                table: "BookCourriers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCourriers",
                table: "BookCourriers");

            migrationBuilder.RenameTable(
                name: "BookCourriers",
                newName: "BookCourrier");

            migrationBuilder.RenameIndex(
                name: "IX_BookCourriers_CourrierId",
                table: "BookCourrier",
                newName: "IX_BookCourrier_CourrierId");

            migrationBuilder.RenameIndex(
                name: "IX_BookCourriers_BookId",
                table: "BookCourrier",
                newName: "IX_BookCourrier_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCourrier",
                table: "BookCourrier",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_BookCourrier_Books_BookId",
                table: "BookCourrier",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCourrier_Courriers_CourrierId",
                table: "BookCourrier",
                column: "CourrierId",
                principalTable: "Courriers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
