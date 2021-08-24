using DestisteApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DestisteApp.Controllers
{
    [Authorize(Roles ="Admin")]
    public class OperationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public OperationController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var display = _db.operations.ToList();
            return View(display);
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> Create(OperationModel op)
        {
            if (ModelState.IsValid)
            {
                _db.Add(op);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(op);
          
        }
        public async Task<IActionResult> Edit (int?id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOpaertion = await _db.operations.FindAsync(id);
            return View(getOpaertion);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(OperationModel op)
        {
            if (ModelState.IsValid)
            {
                _db.Update(op);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(op);

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOpaertion = await _db.operations.FindAsync(id);
            return View(getOpaertion);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getOpaertion = await _db.operations.FindAsync(id);
            return View(getOpaertion);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
          
            var getOpaertion = await _db.operations.FindAsync(id);
            _db.operations.Remove(getOpaertion);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }

    } 
}
