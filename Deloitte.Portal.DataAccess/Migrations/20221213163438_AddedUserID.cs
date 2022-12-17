using Microsoft.EntityFrameworkCore.Migrations;

namespace Deloitte.Portal.DataAccess.Migrations
{
    public partial class AddedUserID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "Claims",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userId",
                table: "Claims");
        }
    }
}
