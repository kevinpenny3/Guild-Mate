using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Server
    {
        [Key]
        public int ServerId { get; set; }
        public string Name { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}
