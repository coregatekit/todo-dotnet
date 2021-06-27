using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoApp.Migrations
{
    public partial class redesign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Secret",
                table: "TodoItems",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Secret",
                table: "TodoItems");
        }
    }
}
