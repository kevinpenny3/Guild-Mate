using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Race
    {
        [Key]
        public int RaceId { get; set; }
        public string Name { get; set; }
        public int FactionId { get; set; }
    }
}
