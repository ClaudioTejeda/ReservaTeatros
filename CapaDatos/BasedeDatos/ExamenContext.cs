using CapaDatos.BasedeDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
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
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Teatros> Teatros { get; set; }
        public DbSet<Reservas> Reservas { get; set; }
    }
}
