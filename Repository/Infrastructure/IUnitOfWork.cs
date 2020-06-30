using System;
using System.Threading.Tasks;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;

namespace Repository.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; }
        IGenericRepository.IGenericRepository<Company> CompanyRepository { get; }
        IGenericRepository.IGenericRepository<Confirmation> ConfirmationRepository { get; }
        IGenericRepository.IGenericRepository<CRMProgram> CRMProgramRepository { get; }
        IGenericRepository.IGenericRepository<Employee> EmployeeRepository { get; }
        IGenericRepository.IGenericRepository<Job> JobRepository { get; }

        Task<int> SaveChangeAsync();
    }
}