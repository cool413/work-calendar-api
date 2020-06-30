using Microsoft.EntityFrameworkCore;

namespace Repository.Implement
{
    public class CRMPorgramRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public CRMPorgramRepository(DbContext context) : base(context)
        {
        }
    }
}