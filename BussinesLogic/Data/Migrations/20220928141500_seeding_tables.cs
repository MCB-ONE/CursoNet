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
                    { 1, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Frontend", null, null },
                    { 2, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Backend", null, null },
                    { 3, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Framework", null, null },
                    { 4, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Testing", null, null },
                    { 5, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Movile", null, null },
                    { 6, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "CMS", null, null }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "Level", "LongDescription", "Name", "ShortDescription", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 0, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "Javascript Básico", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 2, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 2, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "Javascript Avanzado", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 3, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 1, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "PHP", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 4, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 0, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "CSS", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 5, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 2, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "SASS", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 6, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 1, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "Laravel", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 7, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 0, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "React", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 8, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 2, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "C#", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 9, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 1, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", ".NET", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null },
                    { 10, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, 1, "Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?", "Wordpress", "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "Email", "IsDeleted", "LastName", "Name", "Password", "Rol", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "andresain@gmail.com", false, "Sainz", "Andrés", "saiaie88721", 1, null, null },
                    { 2, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "lopez_ch@gmail.com", false, "Lopez", "Chritian", "lopse399al", 1, null, null },
                    { 3, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "marrruiz@gmail.com", false, "Ruiz", "Marc", "ruimaer438", 1, null, null },
                    { 4, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "admin@gmail.com", false, "Test", "Test Admin", "admin1234", 0, null, null },
                    { 5, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "nico@gmail.com", false, "Cruz", "Nicolas", "nicola3847", 1, null, null },
                    { 6, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "mtimes@gmail.com", false, "Times", "María", "73992hdj", 1, null, null },
                    { 7, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "nerilop@gmail.com", false, "Lopez", "Neri", "jooat528j", 1, null, null },
                    { 8, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "vizipep@gmail.com", false, "Vizio", "Pepe", "vizip3883", 1, null, null },
                    { 9, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "domica13@gmail.com", false, "Domingo", "Carlos", "1313dom12", 1, null, null },
                    { 10, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "monieve@gmail.com", false, "Montaña", "Nieves", "moni525niev", 1, null, null },
                    { 11, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "msainz@gmail.com", false, "Sainz", "Mario", "sain28282", 1, null, null },
                    { 12, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "m_chris@gmail.com", false, "Marco", "Chritian", "cmr8721", 1, null, null },
                    { 13, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "lucaruiz@gmail.com", false, "Ruiz", "Lucas", "ruizlu18822", 1, null, null },
                    { 14, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "katet@gmail.com", false, "Tetuan", "Karla", "kkktet282", 0, null, null },
                    { 15, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "cruzima@gmail.com", false, "Cruz", "Maria", "maricru828228", 1, null, null },
                    { 16, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "luma@gmail.com", false, "Luengo", "María", "luen7262", 1, null, null },
                    { 17, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "nerplaza@gmail.com", false, "Plaza", "Nerea", "palz8181", 1, null, null },
                    { 18, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "montespe@gmail.com", false, "Montes", "Pepe", "jsajas8", 1, null, null },
                    { 19, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "puebosss@gmail.com", false, "Pueblo", "Carlos", "1323aasdom12", 1, null, null },
                    { 20, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, "pazcoc@gmail.com", false, "Paz", "Concha", "asasppq871", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "CategoryCourse",
                columns: new[] { "CategoriesId", "CoursesId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 7 },
                    { 2, 3 },
                    { 2, 6 },
                    { 2, 8 },
                    { 2, 9 },
                    { 3, 2 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 9 },
                    { 4, 6 },
                    { 4, 7 },
                    { 4, 9 },
                    { 6, 10 }
                });

            migrationBuilder.InsertData(
                table: "Indexes",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "List", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8572), "Seeder", null, null, false, "Index Javascript Básico", null, null },
                    { 2, 2, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8575), "Seeder", null, null, false, "Index Javascript Avanzado", null, null },
                    { 3, 3, new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8577), "Seeder", null, null, false, "Index PHP", null, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Birthay", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "IsDeleted", "LastName", "Name", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Sainz", "Andrés", null, null, 1 },
                    { 2, new DateTime(1992, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Lopez", "Chritian", null, null, 2 },
                    { 3, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Ruiz", "Marc", null, null, 3 },
                    { 4, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Test", "Test Admin", null, null, 4 },
                    { 5, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Cruz", "Nicolas", null, null, 5 },
                    { 6, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Times", "María", null, null, 6 },
                    { 7, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Lopez", "Neri", null, null, 7 },
                    { 8, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Vizio", "Pepe", null, null, 8 },
                    { 9, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Domingo", "Carlos", null, null, 9 },
                    { 10, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Montaña", "Nieves", null, null, 10 },
                    { 11, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Sainz", "Mario", null, null, 11 },
                    { 12, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Marco", "Chritian", null, null, 12 },
                    { 13, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Ruiz", "Lucas", null, null, 13 },
                    { 14, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Tetuan", "Karla", null, null, 14 },
                    { 15, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Cruz", "Maria", null, null, 15 },
                    { 16, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Luengo", "María", null, null, 16 },
                    { 17, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Plaza", "Nerea", null, null, 17 },
                    { 18, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Montes", "Pepe", null, null, 18 },
                    { 19, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Pueblo", "Carlos", null, null, 19 },
                    { 20, new DateTime(1990, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 28, 16, 15, 0, 341, DateTimeKind.Local).AddTicks(8180), "Seeder", null, null, false, "Paz", "Concha", null, null, 20 }
                });

            migrationBuilder.InsertData(
                table: "CourseStudent",
                columns: new[] { "CoursesId", "StudentsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 11 },
                    { 1, 12 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 6 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 16 },
                    { 3, 1 },
                    { 3, 9 },
                    { 3, 11 },
                    { 4, 4 },
                    { 4, 5 },
                    { 4, 9 },
                    { 4, 14 },
                    { 4, 15 },
                    { 5, 3 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 13 },
                    { 5, 14 },
                    { 5, 15 },
                    { 6, 3 },
                    { 6, 8 },
                    { 6, 13 },
                    { 7, 8 },
                    { 8, 8 },
                    { 9, 7 },
                    { 9, 10 },
                    { 9, 17 },
                    { 10, 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 4, 6 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 4, 7 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "CategoryCourse",
                keyColumns: new[] { "CategoriesId", "CoursesId" },
                keyValues: new object[] { 6, 10 });

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
                keyValues: new object[] { 1, 11 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 1, 12 });

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
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 2, 16 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 4, 9 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 4, 14 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 4, 15 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 5, 13 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 5, 14 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 5, 15 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 6, 8 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 6, 13 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 7, 8 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 9, 7 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 9, 10 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "CourseStudent",
                keyColumns: new[] { "CoursesId", "StudentsId" },
                keyValues: new object[] { 10, 9 });

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
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20);

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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 10);

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
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);
        }
    }
}
