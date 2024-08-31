using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class changedent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Friday",
                table: "Excercises");

            migrationBuilder.DropColumn(
                name: "Monday",
                table: "Excercises");

            migrationBuilder.DropColumn(
                name: "Thuesday",
                table: "Excercises");

            migrationBuilder.DropColumn(
                name: "Thursday",
                table: "Excercises");

            migrationBuilder.DropColumn(
                name: "Wednesday",
                table: "Excercises");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Excercises",
                newName: "Type");

            migrationBuilder.RenameColumn(
                name: "ExcerciseType",
                table: "Excercises",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ExampleDescription",
                table: "Excercises",
                newName: "Day");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Excercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Excercises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Reps",
                table: "Excercises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sets",
                table: "Excercises",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Excercises",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Excercises");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Excercises");

            migrationBuilder.DropColumn(
                name: "Reps",
                table: "Excercises");

            migrationBuilder.DropColumn(
                name: "Sets",
                table: "Excercises");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Excercises");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Excercises",
                newName: "User");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Excercises",
                newName: "ExcerciseType");

            migrationBuilder.RenameColumn(
                name: "Day",
                table: "Excercises",
                newName: "ExampleDescription");

            migrationBuilder.AddColumn<bool>(
                name: "Friday",
                table: "Excercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Monday",
                table: "Excercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Thuesday",
                table: "Excercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Thursday",
                table: "Excercises",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Wednesday",
                table: "Excercises",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
