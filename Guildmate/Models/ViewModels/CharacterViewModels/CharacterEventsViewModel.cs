using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models.ViewModels.CharacterViewModels
{
    public class CharacterEventsViewModel
    {
        [Key]
        public int CharacterEventId { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }


        public int? CharacterId { get; set; }
        public Character Character { get; set; }

        public int RoleId { get; set; }

        public List<SelectListItem> RoleOptions { get; set; }
    }
}
