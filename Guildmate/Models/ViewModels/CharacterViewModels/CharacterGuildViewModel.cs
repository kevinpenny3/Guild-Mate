using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models.ViewModels.CharacterViewModels
{
    public class CharacterGuildViewModel
    {

        public int CharacterId { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ClassRaceId { get; set; }
        public ClassRace ClassRace { get; set; }

        public int? GuildId { get; set; }
        public Guild Guild { get; set; }

        public int? RankId { get; set; }
        public Rank Rank { get; set; }

    }
}
