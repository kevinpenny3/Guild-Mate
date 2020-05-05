using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Guild
    {
        [Key]
        public int GuildId { get; set; }
        public string Name { get; set; }
        public int CharacterId { get; set; }
        public int ServerId { get; set; }
        public int FactionId { get; set; }
        public string Banner { get; set; }

    }
}
