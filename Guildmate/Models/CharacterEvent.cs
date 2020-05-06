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
        public Event Event { get; set; }

        
        public int? CharacterId { get; set; }
        public Character Character { get; set; }

        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public List<Role> Roles { get; set; }

    }
}
