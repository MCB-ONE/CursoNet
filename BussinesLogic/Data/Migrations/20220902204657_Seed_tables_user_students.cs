using System;
using Microsoft.EntityFrameworkCore.Migrations;
#nullable disable

namespace UniversityApiBE.Migrations
{
    public partial class Seed_tables_user_students : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "IsDeleted", "LastName", "Name", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 1, new DateTime(2022, 9, 2, 22, 46, 57, 630, DateTimeKind.Local).AddTicks(7252), "Seeder", null, null, "andresain@gmail.com", false, "Sainz", "Andrés", "saiaie88721", null, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "IsDeleted", "LastName", "Name", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 2, new DateTime(2022, 9, 2, 22, 46, 57, 630, DateTimeKind.Local).AddTicks(7252), "Seeder", null, null, "lopez_ch@gmail.com", false, "Lopez", "Chritian", "lopse399al", null, null });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "IsDeleted", "LastName", "Name", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[] { 3, new DateTime(2022, 9, 2, 22, 46, 57, 630, DateTimeKind.Local).AddTicks(7252), "Seeder", null, null, "marrruiz@gmail.com", false, "Ruiz", "Marc", "ruimaer438", null, null });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthay", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "LastName", "Name", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 1, new DateTime(1990, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 22, 46, 57, 630, DateTimeKind.Local).AddTicks(7252), "Seeder", null, null, false, "Sainz", "Andrés", null, null, 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthay", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "LastName", "Name", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 2, new DateTime(1992, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 22, 46, 57, 630, DateTimeKind.Local).AddTicks(7252), "Seeder", null, null, false, "Lopez", "Chritian", null, null, 2 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthay", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "LastName", "Name", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 3, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 2, 22, 46, 57, 630, DateTimeKind.Local).AddTicks(7252), "Seeder", null, null, false, "Ruiz", "Marc", null, null, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
