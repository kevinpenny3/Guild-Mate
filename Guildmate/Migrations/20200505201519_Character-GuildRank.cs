using Microsoft.EntityFrameworkCore.Migrations;

namespace Guildmate.Migrations
{
    public partial class CharacterGuildRank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GuildId",
                table: "Character");

            migrationBuilder.DropColumn(
                name: "RankId",
                table: "Character");

            migrationBuilder.AddColumn<int>(
                name: "GuildRankId",
                table: "Character",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31a8e5b7-2a79-4c18-89be-15933cd4f4a1", "AQAAAAEAACcQAAAAEGcGkNjVvMLaXcmCFBaTi6fUknXunFNqECAWP+CfFTWLEdBDEuC6JujLahPGOQcEKQ==" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 1,
                column: "GuildRankId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Server_RegionId",
                table: "Server",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Race_FactionId",
                table: "Race",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CharacterId",
                table: "Item",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemTypeId",
                table: "Item",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildRank_GuildId",
                table: "GuildRank",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_GuildRank_RankId",
                table: "GuildRank",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Guild_FactionId",
                table: "Guild",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Guild_ServerId",
                table: "Guild",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_GuildId",
                table: "Event",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRace_ClassId",
                table: "ClassRace",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRace_RaceId",
                table: "ClassRace",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEvent_CharacterId",
                table: "CharacterEvent",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEvent_EventId",
                table: "CharacterEvent",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterEvent_RoleId",
                table: "CharacterEvent",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_ClassId",
                table: "Character",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_FactionId",
                table: "Character",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_GuildRankId",
                table: "Character",
                column: "GuildRankId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_RaceId",
                table: "Character",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_BankItem_BankId",
                table: "BankItem",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankItem_ItemId",
                table: "BankItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_CharacterId",
                table: "Bank",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Bank_GuildId",
                table: "Bank",
                column: "GuildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_Character_CharacterId",
                table: "Bank",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bank_Guild_GuildId",
                table: "Bank",
                column: "GuildId",
                principalTable: "Guild",
                principalColumn: "GuildId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankItem_Bank_BankId",
                table: "BankItem",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "BankId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BankItem_Item_ItemId",
                table: "BankItem",
                column: "ItemId",
                principalTable: "Item",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Class_ClassId",
                table: "Character",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Faction_FactionId",
                table: "Character",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_GuildRank_GuildRankId",
                table: "Character",
                column: "GuildRankId",
                principalTable: "GuildRank",
                principalColumn: "GuildRankId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Character_Race_RaceId",
                table: "Character",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEvent_Character_CharacterId",
                table: "CharacterEvent",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEvent_Event_EventId",
                table: "CharacterEvent",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEvent_Role_RoleId",
                table: "CharacterEvent",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRace_Class_ClassId",
                table: "ClassRace",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRace_Race_RaceId",
                table: "ClassRace",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "RaceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Guild_GuildId",
                table: "Event",
                column: "GuildId",
                principalTable: "Guild",
                principalColumn: "GuildId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guild_Faction_FactionId",
                table: "Guild",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Guild_Server_ServerId",
                table: "Guild",
                column: "ServerId",
                principalTable: "Server",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuildRank_Guild_GuildId",
                table: "GuildRank",
                column: "GuildId",
                principalTable: "Guild",
                principalColumn: "GuildId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GuildRank_Rank_RankId",
                table: "GuildRank",
                column: "RankId",
                principalTable: "Rank",
                principalColumn: "RankId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Character_CharacterId",
                table: "Item",
                column: "CharacterId",
                principalTable: "Character",
                principalColumn: "CharacterId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_ItemType_ItemTypeId",
                table: "Item",
                column: "ItemTypeId",
                principalTable: "ItemType",
                principalColumn: "ItemTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Race_Faction_FactionId",
                table: "Race",
                column: "FactionId",
                principalTable: "Faction",
                principalColumn: "FactionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Server_Region_RegionId",
                table: "Server",
                column: "RegionId",
                principalTable: "Region",
                principalColumn: "RegionId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bank_Character_CharacterId",
                table: "Bank");

            migrationBuilder.DropForeignKey(
                name: "FK_Bank_Guild_GuildId",
                table: "Bank");

            migrationBuilder.DropForeignKey(
                name: "FK_BankItem_Bank_BankId",
                table: "BankItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BankItem_Item_ItemId",
                table: "BankItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Class_ClassId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Faction_FactionId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_GuildRank_GuildRankId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_Character_Race_RaceId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEvent_Character_CharacterId",
                table: "CharacterEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEvent_Event_EventId",
                table: "CharacterEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEvent_Role_RoleId",
                table: "CharacterEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassRace_Class_ClassId",
                table: "ClassRace");

            migrationBuilder.DropForeignKey(
                name: "FK_ClassRace_Race_RaceId",
                table: "ClassRace");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Guild_GuildId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_Guild_Faction_FactionId",
                table: "Guild");

            migrationBuilder.DropForeignKey(
                name: "FK_Guild_Server_ServerId",
                table: "Guild");

            migrationBuilder.DropForeignKey(
                name: "FK_GuildRank_Guild_GuildId",
                table: "GuildRank");

            migrationBuilder.DropForeignKey(
                name: "FK_GuildRank_Rank_RankId",
                table: "GuildRank");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Character_CharacterId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_ItemType_ItemTypeId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Race_Faction_FactionId",
                table: "Race");

            migrationBuilder.DropForeignKey(
                name: "FK_Server_Region_RegionId",
                table: "Server");

            migrationBuilder.DropIndex(
                name: "IX_Server_RegionId",
                table: "Server");

            migrationBuilder.DropIndex(
                name: "IX_Race_FactionId",
                table: "Race");

            migrationBuilder.DropIndex(
                name: "IX_Item_CharacterId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_ItemTypeId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_GuildRank_GuildId",
                table: "GuildRank");

            migrationBuilder.DropIndex(
                name: "IX_GuildRank_RankId",
                table: "GuildRank");

            migrationBuilder.DropIndex(
                name: "IX_Guild_FactionId",
                table: "Guild");

            migrationBuilder.DropIndex(
                name: "IX_Guild_ServerId",
                table: "Guild");

            migrationBuilder.DropIndex(
                name: "IX_Event_GuildId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_ClassRace_ClassId",
                table: "ClassRace");

            migrationBuilder.DropIndex(
                name: "IX_ClassRace_RaceId",
                table: "ClassRace");

            migrationBuilder.DropIndex(
                name: "IX_CharacterEvent_CharacterId",
                table: "CharacterEvent");

            migrationBuilder.DropIndex(
                name: "IX_CharacterEvent_EventId",
                table: "CharacterEvent");

            migrationBuilder.DropIndex(
                name: "IX_CharacterEvent_RoleId",
                table: "CharacterEvent");

            migrationBuilder.DropIndex(
                name: "IX_Character_ClassId",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_FactionId",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_GuildRankId",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_Character_RaceId",
                table: "Character");

            migrationBuilder.DropIndex(
                name: "IX_BankItem_BankId",
                table: "BankItem");

            migrationBuilder.DropIndex(
                name: "IX_BankItem_ItemId",
                table: "BankItem");

            migrationBuilder.DropIndex(
                name: "IX_Bank_CharacterId",
                table: "Bank");

            migrationBuilder.DropIndex(
                name: "IX_Bank_GuildId",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "GuildRankId",
                table: "Character");

            migrationBuilder.AddColumn<int>(
                name: "GuildId",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RankId",
                table: "Character",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "34e3b743-44b9-4ac2-9a1a-a117e4019c79", "AQAAAAEAACcQAAAAEAdZGGgXeREUf9xRSSGKhWKLW3h1Pp1UwCSAGLdKXM1YJTwy37sHJ7l72uhfDimhDw==" });

            migrationBuilder.UpdateData(
                table: "Character",
                keyColumn: "CharacterId",
                keyValue: 1,
                columns: new[] { "GuildId", "RankId" },
                values: new object[] { 1, 1 });
        }
    }
}
