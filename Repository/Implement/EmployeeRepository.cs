using Microsoft.EntityFrameworkCore;

namespace Repository.Implement
{
    public class EmployeeRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }
    }
}