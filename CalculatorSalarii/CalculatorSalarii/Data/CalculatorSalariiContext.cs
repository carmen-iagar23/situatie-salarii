using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalculatorSalarii.Models;

namespace CalculatorSalarii.Data
{
    public class CalculatorSalariiContext : DbContext
    {
        public CalculatorSalariiContext (DbContextOptions<CalculatorSalariiContext> options)
            : base(options)
        {
        }

        public DbSet<CalculatorSalarii.Models.Angajat> Angajat { get; set; }
    }
}
