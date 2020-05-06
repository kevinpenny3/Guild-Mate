using Microsoft.EntityFrameworkCore.Migrations;

namespace Guildmate.Migrations
{
    public partial class FactionIdFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Faction_FactionId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Guild_Faction_FactionId",
                table: "Guild");

            migrationBuilder.AlterColumn<int>(
                name: "FactionId",
                table: "Guild",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FactionId",
                table: "Character",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8eef0b6e-22a8-4477-a876-d4f3dde10213", "AQAAAAEAACcQAAAAEHlyR/wigAhRPmS2HJeCvGusbG66z9wpFHIf/cy+SrSIoh7WtOMQJrpmrJ5HOoAA6A==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Faction_FactionId",
                table: "Character",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Guild_Faction_FactionId",
                table: "Guild",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_Faction_FactionId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Guild_Faction_FactionId",
                table: "Guild");

            migrationBuilder.AlterColumn<int>(
                name: "FactionId",
                table: "Guild",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FactionId",
                table: "Character",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31a8e5b7-2a79-4c18-89be-15933cd4f4a1", "AQAAAAEAACcQAAAAEGcGkNjVvMLaXcmCFBaTi6fUknXunFNqECAWP+CfFTWLEdBDEuC6JujLahPGOQcEKQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Faction_FactionId",
                table: "Character",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Guild_Faction_FactionId",
                table: "Guild",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
