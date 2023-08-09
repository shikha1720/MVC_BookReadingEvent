using Microsoft.EntityFrameworkCore.Migrations;

namespace Nagarro.BookReading.Infrastructure.Migrations
{
    public partial class four : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin",
                column: "ConcurrencyStamp",
                value: "fa9c28f2-ca2c-48a2-a2af-3927bd3b9265");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f83668af-6bd8-4b4b-834d-49c142af85e1", "AQAAAAEAACcQAAAAEGALUWmAimJ/kAvp70f/bACiU6E7cFy+WA1S3URUEjmu19Ru2t7hOmbqGVLGuAAEVg==", "e7f59fd3-19a8-49d8-af15-d5e543cdd88c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin",
                column: "ConcurrencyStamp",
                value: "e2954b14-5706-4013-8519-51c7364d4d89");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d84930a2-513f-4e2b-b83e-7fbdbd07dcb3", "AQAAAAEAACcQAAAAELf8gfAKxsJ2WX1VxZeiuYUGxm0Fv/46uLv3XNhNS9Acgf9AlR9Tey1kuM4uywJf8Q==", "0815eb48-8f52-4551-bd75-2c9b44c93b3a" });
        }
    }
}
