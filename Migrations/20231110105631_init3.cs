using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoGrpc.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ToDoItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "ToDoItems",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToDoStatus",
                table: "ToDoItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ToDoItems");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "ToDoItems");

            migrationBuilder.DropColumn(
                name: "ToDoStatus",
                table: "ToDoItems");
        }
    }
}
