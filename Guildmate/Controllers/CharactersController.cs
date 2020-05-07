using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guildmate.Data;
using Guildmate.Models;
using Guildmate.Models.ViewModels.CharacterViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
            var allianceRaces = await _context.Race
                .Where(f => f.FactionId == 1)
                .Select(r => new SelectListItem() { Text = r.Name, Value = r.RaceId.ToString() })
                .ToListAsync();
            var hordeRaces = await _context.Race
                .Where(f => f.FactionId == 2)
                .Select(r => new SelectListItem() { Text = r.Name, Value = r.RaceId.ToString() })
                .ToListAsync();
            var humanClasses = await _context.ClassRace
                .Where(cr => cr.RaceId == 1)
                .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
                .ToListAsync();
            var dwarfClasses = await _context.ClassRace
                .Where(cr => cr.RaceId == 2)
                .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
                .ToListAsync();
            var nightElfClasses = await _context.ClassRace
                .Where(cr => cr.RaceId == 3)
                .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
                .ToListAsync();
            var gnomeClasses = await _context.ClassRace
                .Where(cr => cr.RaceId == 4)
                .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
                .ToListAsync();
            var undeadClasses = await _context.ClassRace
                .Where(cr => cr.RaceId == 5)
                .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
                .ToListAsync();
            var taurenClasses = await _context.ClassRace
                .Where(cr => cr.RaceId == 6)
                .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
                .ToListAsync();
            var orcClasses = await _context.ClassRace
                .Where(cr => cr.RaceId == 7)
                .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
                .ToListAsync();
            var trollClasses = await _context.ClassRace
                .Where(cr => cr.RaceId == 8)
                .Select(c => new SelectListItem() { Text = c.Class.Name, Value = c.ClassId.ToString() })
                .ToListAsync();


            var viewModel = new CharacterCreateViewModel();
            viewModel.FactionOptions = factions;
            viewModel.AllianceRaceOptions = allianceRaces;
            viewModel.HordeRaceOptions = hordeRaces;
            viewModel.HumanOptions = humanClasses;
            viewModel.DwarfOptions = dwarfClasses;
            viewModel.NightElfOptions = nightElfClasses;
            viewModel.GnomeOptions = gnomeClasses;
            viewModel.UndeadOptions = undeadClasses;
            viewModel.TaurenOptions = taurenClasses;
            viewModel.OrcOptions = orcClasses;
            viewModel.TrollOptions = trollClasses;

            return View(viewModel);
        }

        // POST: Characters/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CharacterCreateViewModel characterCreateViewModel)
        {
            try
            {
                var user = await GetCurrentUserAsync();

                var character = new Character
                {
                    Name = characterCreateViewModel.Name,
                    ClassRace = characterCreateViewModel.ClassRace,
                    GuildId = characterCreateViewModel.GuildId,
                    RankId = characterCreateViewModel.RankId,
                    InventorySpace = characterCreateViewModel.InventorySpace,
                };

                _context.Character.Add(character);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View(characterCreateViewModel);
            }
        }

        // GET: Characters/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Characters/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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