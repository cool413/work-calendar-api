using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Common.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Dtos;
using Service.Implements;
using WebApi.Controllers.Requests;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkCalendarControler : ControllerBase
    {
        private IMapper _mapper;
        private WorkCalendarService _workCalendarService;

        public WorkCalendarControler(IMapper mapper, WorkCalendarService workCalendarService)
        {
            _mapper = mapper;
            _workCalendarService = workCalendarService;
        }

        [HttpGet, Route("Get")]
        public async Task<IEnumerable<JobModel>> GetAsync([FromQuery] JobQueryRequest request)
        {
            var jobQueryDto = _mapper.Map<JobQueryDto>(request);
            var jobDtos = await _workCalendarService.GetAsync(jobQueryDto);

            return _mapper.Map<IEnumerable<JobModel>>(jobDtos);
        }

        [HttpPost, Route("Add")]
        public async Task<int> AddAsync([FromBody] JobRequest request)
        {
            var jobDto = _mapper.Map<JobDto>(request);
            var status = await _workCalendarService.AddAsync(jobDto);

            return status;
        }
    }
}