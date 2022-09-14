using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BussinesLogic.Data.Migrations
{
    public partial class seeding_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, "Frontend", null, null },
                    { 2, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, "Backend", null, null },
                    { 3, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, "Framework", null, null },
                    { 4, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, "Testing", null, null },
                    { 5, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, "Movile", null, null }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Level", "LongDescription", "Name", "ShortDescription", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, 0, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "Javascript Básico", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 2, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, 2, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "Javascript Avanzado", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 3, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, 1, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "PHP", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "IsDeleted", "LastName", "Name", "Password", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, "andresain@gmail.com", false, "Sainz", "Andrés", "saiaie88721", null, null },
                    { 2, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, "lopez_ch@gmail.com", false, "Lopez", "Chritian", "lopse399al", null, null },
                    { 3, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, "marrruiz@gmail.com", false, "Ruiz", "Marc", "ruimaer438", null, null }
                });

            migrationBuilder.InsertData(
                table: "CategoryCourse",
                columns: new[] { "CategoriesId", "CoursesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 3 },
                    { 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Indexes",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "List", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(2174), "Seeder", null, null, false, "Index Javascript Básico", null, null },
                    { 2, 2, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(2178), "Seeder", null, null, false, "Index Javascript Avanzado", null, null },
                    { 3, 3, new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(2181), "Seeder", null, null, false, "Index PHP", null, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthay", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "LastName", "Name", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, "Sainz", "Andrés", null, null, 1 },
                    { 2, new DateTime(1992, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, "Lopez", "Chritian", null, null, 2 },
                    { 3, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 13, 17, 6, 21, 15, DateTimeKind.Local).AddTicks(1766), "Seeder", null, null, false, "Ruiz", "Marc", null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "CourseStudent",
                columns: new[] { "CoursesId", "StudentsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Indexes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Indexes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Indexes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
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
        }
    }
}
