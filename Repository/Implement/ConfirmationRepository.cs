using Microsoft.EntityFrameworkCore;

namespace Repository.Implement
{
    public class ConfirmationRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public ConfirmationRepository(DbContext context) : base(context)
        {
        }
    }
}