using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IGenericRepository
    {
        public interface IGenericRepository<TEntity> where TEntity : class
        {
            Task<ICollection<TEntity>> GetAllAsync();

            Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate);
            
            void Add(TEntity entity);

            void Delete(TEntity entity);

            void Update(TEntity entity);
        }
    }
}