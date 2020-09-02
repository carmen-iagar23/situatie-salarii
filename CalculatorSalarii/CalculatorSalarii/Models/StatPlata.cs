using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorSalarii.Models
{
    public class StatPlata
    {
        public int Id { get; set; }
        public Angajat Angajat { get; set; }
        public int ContributieCAS { get; set; }
        public int ContributieCASS { get; set; }
        public int DeducerePersonala { get; set; }
        public int SumaImpozit { get; set; }
        public int SumaCAM { get; set; }
    }
}
