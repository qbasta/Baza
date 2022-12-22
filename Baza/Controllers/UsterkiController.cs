using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Baza.Data;
using Baza.Models;

namespace Baza.Controllers
{
    public class UsterkiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsterkiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Usterki
        public async Task<IActionResult> Index()
        {
              return View(await _context.Usterki.ToListAsync());
        }

        // GET: Usterki/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Usterki == null)
            {
                return NotFound();
            }

            var usterki = await _context.Usterki
                .FirstOrDefaultAsync(m => m.idUsterki == id);
            if (usterki == null)
            {
                return NotFound();
            }

            return View(usterki);
        }

        // GET: Usterki/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usterki/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idUsterki,typUsterki,IsActive,Miejscowosc,dataZgloszenia,opis")] Usterki usterki)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usterki);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usterki);
        }

        // GET: Usterki/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Usterki == null)
            {
                return NotFound();
            }

            var usterki = await _context.Usterki.FindAsync(id);
            if (usterki == null)
            {
                return NotFound();
            }
            return View(usterki);
        }

        // POST: Usterki/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idUsterki,typUsterki,IsActive,Miejscowosc,dataZgloszenia,opis")] Usterki usterki)
        {
            if (id != usterki.idUsterki)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usterki);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsterkiExists(usterki.idUsterki))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usterki);
        }

        // GET: Usterki/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Usterki == null)
            {
                return NotFound();
            }

            var usterki = await _context.Usterki
                .FirstOrDefaultAsync(m => m.idUsterki == id);
            if (usterki == null)
            {
                return NotFound();
            }

            return View(usterki);
        }

        // POST: Usterki/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Usterki == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Usterki'  is null.");
            }
            var usterki = await _context.Usterki.FindAsync(id);
            if (usterki != null)
            {
                _context.Usterki.Remove(usterki);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsterkiExists(int id)
        {
          return _context.Usterki.Any(e => e.idUsterki == id);
        }
    }
}
