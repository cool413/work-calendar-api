using Microsoft.EntityFrameworkCore;

namespace Repository.Implements
{
    public class JobRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public JobRepository(DbContext context) : base(context)
        {
        }
    }
}