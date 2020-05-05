using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class CharacterEvent
    {
        [Key]
        public int CharacterEventId { get; set; }
        public int EventId { get; set; }
        public int CharacterId { get; set; }
        public int RoleId { get; set; }
    }
}
