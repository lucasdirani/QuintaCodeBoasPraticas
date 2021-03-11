using Microsoft.EntityFrameworkCore.Migrations;

namespace PokemonStatCalculator.DataAccess.Migrations
{
    public partial class UpdateLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "When",
                table: "Logs",
                newName: "LoggedAt");

            migrationBuilder.RenameColumn(
                name: "Trace",
                table: "Logs",
                newName: "LogTrace");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "Logs",
                newName: "LogMessage");

            migrationBuilder.RenameColumn(
                name: "Level",
                table: "Logs",
                newName: "LogLevel");

            migrationBuilder.RenameColumn(
                name: "Exception",
                table: "Logs",
                newName: "LogException");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoggedAt",
                table: "Logs",
                newName: "When");

            migrationBuilder.RenameColumn(
                name: "LogTrace",
                table: "Logs",
                newName: "Trace");

            migrationBuilder.RenameColumn(
                name: "LogMessage",
                table: "Logs",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "LogLevel",
                table: "Logs",
                newName: "Level");

            migrationBuilder.RenameColumn(
                name: "LogException",
                table: "Logs",
                newName: "Exception");
        }
    }
}
