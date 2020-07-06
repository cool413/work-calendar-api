using AutoMapper;
using Common.Models;
using Service.Dtos;

namespace Service.Infrastructures
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<JobDto, Job>();
            
            CreateMap<Job, JobDto>();
        }
    }
}