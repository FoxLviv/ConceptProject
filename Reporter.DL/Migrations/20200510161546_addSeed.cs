using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Reporter.DL.Migrations
{
    public partial class addSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Reports",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Programming" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "AMI" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Teacher" },
                    { 2, "Head of Department" },
                    { 3, "Dean" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "DepartmentId", "Email", "FacultieId", "FirstName", "LastName", "PasswordHash", "PasswordSalt" },
                values: new object[] { new Guid("30fb2dd3-ea0e-4f05-b0db-ef6341a593f0"), 1, "burco.ab@gmail.com", 1, "Andriy", "Burtso", new byte[] { 0, 1, 1, 0 }, new byte[] { 0, 0, 0, 1 } });

            migrationBuilder.InsertData(
                table: "PersonRoles",
                columns: new[] { "PersonId", "RoleId" },
                values: new object[] { new Guid("30fb2dd3-ea0e-4f05-b0db-ef6341a593f0"), 1 });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Report", "Title" },
                values: new object[] { 1, new Guid("30fb2dd3-ea0e-4f05-b0db-ef6341a593f0"), new DateTimeOffset(new DateTime(2020, 9, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "On the other hand, we denounce with righteous indignation and dislike men who are so beguiled and demoralized by the charms of pleasure of the moment, so blinded by desire, that they cannot foresee the pain and trouble that are bound to ensue; and equal blame belongs to those who fail in their duty through weakness of will, which is the same as saying through shrinking from toil and pain. These cases are perfectly simple and easy to distinguish. In a free hour, when our power of choice is untrammelled and when nothing prevents our being able to do what we like best, every pleasure is to be welcomed and every pain avoided. But in certain circumstances and owing to the claims of duty or the obligations of business it will frequently occur that pleasures have to be repudiated and annoyances accepted. The wise man therefore always holds in these matters to this principle of selection: he rejects pleasures to secure other greater pleasures, or else he endures pains to avoid worse pains.", "First title" });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AuthorId", "Comment", "CreateAt", "ReportId" },
                values: new object[] { 1, new Guid("30fb2dd3-ea0e-4f05-b0db-ef6341a593f0"), "Cool work dude)", new DateTimeOffset(new DateTime(2020, 10, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonRoles",
                keyColumns: new[] { "PersonId", "RoleId" },
                keyValues: new object[] { new Guid("30fb2dd3-ea0e-4f05-b0db-ef6341a593f0"), 1 });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: new Guid("30fb2dd3-ea0e-4f05-b0db-ef6341a593f0"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Reports");
        }
    }
}
