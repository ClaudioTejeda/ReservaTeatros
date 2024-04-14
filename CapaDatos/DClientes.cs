using CapaDatos.BasedeDatos.Modelos;
using CapaDatos.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DClientes
    {
        UnitofWork _unitOfWork;
        public DClientes()
        {
            _unitOfWork = new UnitofWork();
        }
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaIngreso { get; set; }
        public bool Estado { get; set; }
        public List<Clientes> TodosLosClientes()
        {
            return _unitOfWork.Repository<Clientes>().Consulta().ToList();
        }
        public List<Clientes> MedicosActivos()
        {
            return _unitOfWork.Repository<Clientes>().Consulta().ToList();
        }
        public int Guardar(Clientes cliente)
        {
            if (cliente.ClienteId == 0)
            {
                _unitOfWork.Repository<Clientes>().Agregar(cliente);
                return _unitOfWork.Guardar();
            }
            else
            {
                var ClienteInDb = _unitOfWork.Repository<Clientes>().Consulta().FirstOrDefault(c => c.ClienteId == cliente.ClienteId);
                if (ClienteInDb != null)
                {
                    ClienteInDb.Nombres = cliente.Nombres;
                    ClienteInDb.Apellidos = cliente.Apellidos;
                    ClienteInDb.FechaIngreso = cliente.FechaIngreso;
                    ClienteInDb.Estado = cliente.Estado;
                    _unitOfWork.Repository<Clientes>().Editar(ClienteInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int Eliminar(int clienteid)
        {
            var ClienteInDb = _unitOfWork.Repository<Clientes>().Consulta().FirstOrDefault(c => c.ClienteId == clienteid);
            if (ClienteInDb != null)
            {
                _unitOfWork.Repository<Clientes>().Eliminar(ClienteInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
