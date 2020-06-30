using Microsoft.EntityFrameworkCore;

namespace Repository.Implement
{
    public class CompanyRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public CompanyRepository(DbContext context) : base(context)
        {
        }
    }
}