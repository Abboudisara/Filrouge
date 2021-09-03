using DestisteApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DestisteApp.Controllers
{
    public class SecritaireController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SecritaireController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var list = _db.Reservations.Include(c=>c.User).ToList();
            return View(list);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getReserve = await _db.Reservations.FindAsync(id);
            return View(getReserve);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(ReservationModel cnf)
        {
            if (ModelState.IsValid)
            {
                _db.Update(cnf);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cnf);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getReserve = await _db.Reservations.FindAsync(id);
            return View(getReserve);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            var getReserve = await _db.Reservations.FindAsync(id);
            _db.Reservations.Remove(getReserve);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }

}
