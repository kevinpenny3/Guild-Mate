using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guildmate.Data;
using Guildmate.Models;
using Guildmate.Models.ViewModels.CharacterViewModels;
using Guildmate.Models.ViewModels.GuildViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Guildmate.Controllers
{
    public class CharactersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CharactersController(ApplicationDbContext context, UserManager<ApplicationUser> usermanager)
        {
            _context = context;
            _userManager = usermanager;
        }
        // GET: Characters
        public async Task<ActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var characters = await _context.Character
                .Include(cr => cr.ClassRace)
                .ThenInclude(c => c.Class)
                .Include(cr => cr.ClassRace)
                .ThenInclude(r => r.Race)
                    .ThenInclude(f => f.Faction)
                .Include(g => g.Guild)
                .FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);
            return View(characters);
        }

        // GET: Characters/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Characters/Create
        public async Task<ActionResult> Create()
        {


            var factions = await _context.Faction
                .Select(f => new SelectListItem() { Text = f.Name, Value = f.FactionId.ToString() })
               .ToListAsync();
            var races = await _context.Race
                .Select(r => new SelectListItem() { Text = r.Name, Value = r.RaceId.ToString() })
                .ToListAsync();
            var classes = await _context.Class
                .Select(c => new SelectListItem() { Text = c.Name, Value = c.ClassId.ToString() })
                .ToListAsync();
            var viewModel = new CharacterCreateViewModel();
            viewModel.FactionOptions = factions;
            viewModel.RaceOptions = races;
            viewModel.ClassOptions = classes;
            return View(viewModel);








            //var humanClasses = await _context.ClassRace
            //    .Where(cr => cr.RaceId == 1)
            //    .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
            //    .ToListAsync();
            //var dwarfClasses = await _context.ClassRace
            //    .Where(cr => cr.RaceId == 2)
            //    .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
            //    .ToListAsync();
            //var nightElfClasses = await _context.ClassRace
            //    .Where(cr => cr.RaceId == 3)
            //    .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
            //    .ToListAsync();
            //var gnomeClasses = await _context.ClassRace
            //    .Where(cr => cr.RaceId == 4)
            //    .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
            //    .ToListAsync();
            //var undeadClasses = await _context.ClassRace
            //    .Where(cr => cr.RaceId == 5)
            //    .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
            //    .ToListAsync();
            //var taurenClasses = await _context.ClassRace
            //    .Where(cr => cr.RaceId == 6)
            //    .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
            //    .ToListAsync();
            //var orcClasses = await _context.ClassRace
            //    .Where(cr => cr.RaceId == 7)
            //    .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
            //    .ToListAsync();
            //var trollClasses = await _context.ClassRace
            //    .Where(cr => cr.RaceId == 8)
            //    .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
            //    .ToListAsync();
            //viewModel.AllianceRaceOptions = allianceRaces;
            //viewModel.HordeRaceOptions = hordeRaces;
            //viewModel.HumanOptions = humanClasses;
            //viewModel.DwarfOptions = dwarfClasses;
            //viewModel.NightElfOptions = nightElfClasses;
            //viewModel.GnomeOptions = gnomeClasses;
            //viewModel.UndeadOptions = undeadClasses;
            //viewModel.TaurenOptions = taurenClasses;
            //viewModel.OrcOptions = orcClasses;
            //viewModel.TrollOptions = trollClasses;

            //return View(viewModel);
        }

        // POST: Characters/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CharacterCreateViewModel characterCreateViewModel)
        {
            try
            {

                var user = await GetCurrentUserAsync();
                var ClassRaceId = await _context.ClassRace.FirstOrDefaultAsync(c => c.ClassId == characterCreateViewModel.ClassId && c.RaceId == characterCreateViewModel.RaceId);
                var character = new Character
                {
                    ApplicationUserId = user.Id,
                    Name = characterCreateViewModel.Name,
                    ClassRaceId = ClassRaceId.ClassRaceId,
                };

                _context.Character.Add(character);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(nameof(Index));
            }
        }

        // GET: Characters/Edit/5
        public async Task<ActionResult> Edit(int CharacterId)
        {
            var user = await GetCurrentUserAsync();

            var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);
            var viewModel = new CharacterGuildViewModel
            {
                CharacterId = userCharacter.CharacterId,
                GuildId = userCharacter.GuildId,
                RankId = userCharacter.RankId
            };
            return View(viewModel);
        }

        // POST: Characters/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> JoinGuild(int id, CharacterGuildViewModel characterGuildViewModel)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);

                userCharacter.GuildId = characterGuildViewModel.GuildId;
                userCharacter.RankId = 2;

                _context.Character.Update(userCharacter);

                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Guilds");

            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> RemoveFromGuild(int id)
        {
            var user = await GetCurrentUserAsync();

            var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);
            var character = await _context.Character.FirstOrDefaultAsync(c => c.CharacterId == id);
            return View(character);
        }

        // POST: Characters/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RemoveFromGuild(int id, CharacterGuildViewModel characterGuildViewModel)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);
                var character = await _context.Character.FirstOrDefaultAsync(c => c.CharacterId == id);

                character.GuildId = null;
                character.RankId = null;

                _context.Character.Update(character);

                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Guilds");

            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> LeaveGuild(int id)
        {
            var user = await GetCurrentUserAsync();

            var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);
            var character = await _context.Character.FirstOrDefaultAsync(c => c.CharacterId == id);
            return View(character);
        }

        // POST: Characters/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LeaveGuild(int id, CharacterGuildViewModel characterGuildViewModel)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);
                var character = await _context.Character.FirstOrDefaultAsync(c => c.CharacterId == id);

                character.GuildId = null;
                character.RankId = null;

                _context.Character.Update(character);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }

        // GET: Characters/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Characters/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private async Task<ApplicationUser> GetCurrentUserAsync() => await _userManager.GetUserAsync(HttpContext.User);
    }
}