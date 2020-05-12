using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guildmate.Data;
using Guildmate.Models;
using Guildmate.Models.ViewModels.EventsViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Guildmate.Controllers
{
    public class EventsController : Controller
    {

        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public EventsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Events
        public async Task<ActionResult> Index()
        {
            var user = await GetCurrentUserAsync();
            var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);

            var allEvents = await _context.Event
                .Where(e => e.GuildId == userCharacter.GuildId)
                .Include(g => g.Guild)
                .ToListAsync();
            return View(allEvents);
        }

        // GET: Events/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var user = await GetCurrentUserAsync();
            var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);

            var singleEvent = await _context.Event
                     .Include(e => e.Guild)
                     .Include(e => e.CharacterEvents)
                        .ThenInclude(ce => ce.Character)
                     .Include(e => e.CharacterEvents)
                        .ThenInclude(ce => ce.Character.ClassRace.Class)
                     .Include(e => e.CharacterEvents)
                        .ThenInclude(ce => ce.Role)
                     .FirstOrDefaultAsync(e => e.EventId == id);
            return View(singleEvent);
        }

        // GET: Events/Create
        public async Task<ActionResult> Create()
        {
            return View();
        }

        // POST: Events/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Event newEvent)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);

                var guildEvent = new Event
                {

                    Name = newEvent.Name,
                    StartDate = newEvent.StartDate,
                    EndDate = newEvent.EndDate,
                    MaxAttendees = newEvent.MaxAttendees,
                    GuildId = userCharacter.GuildId.Value,

                };

                _context.Event.Add(guildEvent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Events/Edit/5
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

        // GET: Events/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Events/Delete/5
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