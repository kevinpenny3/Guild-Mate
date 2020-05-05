using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Bank
    {
        [Key]
        public int BankId { get; set; }
        public int CharacterId { get; set; }
        public int GuildId { get; set; }
        public int InventorySpace { get; set; }
    }
}
