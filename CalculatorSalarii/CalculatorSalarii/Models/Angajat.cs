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
        [Range(0, int.MaxValue, ErrorMessage ="Venitul trebuie sa aiba o valoare mai mare ca 0.")]
        public int VenitBrut { get; set; }

        [Required]
        [DisplayName("Serviciu de baza")]
        [DefaultValue(true)]
        public bool IsServiciuDeBaza { get; set; }

        [Required]
        [DisplayName("Persoane in intretinere")]
        [DefaultValue(0)]
        [Range(0, int.MaxValue, ErrorMessage = "Numarul de persoane in intretinere trebuie sa fie mai mare sau egal cu 0.")]
        public int NrPersoaneInIntretinere { get; set; }
    }
}
