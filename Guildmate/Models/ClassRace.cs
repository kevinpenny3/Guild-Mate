using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class ClassRace
    {
        [Key]
        public int ClassRaceId { get; set; }
        public int ClassId { get; set; }
        public int RaceId { get; set; }
    }
}
