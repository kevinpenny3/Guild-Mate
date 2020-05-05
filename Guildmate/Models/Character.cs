using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Character
    {
        [Key]
        public int CharacterId { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

        public int RaceId { get; set; }
        public Race Race { get; set; }
        
        public int GuildRankId { get; set; }
        public GuildRank GuildRank { get; set; }


        public int? FactionId { get; set; }
        public Faction Faction { get; set; }

    }
}
