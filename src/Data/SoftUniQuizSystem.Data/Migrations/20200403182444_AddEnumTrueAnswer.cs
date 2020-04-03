using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftUniQuizSystem.Data.Migrations
{
    public partial class AddEnumTrueAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrueOrFalse",
                table: "Answers");

            migrationBuilder.AddColumn<int>(
                name: "TrueAnswer",
                table: "Questions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TrueAnswer",
                table: "Questions");

            migrationBuilder.AddColumn<bool>(
                name: "TrueOrFalse",
                table: "Answers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
