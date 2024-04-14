using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.BasedeDatos
{
    public class ExamenContext : DbContext
    {

        public ExamenContext() : base("Teatro")
        {

        }
    }
}
