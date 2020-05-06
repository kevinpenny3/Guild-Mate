using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [Required]
        public int MaxAttendees { get; set; }

        [Required]
        public int GuildId { get; set; }
        public Guild Guild { get; set; }

        public List<CharacterEvent> CharacterEvents { get; set; }
    }
}
