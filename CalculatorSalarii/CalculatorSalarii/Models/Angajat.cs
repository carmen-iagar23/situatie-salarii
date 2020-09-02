using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorSalarii.Models
{
    public class Angajat
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string Nume { get; set; }

        [Required]
        [MaxLength(50)]
        public string Prenume { get; set; }
        
        [Required]
        [DisplayName("Venit brut")]
        [DataType(DataType.Currency)]
        public decimal VenitBrut { get; set; }

        [Required]
        [DisplayName("Serviciu de baza")]
        public bool IsServiciuDeBaza { get; set; } = true;

        [Required]
        [DisplayName("Persoane in intretinere")]
        public int NrPersoaneInIntretinere { get; set; } = 0;
    }
}
