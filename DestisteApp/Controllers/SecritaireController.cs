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

     [HttpGet]
     public async Task<IActionResult> Index(string Rndvsearch)
        {
            ViewData["getRndvDetails"] = Rndvsearch;
            var rdvquery = from x in _db.Reservations.Include(c => c.User) select x;
            if (!string.IsNullOrEmpty(Rndvsearch))
            {
                rdvquery = rdvquery.Where(x => x.Confirmation.Contains(Rndvsearch) || x.User.Name.Contains(Rndvsearch) || x.User.Fullname.Contains(Rndvsearch));
            }
            return View(await rdvquery.AsNoTracking().ToListAsync());
        }
    }

}
