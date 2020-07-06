using System.Collections.Generic;
using System.Threading.Tasks;
using Service.Dtos;

namespace Service.Interfaces
{
    public interface IWorkCalendarService
    {
        Task<IEnumerable<JobDto>> GetAsync(JobQueryDto jobQueryDto);
        Task<int> AddAsync(JobDto jobDto);
    }
}