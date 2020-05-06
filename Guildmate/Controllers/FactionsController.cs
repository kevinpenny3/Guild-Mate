using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Guildmate.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Guildmate.Controllers
{
    public class FactionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FactionsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: Factions
        public ActionResult Index()
        {
            var factions = _context.Faction.ToList();
            return View(factions);
        }

        // GET: Factions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Factions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Factions/Create
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

        // GET: Factions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Factions/Edit/5
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

        // GET: Factions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Factions/Delete/5
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