using System;
using System.Collections.Generic;
using System.Text;
using Guildmate.Models;
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

    }
}
