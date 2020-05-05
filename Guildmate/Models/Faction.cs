using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Faction
    {
        [Key]
        public int FactionId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
