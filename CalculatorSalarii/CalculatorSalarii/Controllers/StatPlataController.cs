using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorSalarii.CalculeSalarii;
using CalculatorSalarii.Data;
using CalculatorSalarii.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CalculatorSalarii.Controllers
{
    [Authorize]
    public class StatPlataController : Controller
    {
        private readonly CalculatorSalariiContext _context;
        private List<StatPlata> statPlata = new List<StatPlata>();

        public StatPlataController(CalculatorSalariiContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var listaAngajati = await _context.Angajat.ToListAsync();
            var parametriLunari = await _context.ParametriLunari.ToListAsync();
            
            foreach (var angajat in listaAngajati)
            {
                var entry = new StatPlata();
                entry.Angajat = angajat;
                entry.ContributieCAS = Calcule.SumaCAS(angajat.VenitBrut, parametriLunari.FirstOrDefault().ProcentCAS);
                entry.ContributieCASS = Calcule.SumaCASS(angajat.VenitBrut, parametriLunari.FirstOrDefault().ProcentCASS);
                entry.DeducerePersonala = Calcule.SumaDeducerePersonala(angajat);
                entry.SumaImpozit = Calcule.SumaImpozit(
                    entry.Angajat.VenitBrut -
                    entry.ContributieCAS -
                    entry.ContributieCASS -
                    entry.DeducerePersonala, parametriLunari.FirstOrDefault().ProcentImpozit);
                entry.SumaCAM = Calcule.SumaCAM(angajat.VenitBrut, parametriLunari.FirstOrDefault().ProcentCAM);
                entry.SalariuNet = entry.Angajat.VenitBrut - entry.ContributieCAS - entry.ContributieCASS - entry.SumaImpozit;

                statPlata.Add(entry);
            }

            return View(statPlata.OrderBy(x => x.Angajat.Nume).ThenBy(x => x.Angajat.Prenume));
        }
    }
}
