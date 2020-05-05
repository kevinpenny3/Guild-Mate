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

        public int BankId { get; set; }
        public Bank Bank { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }
    }
}
