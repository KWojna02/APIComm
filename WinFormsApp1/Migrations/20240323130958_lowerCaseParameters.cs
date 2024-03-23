using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp1.Migrations
{
    /// <inheritdoc />
    public partial class lowerCaseParameters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Word",
                table: "Synonyms",
                newName: "word");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Synonyms",
                newName: "score");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "word",
                table: "Synonyms",
                newName: "Word");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "Synonyms",
                newName: "Score");
        }
    }
}
