using Microsoft.EntityFrameworkCore.Migrations;

namespace Guildmate.Migrations
{
    public partial class FactionRestrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79e23d94-3820-4aa4-a3fd-9272abc703d1", "AQAAAAEAACcQAAAAEDploThuoW3xpZyzWKvwUI8Lx2hnuGUqLYq1vrmd6OG9jFtiybtQCNa5jbE2KVur8w==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8eef0b6e-22a8-4477-a876-d4f3dde10213", "AQAAAAEAACcQAAAAEHlyR/wigAhRPmS2HJeCvGusbG66z9wpFHIf/cy+SrSIoh7WtOMQJrpmrJ5HOoAA6A==" });
        }
    }
}
