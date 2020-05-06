using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class ItemType
    {
        [Key]
        public int ItemTypeId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
