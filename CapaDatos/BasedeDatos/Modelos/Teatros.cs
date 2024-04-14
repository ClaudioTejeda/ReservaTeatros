using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BasedeDatos.Modelos
{
    public class Teatros
    {
        [Key]
        public int TeatroId { get; set; }
        [Required]
        [MaxLength(75)]
        public string Nombre { get; set; }
        [Required]
        public int Capacidad { get; set; }
        public bool Estado { get; set; }
    }
}
