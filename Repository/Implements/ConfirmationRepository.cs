using Microsoft.EntityFrameworkCore;

namespace Repository.Implements
{
    public class ConfirmationRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public ConfirmationRepository(DbContext context) : base(context)
        {
        }
    }
}