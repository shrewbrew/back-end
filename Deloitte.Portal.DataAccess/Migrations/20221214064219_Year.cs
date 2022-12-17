using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Deloitte.Portal.DataAccess.Migrations
{
    public partial class Year : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fromLivedOnImpactedNation",
                table: "ClaimReserve");

            migrationBuilder.DropColumn(
                name: "untilLivedOnImpactedNation",
                table: "ClaimReserve");

            migrationBuilder.AddColumn<string>(
                name: "fromMonth",
                table: "ClaimReserve",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fromYear",
                table: "ClaimReserve",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "toMonth",
                table: "ClaimReserve",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "toYear",
                table: "ClaimReserve",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fromMonth",
                table: "ClaimReserve");

            migrationBuilder.DropColumn(
                name: "fromYear",
                table: "ClaimReserve");

            migrationBuilder.DropColumn(
                name: "toMonth",
                table: "ClaimReserve");

            migrationBuilder.DropColumn(
                name: "toYear",
                table: "ClaimReserve");

            migrationBuilder.AddColumn<DateTime>(
                name: "fromLivedOnImpactedNation",
                table: "ClaimReserve",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "untilLivedOnImpactedNation",
                table: "ClaimReserve",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
