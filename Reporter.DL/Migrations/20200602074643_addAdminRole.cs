using Microsoft.EntityFrameworkCore.Migrations;

namespace Reporter.DL.Migrations
{
    public partial class addAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19d016f5-8c54-4516-b6ed-91cb101099bd", "d67661d4-b3ac-494a-a6b9-35f423f285ae", "Admin", "ADMIN" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0",
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnabled", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "237b4742-5473-47a6-ba78-1ca569e9bed7", "admin@gmail.com", true, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEK3jzQJiCHkx2ap0J5xCP0Qab5XZqelpZKr4SwktVFnsO3n6Zo03yip4c7Q4EoNQqw==", "KCI6QACPHAQPPINNHG6JZREXNLW2NTSX", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0", "19d016f5-8c54-4516-b6ed-91cb101099bd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0", "19d016f5-8c54-4516-b6ed-91cb101099bd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19d016f5-8c54-4516-b6ed-91cb101099bd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0",
                columns: new[] { "ConcurrencyStamp", "Email", "LockoutEnabled", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "83f7e2f1-f1be-40b8-b646-ca878eeeded2", "burco.ab@gmail.com", false, null, null, "Aa_1234", "40b55125-74bd-48ef-8611-c74b6542fc2a", null });
        }
    }
}
