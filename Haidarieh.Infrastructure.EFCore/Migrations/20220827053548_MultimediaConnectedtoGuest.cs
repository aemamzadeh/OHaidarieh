using Microsoft.EntityFrameworkCore.Migrations;

namespace Haidarieh.Infrastructure.EFCore.Migrations
{
    public partial class MultimediaConnectedtoGuest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "GuestId",
                table: "Tbl_Multimedia",
                type: "bigint",
                nullable: true,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Multimedia_GuestId",
                table: "Tbl_Multimedia",
                column: "GuestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Multimedia_Tbl_Guest_GuestId",
                table: "Tbl_Multimedia",
                column: "GuestId",
                principalTable: "Tbl_Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Multimedia_Tbl_Guest_GuestId",
                table: "Tbl_Multimedia");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Multimedia_GuestId",
                table: "Tbl_Multimedia");

            migrationBuilder.DropColumn(
                name: "GuestId",
                table: "Tbl_Multimedia");
        }
    }
}
