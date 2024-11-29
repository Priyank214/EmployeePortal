using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeePortal.Migrations
{
    /// <inheritdoc />
    public partial class AddContactTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91e11e7d-0a75-4fa1-9efd-a1a1938b2c0b");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "01c62574-6745-493c-8f28-c82202b71a3f");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2e255451-0b95-40a4-9797-b44ddcb20d73");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "309399fc-6d26-40fd-b973-d5ff7b1e235d");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "a05edf2a-f331-4020-8263-c351a1d9151d");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "d24a16a8-0af8-43da-9a8a-4ed5a859caa5");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "d47b799f-10e2-4c8f-8d00-1fa4ac80f61a");

            migrationBuilder.CreateTable(
                name: "Contactus",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Query = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resolved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contactus", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5729bcb7-adb2-47ed-ba1f-4a9e962d2471", 0, "d1f3b05b-3f08-4939-8e80-4a23bfa8faa9", "admin.digiwhiz@gmail.com", false, "Admin Digiwhiz", false, null, "admin.digiwhiz@gmail.com", "admin.digiwhiz@gmail.com", "AQAAAAIAAYagAAAAEKZ+S5DdSVspka6xlJ4ricJzXSq7z4PQ4Gf0Xg+vTgfVpa+ZMKI0z8VGnYZK7qhSZQ==", "+938434444445", true, "d2919e3b-5d4b-4cc1-9c2e-42708c3a9f2c", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "189a4621-9b97-475a-8917-3206404c28c8", "charmi.shah@digiwhiz.com.au", "Charmi", "Shah" },
                    { "75314e6e-59fb-4248-b065-064cc032062c", "peter.parker@digiwhiz.com.au", "Peter", "Parker" },
                    { "8a5b44be-0808-4f42-8159-bae5002adab5", "vikash.shah@digiwhiz.com.au", "Vikash", "Shah" },
                    { "92ea1236-21bc-49ea-b596-8df856df2173", "jigar.gor@digiwhiz.com.au", "Jigar", "Gor" },
                    { "bc143a2a-967e-40e9-a65b-4aa3e96149c3", "unish.kumar@digiwhiz.com.au", "Unish", "Kumar" },
                    { "fffd6a7c-04f5-42af-91f0-d544d6447ed3", "hariparmar@digiwhiz.com.au", "Harikrishna", "Parmar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contactus");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5729bcb7-adb2-47ed-ba1f-4a9e962d2471");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "189a4621-9b97-475a-8917-3206404c28c8");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "75314e6e-59fb-4248-b065-064cc032062c");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "8a5b44be-0808-4f42-8159-bae5002adab5");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "92ea1236-21bc-49ea-b596-8df856df2173");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "bc143a2a-967e-40e9-a65b-4aa3e96149c3");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "fffd6a7c-04f5-42af-91f0-d544d6447ed3");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "91e11e7d-0a75-4fa1-9efd-a1a1938b2c0b", 0, "9352d868-8bd9-4daa-8505-3e2f1998e64d", "admin.digiwhiz@gmail.com", false, "Admin Digiwhiz", false, null, "admin.digiwhiz@gmail.com", "admin.digiwhiz@gmail.com", "AQAAAAIAAYagAAAAEH0HU2s/ptTvE3Gc8gAUMVXgaf8G2w9N3MzOi3gFQegpwPASRtd1HrdS2uD4Dz7KPw==", "+938434444445", true, "d5431e15-8335-4809-bdc6-060c97670ac4", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { "01c62574-6745-493c-8f28-c82202b71a3f", "peter.parker@digiwhiz.com.au", "Peter", "Parker" },
                    { "2e255451-0b95-40a4-9797-b44ddcb20d73", "vikash.shah@digiwhiz.com.au", "Vikash", "Shah" },
                    { "309399fc-6d26-40fd-b973-d5ff7b1e235d", "hariparmar@digiwhiz.com.au", "Harikrishna", "Parmar" },
                    { "a05edf2a-f331-4020-8263-c351a1d9151d", "jigar.gor@digiwhiz.com.au", "Jigar", "Gor" },
                    { "d24a16a8-0af8-43da-9a8a-4ed5a859caa5", "unish.kumar@digiwhiz.com.au", "Unish", "Kumar" },
                    { "d47b799f-10e2-4c8f-8d00-1fa4ac80f61a", "charmi.shah@digiwhiz.com.au", "Charmi", "Shah" }
                });
        }
    }
}
