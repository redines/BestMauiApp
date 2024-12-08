using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class blahfdsgfdg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Workout",
                newName: "WorkoutId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Excercises",
                newName: "ExcerciseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WorkoutId",
                table: "Workout",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ExcerciseId",
                table: "Excercises",
                newName: "Id");
        }
    }
}
