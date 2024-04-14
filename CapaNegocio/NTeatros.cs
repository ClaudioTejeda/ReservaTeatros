using CapaDatos;
using CapaDatos.BasedeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NTeatros
    {
        private DTeatros dTeatros;

        public NTeatros()
        {
            dTeatros = new DTeatros();
        }

        public List<Teatros> Todoslosteatros()
        {
            return dTeatros.TodosLosTeatros();
        }
        public List<Teatros> teatrosActivos()
        {
            return dTeatros.TodosLosTeatros().Where(c => c.Estado == true).ToList();
        }
        public List<object> obtenerreatrosGrid()
        {
            var teatros = dTeatros.TodosLosTeatros().Select(c => new
            {
                c.TeatroId,
                c.Nombre,
                c.Capacidad,
                c.Estado
            });
            return teatros.Cast<object>().ToList();
        }
        public List<object> buscarteatrosgrid()
        {
            var teatros = dTeatros.TodosLosTeatros().Select(c => new
            {
                c.TeatroId,
                c.Nombre,
                c.Capacidad,
                c.Estado
            });
            return teatros.Cast<object>().ToList();
        }
        public List<object> BuscarTeatrosActivosGrid()
        {
            var teatros = dTeatros.TodosLosTeatros().Select(c => new
            {
                c.TeatroId,
                c.Nombre,
                c.Capacidad,
                c.Estado
            });
            return teatros.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public List<object> obtenerteatrosActivosGrid()
        {
            var teatros = dTeatros.TodosLosTeatros().Select(c => new
            {
                c.TeatroId,
                c.Nombre,
                c.Capacidad,
                c.Estado
            });
            return teatros.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public int Agregarteatros(Teatros teatros)
        {
            return dTeatros.Guardar(teatros);
        }
        public int Editarteatros(Teatros teatros)
        {
            return dTeatros.Guardar(teatros);
        }
        public int Eliminarteatros(int teatroid)
        {
            return dTeatros.Eliminar(teatroid);
        }
    }
}
