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
                },
                new Region()
                {
                    RegionId = 3,
                    Name = "Oceanic"
                }
                new Region()
                {
                    RegionId = 4,
                    Name = "Latin America"
                },
                new Region()
                {
                    RegionId = 5,
                    Name = "Brazil"
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



        }

    }
}
