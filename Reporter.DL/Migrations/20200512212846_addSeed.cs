using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reporter.DL.Migrations
{
    public partial class addSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Programming" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "AMI" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "FacultieId", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0", 0, "83f7e2f1-f1be-40b8-b646-ca878eeeded2", 1, "burco.ab@gmail.com", false, 1, "Andriy", "Burtso", false, null, null, null, "Aa_1234", null, false, "40b55125-74bd-48ef-8611-c74b6542fc2a", false, null });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Report", "Title" },
                values: new object[] { 1, "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0", new DateTimeOffset(new DateTime(2020, 9, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.", "First title" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Comment", "CreateAt", "ReportId" },
                values: new object[] { 1, "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0", "Cool work dude)", new DateTimeOffset(new DateTime(2020, 10, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
