using CapaDatos.BasedeDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DReservas
    {
        UnitofWork _unitOfWork;

        public DReservas()
        {
            _unitOfWork = new UnitofWork();
        }
        public int ReservaId { get; set; }
        public int TeatroId { get; set; }
        public int ClienteId { get; set; }
        public string Teatro { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaReserva { get; set; }

        public List<Reservas> Todaslasreservas()
        {
            return _unitOfWork.Repository<Reservas>().Consulta().Include(c => c.Clientes)
                                         .Include(c => c.Teatros)
                                         .ToList();
        }
        public int Guardar(Reservas reserva)
        {
            if (reserva.ReservaId == 0)
            {
                _unitOfWork.Repository<Reservas>().Agregar(reserva);
                return _unitOfWork.Guardar();
            }
            else
            {
                var Reservaindb = _unitOfWork.Repository<Reservas>().Consulta().FirstOrDefault(c => c.ReservaId == reserva.ReservaId);
                if (Reservaindb != null)
                {
                    Reservaindb.ClienteId = reserva.ClienteId;
                    Reservaindb.TeatroId = reserva.TeatroId;
                    Reservaindb.Teatro = reserva.Teatro;
                    Reservaindb.Cliente = reserva.Cliente;
                    Reservaindb.FechaReserva = reserva.FechaReserva;
                    _unitOfWork.Repository<Reservas>().Editar(Reservaindb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }

        public int Eliminar(int reservaid)
        {
            var Reservaindb = _unitOfWork.Repository<Reservas>().Consulta().FirstOrDefault(c => c.ReservaId == reservaid);
            if (Reservaindb != null)
            {
                _unitOfWork.Repository<Reservas>().Eliminar(Reservaindb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
