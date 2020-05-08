using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models.ViewModels.GuildViewModels
{
    public class GuildCreateViewModel
    {
        
        public int GuildId { get; set; }

        public string Name { get; set; }

        public int ServerId { get; set; }
        public Server Server { get; set; }

        public int FactionId { get; set; }
        public Faction Faction { get; set; }

        public string Banner { get; set; }

        public List<SelectListItem> ServerOptions { get; set; }
        public List<SelectListItem> FactionOptions { get; set; }

        public List<Server> Servers { get; set; }
    }
}
