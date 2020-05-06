using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guildmate.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Guildmate.Controllers
{
    public class GuildsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GuildsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Guilds
        public ActionResult Index()
        {
            var guilds = _context.Guild
                .Include(f => f.Faction)
                .Include(s => s.Server)
                .ToList();
            return View(guilds);
        }

        // GET: Guilds/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Guilds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Guilds/Create
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
    }
}