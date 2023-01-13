using Microsoft.EntityFrameworkCore.Migrations;

namespace P01_StudentSystem.Migrations
{
    public partial class moreup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Courses_CourseId",
                table: "Homeworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Homeworks_Students_StudentId",
                table: "Homeworks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks");

            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Resources");

            migrationBuilder.RenameTable(
                name: "Homeworks",
                newName: "HomeworkSubmissions");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_StudentId",
                table: "HomeworkSubmissions",
                newName: "IX_HomeworkSubmissions_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Homeworks_CourseId",
                table: "HomeworkSubmissions",
                newName: "IX_HomeworkSubmissions_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Resources",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Resources",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Courses",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "HomeworkSubmissions",
                unicode: false,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HomeworkSubmissions",
                table: "HomeworkSubmissions",
                column: "HomeworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StudentId",
                table: "Courses",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkSubmissions_Courses_CourseId",
                table: "HomeworkSubmissions",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeworkSubmissions_Students_StudentId",
                table: "HomeworkSubmissions",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Students_StudentId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkSubmissions_Courses_CourseId",
                table: "HomeworkSubmissions");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeworkSubmissions_Students_StudentId",
                table: "HomeworkSubmissions");

            migrationBuilder.DropIndex(
                name: "IX_Courses_StudentId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HomeworkSubmissions",
                table: "HomeworkSubmissions");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "HomeworkSubmissions",
                newName: "Homeworks");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkSubmissions_StudentId",
                table: "Homeworks",
                newName: "IX_Homeworks_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_HomeworkSubmissions_CourseId",
                table: "Homeworks",
                newName: "IX_Homeworks_CourseId");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Resources",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false);

            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Resources",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Homeworks",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldUnicode: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Homeworks",
                table: "Homeworks",
                column: "HomeworkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Courses_CourseId",
                table: "Homeworks",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Homeworks_Students_StudentId",
                table: "Homeworks",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
