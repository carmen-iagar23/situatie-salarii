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
    public class ParametriLunariController : Controller
    {
        private readonly CalculatorSalariiContext _context;

        public ParametriLunariController(CalculatorSalariiContext context)
        {
            _context = context;
        }

        // GET: ParametriLunari
        public async Task<IActionResult> Index()
        {
            return View(await _context.ParametriLunari.ToListAsync());
        }

        // GET: ParametriLunari/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametriLunari = await _context.ParametriLunari
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parametriLunari == null)
            {
                return NotFound();
            }

            return View(parametriLunari);
        }

        // GET: ParametriLunari/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ParametriLunari/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProcentCAS,ProcentCASS,ProcentImpozit,ProcentCAM")] ParametriLunari parametriLunari)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parametriLunari);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parametriLunari);
        }

        // GET: ParametriLunari/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametriLunari = await _context.ParametriLunari.FindAsync(id);
            if (parametriLunari == null)
            {
                return NotFound();
            }
            return View(parametriLunari);
        }

        // POST: ParametriLunari/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProcentCAS,ProcentCASS,ProcentImpozit,ProcentCAM")] ParametriLunari parametriLunari)
        {
            if (id != parametriLunari.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parametriLunari);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParametriLunariExists(parametriLunari.Id))
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
            return View(parametriLunari);
        }

        // GET: ParametriLunari/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parametriLunari = await _context.ParametriLunari
                .FirstOrDefaultAsync(m => m.Id == id);
            if (parametriLunari == null)
            {
                return NotFound();
            }

            return View(parametriLunari);
        }

        // POST: ParametriLunari/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parametriLunari = await _context.ParametriLunari.FindAsync(id);
            _context.ParametriLunari.Remove(parametriLunari);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParametriLunariExists(int id)
        {
            return _context.ParametriLunari.Any(e => e.Id == id);
        }
    }
}
