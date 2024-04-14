using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BasedeDatos.Modelos
{
    public class Reservas
    {
        [Key]
        public int ReservaId { get; set; }
        public int TeatroId { get; set; }
        public Teatros Teatros { get; set; }
        public int ClienteId { get; set; }
        public Clientes Clientes { get; set; }
        [Required]
        [MaxLength(120)]
        public string Teatro { get; set; }
        [Required]
        [MaxLength(120)]
        public string Cliente { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
