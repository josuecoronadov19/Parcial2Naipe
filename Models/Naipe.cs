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
        [StringLength(200,MinimumLength =1, ErrorMessage ="Ingrese una letra (J,Q,K,A); en su defecto uno o dos numeros del 1 al 10")]
        
        public string Nombre { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Requerido")]

        public string Enlace { get; set; }
    }
}
