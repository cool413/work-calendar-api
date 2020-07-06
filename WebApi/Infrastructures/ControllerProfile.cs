using AutoMapper;
using Common.Models;
using Service.Dtos;
using WebApi.Controllers.Requests;

namespace WebApi.Infrastructures
{
    public class ControllerProfile : Profile
    {
        public ControllerProfile()
        {
            CreateMap<JobQueryRequest, JobQueryDto>();
            CreateMap<JobRequest, JobDto>();

            CreateMap<JobDto, JobModel>();
        }
    }
}