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
        public int RaceId { get; set; }
        public int GuildId { get; set; }
        public int FactionId { get; set; }
        public int RankId { get; set; }
    }
}
