using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }


        public DateTime DateAdded { get; set; }
        public DateTime? DateRemoved { get; set; }


        [Required]
        public int ItemTypeId { get; set; }
        public ItemType ItemType { get; set; }

        public List<BankItem> BankItems { get; set; }
    }
}
