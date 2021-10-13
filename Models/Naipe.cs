using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2Naipe.Models
{
    public class Naipe
    {
        [Key]
        public string NaipeID{ get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="Requerido")]
        
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido")]

        public string Enlace { get; set; }
    }
}
