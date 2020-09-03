using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorSalarii.Models
{
    public class StatPlata
    {
        public int Id { get; set; }
        public Angajat Angajat { get; set; }

        [DisplayName("Contributie CAS")]
        public int ContributieCAS { get; set; }

        [DisplayName("Contributie CASS")]
        public int ContributieCASS { get; set; }

        [DisplayName("Deducere personala")]
        public int DeducerePersonala { get; set; }
        
        [DisplayName("Impozit")]
        public int SumaImpozit { get; set; }

        [DisplayName("Suma CAM")]
        public int SumaCAM { get; set; }

        [DisplayName("Salariu net")]
        public int SalariuNet { get; set; }
    }
}
