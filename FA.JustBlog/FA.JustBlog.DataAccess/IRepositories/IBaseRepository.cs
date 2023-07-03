using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.DataAccess.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {
        void Add(T entity);

        T GetById(Guid guid, string includeProperties = null);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllByConditions(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);

        void Remove(T entity);
        void Remove(Guid guid);

        void Update(T entity);
    }
}
