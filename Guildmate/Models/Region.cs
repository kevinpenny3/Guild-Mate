using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Region
    {
        [Key]
        public int RegionId { get; set; }
        public string Name { get; set; }
    }
}
