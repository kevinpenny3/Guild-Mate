using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models.ViewModels.GuildViewModels
{
    public class GuildDeleteViewModel
    {
        public int GuildId { get; set; }

        public string Name { get; set; }

        public int ServerId { get; set; }
        public Server Server { get; set; }

        public int FactionId { get; set; }
        public Faction Faction { get; set; }

        public Character Character { get; set; }
        public List<Character> Characters { get; set; }
    }
}
