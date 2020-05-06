using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guildmate.Data;
using Guildmate.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Guildmate.Controllers
{
    public class ServersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ServersController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        // GET: Servers
        [Route("Servers/{filter}")]
        public async Task<ActionResult> Index(string filter)
        {
            var user = await GetUserAsync();
            var servers = await _context.Server
                .Include(r => r.Region)
                .ToListAsync();

            
                switch (filter)
                {

                    case "east":
                        servers = await _context.Server
                            .Where(r => r.RegionId == 1)
                            .ToListAsync();
                        break;
                    case "west":
                        servers = await _context.Server
                            .Where(r => r.RegionId == 2)
                            .ToListAsync();
                        break;
                    case "all":
                        servers = await _context.Server
                            .Include(r => r.Region)
                            .ToListAsync();
                        break;
                }
            

                    return View(servers);
        }

        // GET: Servers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Servers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Servers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Servers/Edit/5
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

        // GET: Servers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Servers/Delete/5
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
        private async Task<ApplicationUser> GetUserAsync() => await _userManager.GetUserAsync(HttpContext.User);

    }
}