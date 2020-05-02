using Microsoft.EntityFrameworkCore.Migrations;

namespace CetBookStore.Data.Migrations
{
    public partial class lasssssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
