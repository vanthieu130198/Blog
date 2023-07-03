using FA.JustBlog.DataAccess.Data;
using FA.JustBlog.DataAccess.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.DataAccess.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly JustBlogContext _justBlogContext;
        internal DbSet<T> dbSet;
        public BaseRepository(JustBlogContext justBlogContext)
        {
            _justBlogContext = justBlogContext;
            dbSet = _justBlogContext.Set<T>();
        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
            _justBlogContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<T> GetAllByConditions(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if(filter != null)
            {
                query = query.Where(filter);
            }
            if(includeProperties != null)
            {
                foreach(var includePop in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includePop);
                }
            }
            if(orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }

        public T GetById(Guid guid, string includeProperties = null)
        {
            var data = dbSet.Find(guid);
            if (includeProperties != null)
            {
                foreach (var includePop in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    _justBlogContext.Entry(data).Collection(includePop).Load();
                }
            }
            
            return data;
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
            _justBlogContext.SaveChanges();
        }

        public void Remove(Guid guid)
        {
            var entity = GetById(guid);
            Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            _justBlogContext.SaveChanges();

        }
    }
}
