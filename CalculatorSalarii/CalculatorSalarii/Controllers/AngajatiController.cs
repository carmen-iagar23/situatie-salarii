using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalculatorSalarii.Data;
using CalculatorSalarii.Models;
using Microsoft.AspNetCore.Authorization;

namespace CalculatorSalarii.Controllers
{
    [Authorize]
    public class AngajatiController : Controller
    {
        private readonly CalculatorSalariiContext _context;

        public AngajatiController(CalculatorSalariiContext context)
        {
            _context = context;
        }

        // GET: Angajati
        public async Task<IActionResult> Index()
        {
            return View(await _context.Angajat.ToListAsync());
        }

        // GET: Angajati/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var angajat = await _context.Angajat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (angajat == null)
            {
                return NotFound();
            }

            return View(angajat);
        }

        // GET: Angajati/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Angajati/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nume,Prenume,VenitBrut,IsServiciuDeBaza,NrPersoaneInIntretinere")] Angajat angajat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(angajat);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(angajat);
        }

        // GET: Angajati/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var angajat = await _context.Angajat.FindAsync(id);
            if (angajat == null)
            {
                return NotFound();
            }
            return View(angajat);
        }

        // POST: Angajati/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nume,Prenume,VenitBrut,IsServiciuDeBaza,NrPersoaneInIntretinere")] Angajat angajat)
        {
            if (id != angajat.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(angajat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AngajatExists(angajat.Id))
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
            return View(angajat);
        }

        // GET: Angajati/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var angajat = await _context.Angajat
                .FirstOrDefaultAsync(m => m.Id == id);
            if (angajat == null)
            {
                return NotFound();
            }

            return View(angajat);
        }

        // POST: Angajati/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var angajat = await _context.Angajat.FindAsync(id);
            _context.Angajat.Remove(angajat);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AngajatExists(int id)
        {
            return _context.Angajat.Any(e => e.Id == id);
        }
    }
}
