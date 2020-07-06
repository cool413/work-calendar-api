using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Common.Models;
using Repository.Infrastructure;
using Service.Dtos;
using Service.Interfaces;

namespace Service.Implements
{
    public class WorkCalendarService : IWorkCalendarService
    {
        private IMapper _mapper;
        private IUnitOfWork _unitofwork;

        public WorkCalendarService(IMapper mapper, IUnitOfWork unitofwork)
        {
            _mapper = mapper;
            _unitofwork = unitofwork;
        }

        public async Task<IEnumerable<JobDto>> GetAsync(JobQueryDto jobQueryDto)
        {
            var jobs = await _unitofwork.JobRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<JobDto>>(jobs);
        }

        public async Task<int> AddAsync(JobDto jobDto)
        {
            var job = _mapper.Map<Job>(jobDto);
            
            _unitofwork.JobRepository.Add(job);

            return await _unitofwork.SaveChangeAsync();
        }
    }
}