using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guildmate.Data;
using Guildmate.Models;
using Guildmate.Models.ViewModels.GuildViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Guildmate.Controllers
{
    public class GuildsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public GuildsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Guilds
        [Route("Guilds/{server}/{filter}")]
        public async Task<ActionResult> Index(int server, string searchString, string filter)
        {
            var user = await GetCurrentUserAsync();
            var guilds = await _context.Guild
                .Where(g => g.ServerId == server)
                .Include(f => f.Faction)
                .Include(s => s.Server)
                .ToListAsync();


            if (searchString != null)
            {
                guilds = await _context.Guild
                    .Where(g => g.Name.Contains(searchString))
                    .Include(f => f.Faction)
                    .Include(s => s.Server)
                    .ToListAsync();

                return View(guilds);
            }

            switch (filter)
            {

                case "horde":
                    guilds = await _context.Guild
                        .Where(f => f.FactionId == 2)
                        .Include(s => s.Server)
                        .ToListAsync();
                    break;
                case "alliance":
                    guilds = await _context.Guild
                        .Where(f => f.FactionId == 1)
                        .Include(s => s.Server)
                        .ToListAsync();
                    break;
                case "all":
                    guilds = await _context.Guild
                        .Include(f => f.Faction)
                        .Include(s => s.Server)
                        .ToListAsync();
                    break;
            }
            return View(guilds);
        }

        // GET: Guilds/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var user = await GetCurrentUserAsync();
            var CurrentUser = await _context.ApplicationUser.Include(c => c.Characters).FirstOrDefaultAsync(au => au.Id == user.Id);
            var character = CurrentUser.Characters.First();
            var guild = await _context.Guild.Include(s => s.Server).Include(f => f.Faction).Include(c => c.Characters).FirstOrDefaultAsync(g => g.GuildId == character.GuildId);

           
           
            return View(guild);
        }

        // GET: Guilds/Create
        public async Task<ActionResult> Create()
        {
            var servers = await _context.Server
                .Select(s => new SelectListItem() { Text = s.Name, Value = s.ServerId.ToString() })
                .ToListAsync();
            var factions = await _context.Faction
                .Select(f => new SelectListItem() { Text = f.Name, Value = f.FactionId.ToString() })
                .ToListAsync();
            var viewModel = new GuildCreateViewModel();
            viewModel.ServerOptions = servers;
            viewModel.FactionOptions = factions;
            return View(viewModel);
        }

        // POST: Guilds/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(GuildCreateViewModel guildCreateViewModel)
        {
            try
            {
                var user = await GetCurrentUserAsync();

                var guild = new Guild
                {

                    Name = guildCreateViewModel.Name,
                    ServerId = guildCreateViewModel.ServerId,
                    FactionId = guildCreateViewModel.FactionId,

                };

                _context.Guild.Add(guild);



                var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);

                userCharacter.Guild = guild;
                userCharacter.RankId = 1;

                _context.Character.Update(userCharacter);


                await _context.SaveChangesAsync();
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Details));
            }
            catch(Exception ex)


            {
                Console.WriteLine("{0} Exception caught.", ex);
                return View();
            }
        }

        // GET: Guilds/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Guilds/Edit/5
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

        // GET: Guilds/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Guilds/Delete/5
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