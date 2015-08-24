using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCBoilerplate.Repositories.Infraestructure
{
    public interface IGenericRepository <T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(object Id);
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);
        int Create(T entity);
        bool Update(T Entity);
        bool Delete(Object id);
        bool Save();
    }
}
