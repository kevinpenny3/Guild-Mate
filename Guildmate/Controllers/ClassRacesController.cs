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
    public class ClassRacesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassRacesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: ClassRaces
        public ActionResult Index()
        {
            var classRaces = _context.ClassRace
                .Include(c => c.Class)
                .Include(r => r.Race)
                .ToList();
            return View(classRaces);
        }

        // GET: ClassRaces/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClassRaces/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassRaces/Create
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

        // GET: ClassRaces/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClassRaces/Edit/5
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

        // GET: ClassRaces/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassRaces/Delete/5
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