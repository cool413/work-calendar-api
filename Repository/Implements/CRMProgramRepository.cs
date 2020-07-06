using Microsoft.EntityFrameworkCore;

namespace Repository.Implements
{
    public class CRMPorgramRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public CRMPorgramRepository(DbContext context) : base(context)
        {
        }
    }
}