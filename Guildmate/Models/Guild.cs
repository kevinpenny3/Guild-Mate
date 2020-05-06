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


        [Required]
        public string Name { get; set; }

        [Required]
        public int ServerId { get; set; }
        public Server Server { get; set; }

        [Required]
        public int FactionId { get; set; }
        public Faction Faction { get; set; }

        public string Banner { get; set; }


        public List<Character> Characters { get; set; }
        public List<Event> Events { get; set; }
        public List<BankItem> BankItems { get; set; }

    }
}
