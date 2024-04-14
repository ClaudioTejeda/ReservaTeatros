using CapaDatos;
using CapaDatos.BasedeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NClientes
    {
        private DClientes dClientes;

        public NClientes()
        {
            dClientes = new DClientes();
        }

        public List<Clientes> TodasLosMedicos()
        {
            return dClientes.TodosLosClientes();
        }
        public List<Clientes> Clientesactivos()
        {
            return dClientes.TodosLosClientes().Where(c => c.Estado == true).ToList();
        }
        public List<object> obtenerClientesGrid()
        {
            var Medicos = dClientes.TodosLosClientes().Select(c => new
            {
                c.ClienteId,
                c.Nombres,
                c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Medicos.Cast<object>().ToList();
        }
        public List<object> BuscarclientesGrid()
        {
            var Medicos = dClientes.TodosLosClientes().Select(c => new
            {
                c.ClienteId,
                Nombre_Completo = c.Nombres + " " + c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Medicos.Cast<object>().ToList();
        }
        public List<object> BuscarClientesActivosGrid()
        {
            var Medicos = dClientes.TodosLosClientes().Select(c => new
            {
                c.ClienteId,
                Nombre_Completo = c.Nombres + " " + c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Medicos.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public List<object> obtenerClientesActivosGrid()
        {
            var Medicos = dClientes.TodosLosClientes().Select(c => new
            {
                c.ClienteId,
                c.Nombres,
                c.Apellidos,
                Fecha_de_Ingreso = c.FechaIngreso,
                c.Estado
            });
            return Medicos.Where(c => c.Estado == true).Cast<object>().ToList();
        }
        public int AgregarClienets(Clientes clientes)
        {
            return dClientes.Guardar(clientes);
        }
        public int EditarClientes(Clientes clientes)
        {
            return dClientes.Guardar(clientes);
        }
        public int EliminarClientes(int clienteid)
        {
            return dClientes.Eliminar(clienteid);
        }
    }
}
