using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models.ViewModels.CharacterViewModels
{
    public class CharacterEventsViewModel
    {
        public int EventId { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public int MaxAttendees { get; set; }

        public int GuildId { get; set; }
        public Guild Guild { get; set; }

        public List<CharacterEvent> CharacterEvents { get; set; }
        public List<Character> Characters { get; set; }
        public Character character { get; set; }
    }
}
