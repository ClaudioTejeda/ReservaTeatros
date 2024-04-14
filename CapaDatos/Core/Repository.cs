﻿using CapaDatos.BasedeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Core
{
    public class Repository<T> : Irepository<T> where T : class
    {
        public ExamenContext dbcontext;

        public Repository()
        {
            dbcontext = new ExamenContext();
        }
        public void Agregar(T entidad)
        {
            dbcontext.Set<T>().Add(entidad);
        }
        public IQueryable<T> Consulta()
        {
            return dbcontext.Set<T>().AsQueryable();
        }
        public void Editar(T entidad)
        {

            dbcontext.Set<T>();
        }
        public void Eliminar(T entidad)
        {
            dbcontext.Set<T>().Remove(entidad);
        }
    }
}
