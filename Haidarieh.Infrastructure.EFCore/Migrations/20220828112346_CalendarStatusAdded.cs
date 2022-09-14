using Microsoft.EntityFrameworkCore.Migrations;

namespace Haidarieh.Infrastructure.EFCore.Migrations
{
    public partial class CalendarStatusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Tbl_Calendar",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tbl_Calendar");
        }
    }
}
