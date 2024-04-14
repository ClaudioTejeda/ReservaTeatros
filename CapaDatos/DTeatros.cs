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
    public class DTeatros
    {
        UnitofWork _unitOfWork;

        public DTeatros()
        {
            _unitOfWork = new UnitofWork();
        }
        public int TeatroId { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Estado { get; set; }
        public List<Teatros> TodosLosTeatros()
        {
            return _unitOfWork.Repository<Teatros>().Consulta().ToList();
        }
        public int Guardar(Teatros teatro)
        {
            if (teatro.TeatroId == 0)
            {
                _unitOfWork.Repository<Teatros>().Agregar(teatro);
                return _unitOfWork.Guardar();
            }
            else
            {
                var teatroInDb = _unitOfWork.Repository<Teatros>().Consulta().FirstOrDefault(c => c.TeatroId == teatro.TeatroId);
                if (teatroInDb != null)
                {
                    teatroInDb.Nombre = teatro.Nombre;
                    teatroInDb.Capacidad = teatro.Capacidad;
                    teatroInDb.Estado = teatro.Estado;
                    _unitOfWork.Repository<Teatros>().Editar(teatroInDb);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
        }
        public int Eliminar(int teatroid)
        {
            var teatroInDb = _unitOfWork.Repository<Teatros>().Consulta().FirstOrDefault(c => c.TeatroId == teatroid);
            if (teatroInDb != null)
            {
                _unitOfWork.Repository<Teatros>().Eliminar(teatroInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
