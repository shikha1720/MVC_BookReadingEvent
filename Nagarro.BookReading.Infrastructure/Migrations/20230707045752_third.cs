using Microsoft.EntityFrameworkCore.Migrations;

namespace Nagarro.BookReading.Infrastructure.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "Admin", "e2954b14-5706-4013-8519-51c7364d4d89", "Admin", null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "Admin", 0, "d84930a2-513f-4e2b-b83e-7fbdbd07dcb3", "myadmin@bookevents.com", true, false, null, " MYADMIN@BOOKEVENTS.COM", "SHIKHA", "AQAAAAEAACcQAAAAELf8gfAKxsJ2WX1VxZeiuYUGxm0Fv/46uLv3XNhNS9Acgf9AlR9Tey1kuM4uywJf8Q==", null, false, "0815eb48-8f52-4551-bd75-2c9b44c93b3a", false, "Shikha" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "Admin");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "Admin");
        }
    }
}
