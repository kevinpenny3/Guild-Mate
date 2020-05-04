using System;
using System.Collections.Generic;
using System.Text;
using Guildmate.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Guildmate.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<BankItem> BankItem { get; set; }
        public DbSet<Character> Character { get; set; }
        public DbSet<CharacterEvent> CharacterEvent { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<ClassRace> ClassRace { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Faction> Faction { get; set; }
        public DbSet<Guild> Guild { get; set; }
        public DbSet<GuildRank> GuildRank { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemType> ItemType { get; set; }
        public DbSet<Race> Race { get; set; }
        public DbSet<Rank> Rank { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Server> Server { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Admin",
                LastName = "Admin",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin123!");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<Faction>().HasData(
                new Faction()
                {
                    FactionId = 1,
                    Name = "Alliance",
                },
                new Faction()
                {
                    FactionId = 2,
                    Name = "Horde",
                }
            );

            modelBuilder.Entity<Race>().HasData(
                new Race()
                {
                    RaceId = 1,
                    Name = "Human",
                    FactionId = 1
                },
                new Race()
                {
                    RaceId = 2,
                    Name = "Dwarf",
                    FactionId = 1
                },
                new Race()
                {
                    RaceId = 3,
                    Name = "Night Elf",
                    FactionId = 1
                },
                new Race()
                {
                    RaceId = 4,
                    Name = "Gnome",
                    FactionId = 1
                },
                new Race()
                {
                    RaceId = 5,
                    Name = "Undead",
                    FactionId = 2
                },
                new Race()
                {
                    RaceId = 6,
                    Name = "Tauren",
                    FactionId = 2
                },
                new Race()
                {
                    RaceId = 7,
                    Name = "Orc",
                    FactionId = 2
                },
                new Race()
                {
                    RaceId = 8,
                    Name = "Troll",
                    FactionId = 2
                }
                );

            modelBuilder.Entity<Class>().HasData(
                new Class()
                {
                    ClassId = 1,
                    Name = "Druid",
                    Color = "Orange"
                },
                new Class()
                {
                    ClassId = 2,
                    Name = "Hunter",
                    Color = "Green"
                },
                new Class()
                {
                    ClassId = 3,
                    Name = "Mage",
                    Color = "Light Blue"
                },
                new Class()
                {
                    ClassId = 4,
                    Name = "Paladin",
                    Color = "Pink"
                },
                new Class()
                {
                    ClassId = 5,
                    Name = "Priest",
                    Color = "White"
                },
                new Class()
                {
                    ClassId = 6,
                    Name = "Rogue",
                    Color = "Yellow"
                },
                new Class()
                {
                    ClassId = 7,
                    Name = "Shaman",
                    Color = "Blue"
                },
                new Class()
                {
                    ClassId = 8,
                    Name = "Warlock",
                    Color = "Purple"
                },
                new Class()
                {
                    ClassId = 9,
                    Name = "Warrior",
                    Color = "Light Brown"
                }
                );
            modelBuilder.Entity<ClassRace>().HasData(
                new ClassRace()
                {
                    ClassRaceId = 1,
                    RaceId = 1,
                    ClassId = 9
                },
                new ClassRace()
                {
                    ClassRaceId = 2,
                    RaceId = 1,
                    ClassId = 6
                },
                new ClassRace()
                {
                    ClassRaceId = 3,
                    RaceId = 1,
                    ClassId = 3
                },
                new ClassRace()
                {
                    ClassRaceId = 4,
                    RaceId = 1,
                    ClassId = 4
                },
                new ClassRace()
                {
                    ClassRaceId = 6,
                    RaceId = 1,
                    ClassId = 5
                },
                new ClassRace()
                {
                    ClassRaceId = 7,
                    RaceId = 1,
                    ClassId = 8
                },
                new ClassRace()
                {
                    ClassRaceId = 8,
                    RaceId = 2,
                    ClassId = 9
                },
                new ClassRace()
                {
                    ClassRaceId = 9,
                    RaceId = 2,
                    ClassId = 6
                },
                new ClassRace()
                {
                    ClassRaceId = 10,
                    RaceId = 2,
                    ClassId = 2
                },
                new ClassRace()
                {
                    ClassRaceId = 11,
                    RaceId = 2,
                    ClassId = 4
                },
                new ClassRace()
                {
                    ClassRaceId = 12,
                    RaceId = 2,
                    ClassId = 5
                },
                new ClassRace()
                {
                    ClassRaceId = 13,
                    RaceId = 3,
                    ClassId = 9
                },
                new ClassRace()
                {
                    ClassRaceId = 14,
                    RaceId = 3,
                    ClassId = 6
                },
                new ClassRace()
                {
                    ClassRaceId = 15,
                    RaceId = 3,
                    ClassId = 2
                },
                new ClassRace()
                {
                    ClassRaceId = 16,
                    RaceId = 3,
                    ClassId = 1
                },
                new ClassRace()
                {
                    ClassRaceId = 17,
                    RaceId = 3,
                    ClassId = 5
                },
                new ClassRace()
                {
                    ClassRaceId = 18,
                    RaceId = 4,
                    ClassId = 9
                },
                new ClassRace()
                {
                    ClassRaceId = 19,
                    RaceId = 4,
                    ClassId = 6
                },
                new ClassRace()
                {
                    ClassRaceId = 20,
                    RaceId = 4,
                    ClassId = 8
                },
                new ClassRace()
                {
                    ClassRaceId = 20,
                    RaceId = 4,
                    ClassId = 3
                },
                new ClassRace()
                {
                    ClassRaceId = 21,
                    RaceId = 5,
                    ClassId = 9
                },
                new ClassRace()
                {
                    ClassRaceId = 22,
                    RaceId = 5,
                    ClassId = 6
                },
                new ClassRace()
                {
                    ClassRaceId = 22,
                    RaceId = 5,
                    ClassId = 5
                },
                new ClassRace()
                {
                    ClassRaceId = 23,
                    RaceId = 5,
                    ClassId = 3
                },
                new ClassRace()
                {
                    ClassRaceId = 24,
                    RaceId = 5,
                    ClassId = 8
                },
                new ClassRace()
                {
                    ClassRaceId = 25,
                    RaceId = 6,
                    ClassId = 9
                },
                new ClassRace()
                {
                    ClassRaceId = 26,
                    RaceId = 6,
                    ClassId = 2
                },
                new ClassRace()
                {
                    ClassRaceId = 27,
                    RaceId = 6,
                    ClassId = 7
                },
                new ClassRace()
                {
                    ClassRaceId = 28,
                    RaceId = 6,
                    ClassId = 1
                },
                new ClassRace()
                {
                    ClassRaceId = 29,
                    RaceId = 7,
                    ClassId = 2
                },
                new ClassRace()
                {
                    ClassRaceId = 30,
                    RaceId = 7,
                    ClassId = 9
                },
                new ClassRace()
                {
                    ClassRaceId = 31,
                    RaceId = 7,
                    ClassId = 6
                },
                new ClassRace()
                {
                    ClassRaceId = 32,
                    RaceId = 7,
                    ClassId = 7
                },
                new ClassRace()
                {
                    ClassRaceId = 33,
                    RaceId = 7,
                    ClassId = 8
                },
                new ClassRace()
                {
                    ClassRaceId = 34,
                    RaceId = 8,
                    ClassId = 7
                },
                new ClassRace()
                {
                    ClassRaceId = 35,
                    RaceId = 8,
                    ClassId = 9
                },
                new ClassRace()
                {
                    ClassRaceId = 36,
                    RaceId = 8,
                    ClassId = 6
                },
                new ClassRace()
                {
                    ClassRaceId = 37,
                    RaceId = 8,
                    ClassId = 5
                },
                new ClassRace()
                {
                    ClassRaceId = 38,
                    RaceId = 8,
                    ClassId = 2
                },
                new ClassRace()
                {
                    ClassRaceId = 39,
                    RaceId = 8,
                    ClassId = 3
                }
                );

            modelBuilder.Entity<Region>().HasData(
                new Region()
                {
                    RegionId = 1,
                    Name = "US East"
                },
                new Region()
                {
                    RegionId = 2,
                    Name = "US West"
                }
                );
            modelBuilder.Entity<Rank>().HasData(
                new Rank()
                {
                    RankId = 1,
                    Name = "Guild Master",
                    Permissions = true
                },
                new Rank()
                {
                    RankId = 2,
                    Name = "Member",
                    Permissions = false
                }
                );
            modelBuilder.Entity<Character>().HasData(
                new Character()
                {
                    CharacterId = 1,
                    UserId = user.Id,
                    Name = "Testtoon",
                    RaceId = 1,
                    ClassId = 9,
                    GuildId = 1,
                    FactionId = 1,
                    RankId = 1
                }
                );
            modelBuilder.Entity<Guild>().HasData(
                new Guild()
                {
                    GuildId = 1,
                    Name = "Test Guild",
                    ServerId = 1,
                    FactionId = 1,
                    CharacterId = 1
                }
                );
            modelBuilder.Entity<Server>().HasData(
                new Server()
                {
                    ServerId = 1,
                    Name = "Incendius",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 2,
                    Name = "Faerlina",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 3,
                    Name = "Bloodsail Buccaneers",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 4,
                    Name = "Westfall",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 5,
                    Name = "Deviate Delight",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 6,
                    Name = "Benediction",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 7,
                    Name = "Ashkandi",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 8,
                    Name = "Heartseeker",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 9,
                    Name = "Kirtonos",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 10,
                    Name = "Skeram",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 11,
                    Name = "Stalagg",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 12,
                    Name = "Thalnos",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 13,
                    Name = "Windseeker",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 14,
                    Name = "Earthfury",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 15,
                    Name = "Kromcrush",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 16,
                    Name = "Mankrik",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 17,
                    Name = "Netherwind",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 18,
                    Name = "Herod",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 19,
                    Name = "Pagle",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 20,
                    Name = "Sulfuras",
                    RegionId = 1
                },
                new Server()
                {
                    ServerId = 21,
                    Name = "Kurinnaxx",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 22,
                    Name = "Whitemane",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 23,
                    Name = "Anathema",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 24,
                    Name = "Arcanite Reaper",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 25,
                    Name = "Azuresong",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 26,
                    Name = "Myzrael",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 27,
                    Name = "Old Blanchy",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 28,
                    Name = "Smolderweb",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 29,
                    Name = "Atiesh",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 30,
                    Name = "Bigglesworth",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 31,
                    Name = "Blaumeux",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 32,
                    Name = "Rattlegore",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 33,
                    Name = "Thunderfury",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 34,
                    Name = "Fairbanks",
                    RegionId = 2
                },
                new Server()
                {
                    ServerId = 35,
                    Name = "Grobbulus",
                    RegionId = 2
                }
                );
            modelBuilder.Entity<Bank>().HasData(
                new Bank()
                {
                    BankId = 1,
                    CharacterId = 1,
                    GuildId = 1,
                    InventorySpace = 25
                }
                );
            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    RoleId = 1,
                    Name = "Tank",
                },
                new Role()
                {
                    RoleId = 2,
                    Name = "DPS",
                },
                new Role()
                {
                    RoleId = 3,
                    Name = "Healer",
                }
                );
            modelBuilder.Entity<ItemType>().HasData(
                new ItemType()
                {
                    ItemTypeId = 1,
                    Name = "Herb"
                },
                new ItemType()
                {
                    ItemTypeId = 2,
                    Name = "Cloth"
                },
                new ItemType()
                {
                    ItemTypeId = 3,
                    Name = "Ore"
                },
                new ItemType()
                {
                    ItemTypeId = 4,
                    Name = "Enchanting"
                },
                new ItemType()
                {
                    ItemTypeId = 5,
                    Name = "Armor"
                },
                new ItemType()
                {
                    ItemTypeId = 7,
                    Name = "Weapon"
                },
                new ItemType()
                {
                    ItemTypeId = 8,
                    Name = "Misc"
                },
                new ItemType()
                {
                    ItemTypeId = 9,
                    Name = "Food"
                },
                new ItemType()
                {
                    ItemTypeId = 10,
                    Name = "Currency"
                },
                new ItemType()
                {
                    ItemTypeId = 11,
                    Name = "Container"
                },
                new ItemType()
                {
                    ItemTypeId = 12,
                    Name = "Crafting Material"
                },
                new ItemType()
                {
                    ItemTypeId = 13,
                    Name = "Reputation"
                },
                new ItemType()
                {
                    ItemTypeId = 14,
                    Name = "Crafted Item"
                }
                );
            modelBuilder.Entity<Item>().HasData(
                new Item()
                {
                    ItemId = 1,
                    Name = "Linen Cloth",
                    Quantity = 1,
                    CharacterId = 1,
                    ItemTypeId = 2
                }
                );
            modelBuilder.Entity<BankItem>().HasData(
                new BankItem()
                {
                    BankItemId = 1,
                    BankId = 1,
                    ItemId = 1
                }
                );
            modelBuilder.Entity<Event>().HasData(
                new Event()
                {
                    EventId = 1,
                    Name = "Test Event",
                    MaxAttendees = 40,
                    GuildId = 1
                }
                );
            modelBuilder.Entity<CharacterEvent>().HasData(
                new CharacterEvent()
                {
                    CharacterEventId = 1,
                    CharacterId = 1,
                    EventId = 1,
                    RoleId = 1
                }
                );



        }

    }
}
