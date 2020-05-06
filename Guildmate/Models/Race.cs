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

        [Required]
        public string Name { get; set; }

        [Required]
        public int FactionId { get; set; }
        public Faction Faction { get; set; }

        public List<ClassRace> ClassRaces { get; set; }
    }
}
