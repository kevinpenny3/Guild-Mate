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

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ClassRaceId { get; set; }
        public ClassRace ClassRace { get; set; }

        public int? GuildId { get; set; }
        public Guild Guild { get; set; }
        
        public int? RankId { get; set; }
        public Rank Rank { get; set; }

        public int? InventorySpace { get; set; }

        public List<BankItem> BankItems { get; set; }

        public List<CharacterEvent> CharacterEvents { get; set; }
        public List<Item> Items { get; set; }

    }
}
