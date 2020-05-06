using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class BankItem
    {
        [Key]
        public int BankItemId { get; set; }

        [Required]
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        [Required]
        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
