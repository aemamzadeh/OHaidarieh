using Microsoft.EntityFrameworkCore.Migrations;

namespace Haidarieh.Infrastructure.EFCore.Migrations
{
    public partial class VisitCountAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VisitCount",
                table: "Tbl_Multimedia",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VisitCount",
                table: "Tbl_Multimedia");
        }
    }
}
