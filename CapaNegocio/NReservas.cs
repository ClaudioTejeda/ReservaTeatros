using CapaDatos;
using CapaDatos.BasedeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NReservas
    {
        private DReservas dreservas;

        public NReservas()
        {
            dreservas = new DReservas();
        }

        public List<Reservas> todaslasreservas()
        {
            return dreservas.Todaslasreservas();
        }
        public int Agregarreservas(Reservas reservas)
        {
            return dreservas.Guardar(reservas);
        }
        public int Editarreservas(Reservas reservas)
        {

            return dreservas.Guardar(reservas);
        }

        public int Eliminar(int reservasid)
        {
            return dreservas.Eliminar(reservasid);
        }
        public List<object> obtenerreservasGrid()
        {
            var reservas = dreservas.Todaslasreservas().Select(c => new
            {
                c.ReservaId,
                c.TeatroId,
                c.ClienteId,
                c.Teatro,
                c.Cliente,
                c.FechaReserva
            });
            return reservas.Cast<object>().ToList();
        }
    }
}
