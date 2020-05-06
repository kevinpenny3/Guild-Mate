using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Guildmate.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Faction",
                columns: table => new
                {
                    FactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faction", x => x.FactionId);
                });

            migrationBuilder.CreateTable(
                name: "ItemType",
                columns: table => new
                {
                    ItemTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemType", x => x.ItemTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    RankId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Permissions = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.RankId);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    RegionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Race",
                columns: table => new
                {
                    RaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    FactionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Race", x => x.RaceId);
                    table.ForeignKey(
                        name: "FK_Race_Faction_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Faction",
                        principalColumn: "FactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Server",
                columns: table => new
                {
                    ServerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    RegionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Server", x => x.ServerId);
                    table.ForeignKey(
                        name: "FK_Server_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ClassRace",
                columns: table => new
                {
                    ClassRaceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(nullable: false),
                    RaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRace", x => x.ClassRaceId);
                    table.ForeignKey(
                        name: "FK_ClassRace_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassRace_Race_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Race",
                        principalColumn: "RaceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Guild",
                columns: table => new
                {
                    GuildId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    ServerId = table.Column<int>(nullable: false),
                    FactionId = table.Column<int>(nullable: false),
                    Banner = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guild", x => x.GuildId);
                    table.ForeignKey(
                        name: "FK_Guild_Faction_FactionId",
                        column: x => x.FactionId,
                        principalTable: "Faction",
                        principalColumn: "FactionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Guild_Server_ServerId",
                        column: x => x.ServerId,
                        principalTable: "Server",
                        principalColumn: "ServerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Character",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    ClassRaceId = table.Column<int>(nullable: false),
                    GuildId = table.Column<int>(nullable: true),
                    RankId = table.Column<int>(nullable: true),
                    InventorySpace = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Character", x => x.CharacterId);
                    table.ForeignKey(
                        name: "FK_Character_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Character_ClassRace_ClassRaceId",
                        column: x => x.ClassRaceId,
                        principalTable: "ClassRace",
                        principalColumn: "ClassRaceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Character_Guild_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guild",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Character_Rank_RankId",
                        column: x => x.RankId,
                        principalTable: "Rank",
                        principalColumn: "RankId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    MaxAttendees = table.Column<int>(nullable: false),
                    GuildId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.EventId);
                    table.ForeignKey(
                        name: "FK_Event_Guild_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guild",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateRemoved = table.Column<DateTime>(nullable: true),
                    ItemTypeId = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Item_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_ItemType_ItemTypeId",
                        column: x => x.ItemTypeId,
                        principalTable: "ItemType",
                        principalColumn: "ItemTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankItem",
                columns: table => new
                {
                    BankItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    GuildId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankItem", x => x.BankItemId);
                    table.ForeignKey(
                        name: "FK_BankItem_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankItem_Guild_GuildId",
                        column: x => x.GuildId,
                        principalTable: "Guild",
                        principalColumn: "GuildId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BankItem_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterEvent",
                columns: table => new
                {
                    CharacterEventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventId = table.Column<int>(nullable: false),
                    CharacterId = table.Column<int>(nullable: true),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterEvent", x => x.CharacterEventId);
                    table.ForeignKey(
                        name: "FK_CharacterEvent_Character_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Character",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CharacterEvent_Event_EventId",
                        column: x => x.EventId,
                        principalTable: "Event",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Icon = table.Column<string>(nullable: true),
                    CharacterEventId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                    table.ForeignKey(
                        name: "FK_Role_CharacterEvent_CharacterEventId",
                        column: x => x.CharacterEventId,
                        principalTable: "CharacterEvent",
                        principalColumn: "CharacterEventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "953c627f-02a4-4f57-810c-785e1e774b91", "admin@admin.com", true, "Admin", "Admin", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJvA6s+gpEGVkL2/hL479fm8U3RW7Vmj6dySEKZp7eRNAQ+yO2viH4ushBpuGC+g7Q==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Class",
                columns: new[] { "ClassId", "Color", "Icon", "Name" },
                values: new object[,]
                {
                    { 9, "Light Brown", null, "Warrior" },
                    { 7, "Blue", null, "Shaman" },
                    { 6, "Yellow", null, "Rogue" },
                    { 5, "White", null, "Priest" },
                    { 8, "Purple", null, "Warlock" },
                    { 3, "Light Blue", null, "Mage" },
                    { 2, "Green", null, "Hunter" },
                    { 1, "Orange", null, "Druid" },
                    { 4, "Pink", null, "Paladin" }
                });

            migrationBuilder.InsertData(
                table: "Faction",
                columns: new[] { "FactionId", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, null, "Alliance" },
                    { 2, null, "Horde" }
                });

            migrationBuilder.InsertData(
                table: "ItemType",
                columns: new[] { "ItemTypeId", "Icon", "Name" },
                values: new object[,]
                {
                    { 10, null, "Currency" },
                    { 14, null, "Crafted Item" },
                    { 13, null, "Reputation" },
                    { 12, null, "Crafting Material" },
                    { 11, null, "Container" },
                    { 9, null, "Food" },
                    { 4, null, "Enchanting" },
                    { 7, null, "Weapon" },
                    { 5, null, "Armor" },
                    { 3, null, "Ore" },
                    { 2, null, "Cloth" },
                    { 1, null, "Herb" },
                    { 8, null, "Misc" }
                });

            migrationBuilder.InsertData(
                table: "Rank",
                columns: new[] { "RankId", "Name", "Permissions" },
                values: new object[,]
                {
                    { 1, "Guild Master", true },
                    { 2, "Member", false }
                });

            migrationBuilder.InsertData(
                table: "Region",
                columns: new[] { "RegionId", "Name" },
                values: new object[,]
                {
                    { 1, "US East" },
                    { 2, "US West" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "RoleId", "CharacterEventId", "Icon", "Name" },
                values: new object[,]
                {
                    { 2, null, null, "DPS" },
                    { 1, null, null, "Tank" },
                    { 3, null, null, "Healer" }
                });

            migrationBuilder.InsertData(
                table: "Item",
                columns: new[] { "ItemId", "CharacterId", "DateAdded", "DateRemoved", "ItemTypeId", "Name", "Quantity" },
                values: new object[] { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "Linen Cloth", 1 });

            migrationBuilder.InsertData(
                table: "Race",
                columns: new[] { "RaceId", "FactionId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Human" },
                    { 2, 1, "Dwarf" },
                    { 3, 1, "Night Elf" },
                    { 4, 1, "Gnome" },
                    { 5, 2, "Undead" },
                    { 6, 2, "Tauren" },
                    { 7, 2, "Orc" },
                    { 8, 2, "Troll" }
                });

            migrationBuilder.InsertData(
                table: "Server",
                columns: new[] { "ServerId", "Name", "RegionId" },
                values: new object[,]
                {
                    { 20, "Sulfuras", 1 },
                    { 21, "Kurinnaxx", 2 },
                    { 22, "Whitemane", 2 },
                    { 23, "Anathema", 2 },
                    { 24, "Arcanite Reaper", 2 },
                    { 25, "Azuresong", 2 },
                    { 26, "Myzrael", 2 },
                    { 30, "Bigglesworth", 2 },
                    { 28, "Smolderweb", 2 },
                    { 29, "Atiesh", 2 },
                    { 19, "Pagle", 1 },
                    { 31, "Blaumeux", 2 },
                    { 32, "Rattlegore", 2 },
                    { 33, "Thunderfury", 2 },
                    { 27, "Old Blanchy", 2 },
                    { 18, "Herod", 1 },
                    { 13, "Windseeker", 1 },
                    { 16, "Mankrik", 1 },
                    { 1, "Incendius", 1 },
                    { 2, "Faerlina", 1 },
                    { 3, "Bloodsail Buccaneers", 1 },
                    { 4, "Westfall", 1 },
                    { 5, "Deviate Delight", 1 },
                    { 6, "Benediction", 1 },
                    { 7, "Ashkandi", 1 },
                    { 8, "Heartseeker", 1 },
                    { 9, "Kirtonos", 1 },
                    { 10, "Skeram", 1 },
                    { 11, "Stalagg", 1 },
                    { 12, "Thalnos", 1 },
                    { 34, "Fairbanks", 2 },
                    { 14, "Earthfury", 1 },
                    { 15, "Kromcrush", 1 },
                    { 17, "Netherwind", 1 },
                    { 35, "Grobbulus", 2 }
                });

            migrationBuilder.InsertData(
                table: "ClassRace",
                columns: new[] { "ClassRaceId", "ClassId", "RaceId" },
                values: new object[,]
                {
                    { 1, 9, 1 },
                    { 23, 5, 5 },
                    { 24, 3, 5 },
                    { 25, 8, 5 },
                    { 26, 9, 6 },
                    { 27, 2, 6 },
                    { 28, 7, 6 },
                    { 29, 1, 6 },
                    { 30, 2, 7 },
                    { 31, 9, 7 },
                    { 32, 6, 7 },
                    { 33, 7, 7 },
                    { 34, 8, 7 },
                    { 35, 7, 8 },
                    { 36, 9, 8 },
                    { 37, 6, 8 },
                    { 38, 5, 8 },
                    { 39, 2, 8 },
                    { 22, 6, 5 },
                    { 40, 3, 8 },
                    { 21, 9, 5 },
                    { 19, 6, 4 },
                    { 2, 6, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 6, 5, 1 },
                    { 7, 8, 1 },
                    { 8, 9, 2 },
                    { 9, 6, 2 },
                    { 10, 2, 2 },
                    { 11, 4, 2 },
                    { 12, 5, 2 },
                    { 13, 9, 3 },
                    { 14, 6, 3 },
                    { 15, 2, 3 },
                    { 16, 1, 3 },
                    { 17, 5, 3 },
                    { 5, 3, 4 },
                    { 18, 9, 4 },
                    { 20, 8, 4 }
                });

            migrationBuilder.InsertData(
                table: "Guild",
                columns: new[] { "GuildId", "Banner", "FactionId", "Name", "ServerId" },
                values: new object[] { 1, null, 1, "Test Guild", 1 });

            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "CharacterId", "ApplicationUserId", "ClassRaceId", "GuildId", "InventorySpace", "Name", "RankId" },
                values: new object[] { 1, "00000000-ffff-ffff-ffff-ffffffffffff", 1, 1, null, "Testtoon", 1 });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "EventId", "EndDate", "GuildId", "MaxAttendees", "Name", "StartDate" },
                values: new object[] { 1, null, 1, 40, "Test Event", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "BankItem",
                columns: new[] { "BankItemId", "CharacterId", "GuildId", "ItemId" },
                values: new object[] { 1, 1, null, 1 });

            migrationBuilder.InsertData(
                table: "CharacterEvent",
                columns: new[] { "CharacterEventId", "CharacterId", "EventId", "RoleId" },
                values: new object[] { 1, 1, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BankItem_CharacterId",
                table: "BankItem",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_BankItem_GuildId",
                table: "BankItem",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_BankItem_ItemId",
                table: "BankItem",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_ApplicationUserId",
                table: "Character",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_ClassRaceId",
                table: "Character",
                column: "ClassRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_GuildId",
                table: "Character",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Character_RankId",
                table: "Character",
                column: "RankId");

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
                name: "IX_ClassRace_ClassId",
                table: "ClassRace",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRace_RaceId",
                table: "ClassRace",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Event_GuildId",
                table: "Event",
                column: "GuildId");

            migrationBuilder.CreateIndex(
                name: "IX_Guild_FactionId",
                table: "Guild",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Guild_ServerId",
                table: "Guild",
                column: "ServerId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_CharacterId",
                table: "Item",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_ItemTypeId",
                table: "Item",
                column: "ItemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Race_FactionId",
                table: "Race",
                column: "FactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CharacterEventId",
                table: "Role",
                column: "CharacterEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Server_RegionId",
                table: "Server",
                column: "RegionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterEvent_Role_RoleId",
                table: "CharacterEvent",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Character_AspNetUsers_ApplicationUserId",
                table: "Character");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEvent_Character_CharacterId",
                table: "CharacterEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_Event_Guild_GuildId",
                table: "Event");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEvent_Event_EventId",
                table: "CharacterEvent");

            migrationBuilder.DropForeignKey(
                name: "FK_CharacterEvent_Role_RoleId",
                table: "CharacterEvent");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BankItem");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "ItemType");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Character");

            migrationBuilder.DropTable(
                name: "ClassRace");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Race");

            migrationBuilder.DropTable(
                name: "Guild");

            migrationBuilder.DropTable(
                name: "Faction");

            migrationBuilder.DropTable(
                name: "Server");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "CharacterEvent");
        }
    }
}
