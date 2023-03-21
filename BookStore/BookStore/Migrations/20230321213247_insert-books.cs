using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore.Migrations
{
    public partial class insertbooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "Created", "Price", "PublisherId", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, "Захари Карабашлиев", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.5, 1, 100, "Опашката" },
                    { 2, "Дамян Дамянов", new DateTime(2011, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 22.600000000000001, 6, 50, "Избрани стихотворения" },
                    { 3, "Георги Господинов", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20.0, 2, 500, "Времеубежище" },
                    { 4, "Джордж Оруел", new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.989999999999998, 3, 30, "1984" },
                    { 5, "Виктор Пасков", new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.899999999999999, 5, 15, "Аутопсия на една любов" },
                    { 6, "Константин Трендафилов", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15.0, 4, 1500, "Имам нещо да ти кажа" },
                    { 7, "Антоан Дьо Екзюпери", new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7.9000000000000004, 1, 3000, "Малкият Принц" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);
        }
    }
}
