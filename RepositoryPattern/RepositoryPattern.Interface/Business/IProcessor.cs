using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Interface.Business
{
    public interface IProcessor<TEntity> where TEntity : class
    {
        // Get
        TEntity Get(object id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        // Add
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        // Update
        void Update(TEntity entity);

        // Delete
        void Remove(TEntity entity);
        void Remove(object id);
        void RemoveRange(IEnumerable<TEntity> entities);
    }

}
