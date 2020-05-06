using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Rank
    {
        [Key]
        public int RankId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public bool Permissions { get; set; }
    }
}
