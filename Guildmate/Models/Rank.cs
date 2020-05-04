using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class Rank
    {
        public int RankId { get; set; }
        public string Name { get; set; }
        public bool Permissions { get; set; }
    }
}
