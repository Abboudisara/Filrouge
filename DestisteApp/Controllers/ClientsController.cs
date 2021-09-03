using DestisteApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DestisteApp.Controllers
{
    public class ClientsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly RoleManager<IdentityRole> _identityRole;
        private readonly UserManager<ApplicationUser> _userManager;

        public ClientsController(ApplicationDbContext db, RoleManager<IdentityRole> identityRole, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _identityRole = identityRole;
            _userManager = userManager;
        }
        public async Task <IActionResult> Index()
        {
            ApplicationUser user = await _userManager.FindByEmailAsync(User.Identity.Name);
            var display = _db.Reservations.Where(r=>r.User_id==user.Id).ToList();
            return View(display);
        }

        public IActionResult Create()
        {
            return View();
        }
        public IEnumerable<ReservationModel> display { get; set; }

        [HttpPost]
        public async Task<IActionResult> Create(ReservationModel neR)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.GetUserAsync(User);
                neR.User = user;
                _db.Add(neR);
                await _db.SaveChangesAsync();
                return RedirectToAction("index");
            }

            return View(neR);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOpaertion = await _db.Reservations.FindAsync(id);
            return View(getOpaertion);

        }

      
           [HttpPost]

            public async Task<IActionResult> Edit(ReservationModel re)
            {
                if (ModelState.IsValid)
                {
                    _db.Update(re);
                    await _db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                return View(re);
            }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOpaertion = await _db.Reservations.FindAsync(id);
            return View(getOpaertion);

        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOpaertion = await _db.Reservations.FindAsync(id);
            return View(getOpaertion);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            var getOpaertion = await _db.Reservations.FindAsync(id);
            _db.Reservations.Remove(getOpaertion);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public IActionResult Operation()
        {
            var display = _db.operations.ToList();
            return View(display);
        }

    }
}


