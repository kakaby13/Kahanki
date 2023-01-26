using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kahanki.Data.Migrations
{
    public partial class ExtendSettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RealName",
                table: "UserSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ShortBio",
                table: "UserSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RealName",
                table: "UserSettings");

            migrationBuilder.DropColumn(
                name: "ShortBio",
                table: "UserSettings");
        }
    }
}
