using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Class
    {
        [Key]
        public int ClassId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Icon { get; set; }
        public string Color { get; set; }

        public List<ClassRace> ClassRaces { get; set; }
    }
}
