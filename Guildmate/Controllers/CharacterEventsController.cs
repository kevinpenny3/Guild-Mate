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
    public class CharacterEventsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CharacterEventsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: CharacterEvents
        public ActionResult Index()
        {
            return View();
        }

        // GET: CharacterEvents/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CharacterEvents/Create
        public async Task<ActionResult> AttendEvent()
        {

            var roles = await _context.Role
                .Select(r => new SelectListItem() { Text = r.Name, Value = r.RoleId.ToString() })
                .ToListAsync();
            var viewModel = new CharacterEventsViewModel();
            viewModel.RoleOptions = roles;
            return View(viewModel);
        }

        // POST: CharacterEvents/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AttendEvent(CharacterEventsViewModel characterEventsViewModel)
        {
            try
            {
                var user = await GetCurrentUserAsync();
                var userCharacter = await _context.Character.FirstOrDefaultAsync(c => c.ApplicationUserId == user.Id);

                var characterEvent = new CharacterEvent
                {

                    CharacterId = userCharacter.CharacterId,
                    EventId = characterEventsViewModel.EventId,
                    RoleId = characterEventsViewModel.RoleId,

                };

                _context.CharacterEvent.Add(characterEvent);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CharacterEvents/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CharacterEvents/Edit/5
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

        // GET: CharacterEvents/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CharacterEvents/Delete/5
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