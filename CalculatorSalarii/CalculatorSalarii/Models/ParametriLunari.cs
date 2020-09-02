using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorSalarii.Models
{
    public class ParametriLunari
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [DisplayName("Procent CAS")]
        public double ProcentCAS { get; set; }

        [Required]
        [DisplayName("Procent CASS")]
        public double ProcentCASS { get; set; }

        [Required]
        [DisplayName("Procent impozit")]
        public double ProcentImpozit { get; set; }

        [Required]
        [DisplayName("Procent CAM")]
        public double ProcentCAM { get; set; }
    }
}
