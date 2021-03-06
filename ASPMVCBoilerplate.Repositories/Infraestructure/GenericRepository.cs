﻿using ASPMVCBoilerplate.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCBoilerplate.Repositories.Infraestructure
{
    public class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        private ApplicationContext _context = null;
        private IDbSet<T> _dbSet = null;

        public GenericRepository(ApplicationContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            throw new Exception("Not implementet method");
        }

        public T GetById(Object Id)
        {
            throw new NotImplementedException("Not implemented exception");
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public int Create(T Entity)
        {
            try
            {
                _dbSet.Add(Entity);
                return _context.SaveChanges();
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public bool Update(T Entity)
        {
            throw new NotImplementedException("Not implemented exception");
        }

        public bool Delete(Object Id)
        {
            throw new NotImplementedException("Not implemented exception");
        }

        public bool Save()
        {
            throw new NotImplementedException("Not implemented exception");
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
