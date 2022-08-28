using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityApiBE.Migrations
{
    public partial class crear_relacion_courses_indexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Indexes_Courses_CourseId",
                table: "Indexes");

            migrationBuilder.DropIndex(
                name: "IX_Indexes_CourseId",
                table: "Indexes");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Indexes");

            migrationBuilder.AddColumn<int>(
                name: "IdIndex",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_IdIndex",
                table: "Courses",
                column: "IdIndex",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Indexes_IdIndex",
                table: "Courses",
                column: "IdIndex",
                principalTable: "Indexes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Indexes_IdIndex",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_IdIndex",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "IdIndex",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Indexes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Indexes_CourseId",
                table: "Indexes",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Indexes_Courses_CourseId",
                table: "Indexes",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
