using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Guildmate.Models.ViewModels.CharacterViewModels
{
    public class CharacterCreateViewModel
    {

        [Key]
        public int CharacterId { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int ClassRaceId { get; set; }

        public ClassRace ClassRace { get; set; }

        public Faction Faction { get; set; }
        public int FactionId { get; set; }

        public Class Class { get; set; }
        public int ClassId { get; set; }


        public Race Race { get; set; }
        public int RaceId { get; set; }



        public List<SelectListItem> FactionOptions { get; set; }
        public List<SelectListItem> RaceOptions { get; set; }
        public List<SelectListItem> ClassOptions { get; set; }





        //public List<SelectListItem> AllianceRaceOptions { get; set; }
        //public List<SelectListItem> HordeRaceOptions { get; set; }
        //public List<SelectListItem> HumanOptions { get; set; }
        //public List<SelectListItem> DwarfOptions { get; set; }
        //public List<SelectListItem> NightElfOptions { get; set; }
        //public List<SelectListItem> GnomeOptions { get; set; }
        //public List<SelectListItem> UndeadOptions { get; set; }
        //public List<SelectListItem> TaurenOptions { get; set; }
        //public List<SelectListItem> OrcOptions { get; set; }
        //public List<SelectListItem> TrollOptions { get; set; }

    }

}
