using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Interface.Core;
using RepositoryPattern.DAL.Database;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace RepositoryPattern.DAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly BooksContext booksContext;
        private DbSet<TEntity> dbSet;

        public Repository(BooksContext dbContext)
        {
            booksContext = dbContext;
            dbSet = dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            dbSet.AddRange(entities);
        }

        public TEntity Get(object id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
                return null;
            return dbSet.Where(predicate);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public void Remove(TEntity entity)
        {
            dbSet.Attach(entity);
            booksContext.Entry(entity).State = EntityState.Deleted;
            dbSet.Remove(entity);
        }

        public void Remove(object id)
        {
            TEntity record = dbSet.Find(id);
            if (record != null)
            {
                this.Remove(record);
            }
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            dbSet.RemoveRange(entities);
        }

        public void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            booksContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
