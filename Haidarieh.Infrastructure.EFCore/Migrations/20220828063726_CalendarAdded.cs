using Microsoft.EntityFrameworkCore.Migrations;

namespace Haidarieh.Infrastructure.EFCore.Migrations
{
    public partial class CalendarAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Multimedia_Tbl_Guest_GuestId",
                table: "Tbl_Multimedia");

            migrationBuilder.AlterColumn<long>(
                name: "GuestId",
                table: "Tbl_Multimedia",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "CalendarId",
                table: "Tbl_Ceremony",
                type: "bigint",
                nullable: true,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Tbl_Calendar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Calendar", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Ceremony_CalendarId",
                table: "Tbl_Ceremony",
                column: "CalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Ceremony_Tbl_Calendar_CalendarId",
                table: "Tbl_Ceremony",
                column: "CalendarId",
                principalTable: "Tbl_Calendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Multimedia_Tbl_Guest_GuestId",
                table: "Tbl_Multimedia",
                column: "GuestId",
                principalTable: "Tbl_Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Ceremony_Tbl_Calendar_CalendarId",
                table: "Tbl_Ceremony");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Multimedia_Tbl_Guest_GuestId",
                table: "Tbl_Multimedia");

            migrationBuilder.DropTable(
                name: "Tbl_Calendar");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Ceremony_CalendarId",
                table: "Tbl_Ceremony");

            migrationBuilder.DropColumn(
                name: "CalendarId",
                table: "Tbl_Ceremony");

            migrationBuilder.AlterColumn<long>(
                name: "GuestId",
                table: "Tbl_Multimedia",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Multimedia_Tbl_Guest_GuestId",
                table: "Tbl_Multimedia",
                column: "GuestId",
                principalTable: "Tbl_Guest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
