﻿using CapaDatos.BasedeDatos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Core
{
    public class UnitofWork
    {
        private readonly ExamenContext dbcontext;
        private DbContextTransaction _transaccion;

        public UnitofWork()
        {
            this.dbcontext = new ExamenContext();
        }
        public void ComenzarTransaccion()
        {
            _transaccion = dbcontext.Database.BeginTransaction();
        }
        public void ConfirmarTransaccion()
        {
            _transaccion.Commit();
            _transaccion.Dispose();
            _transaccion = null;
        }

        public int Guardar()
        {
            int guardar = 0;
            if (_transaccion == null)
            {
                try
                {
                    ComenzarTransaccion();
                    guardar = dbcontext.SaveChanges();
                    ConfirmarTransaccion();
                    return guardar;
                }
                catch (Exception ex)
                {
                    ReversarTransaccion();
                    throw ex;
                }
            }

            return dbcontext.SaveChanges();
        }
        public Irepository<T> Repository<T>() where T : class
        {
            var repository = new Repository<T>();
            repository.dbcontext = dbcontext;
            return repository; ;
        }
        public void ReversarTransaccion()
        {
            _transaccion.Rollback();
            _transaccion.Dispose();
            _transaccion = null;
        }
    }
}
