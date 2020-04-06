using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuizSystem.Data.Migrations
{
    public partial class RemoveAnswersModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.AddColumn<string>(
                name: "AnswerA",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerB",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnswerC",
                table: "Questions",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrectA",
                table: "Questions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrectB",
                table: "Questions",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrectC",
                table: "Questions",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnswerA",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AnswerB",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AnswerC",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsCorrectA",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsCorrectB",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "IsCorrectC",
                table: "Questions");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_IsDeleted",
                table: "Answers",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");
        }
    }
}
