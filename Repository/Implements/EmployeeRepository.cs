using Microsoft.EntityFrameworkCore;

namespace Repository.Implements
{
    public class EmployeeRepository<TEntity> : GenericRepository<TEntity> where TEntity : class
    {
        public EmployeeRepository(DbContext context) : base(context)
        {
        }
    }
}