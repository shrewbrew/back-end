using Microsoft.EntityFrameworkCore.Migrations;

namespace Deloitte.Portal.DataAccess.Migrations
{
    public partial class fileextension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fileExtension",
                table: "Files",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fileExtension",
                table: "Files");
        }
    }
}
