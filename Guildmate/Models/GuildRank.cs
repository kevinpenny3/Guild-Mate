using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models
{
    public class GuildRank
    {
        [Key]
        public int GuildRankId { get; set; }
        public int GuildId { get; set; }
        public int RankId { get; set; }
    }
}
