using System;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;

namespace Repository.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool _disposed = false;
        public DbContext Context { get; private set; }
        public IGenericRepository.IGenericRepository<Company> CompanyRepository { get; }
        public IGenericRepository.IGenericRepository<Confirmation> ConfirmationRepository { get; }
        public IGenericRepository.IGenericRepository<CRMProgram> CRMProgramRepository { get; }
        public IGenericRepository.IGenericRepository<Employee> EmployeeRepository { get; }
        public IGenericRepository.IGenericRepository<Job> JobRepository { get; }

        public UnitOfWork(DbContext context,
            IGenericRepository.IGenericRepository<Company> companyRepository,
            IGenericRepository.IGenericRepository<Confirmation> confirmationRepository,
            IGenericRepository.IGenericRepository<CRMProgram> crmProgramRepository,
            IGenericRepository.IGenericRepository<Employee> employeeRepository,
            IGenericRepository.IGenericRepository<Job> jobRepository)
        {
            Context = context;
            CompanyRepository = companyRepository;
            ConfirmationRepository = confirmationRepository;
            CRMProgramRepository = crmProgramRepository;
            EmployeeRepository = employeeRepository;
            JobRepository = jobRepository;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task<int> SaveChangeAsync()
        {
            return await Context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                    Context = null;
                }
            }

            _disposed = true;
        }
    }
}