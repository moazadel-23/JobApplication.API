using JobApplication.Application.DTOs;
using JobApplication.Application.Features.Jobs.Commands;
using JobApplication.Application.Features.Jobs.Commands.CloseJob;
using JobApplication.Application.Features.Jobs.Commands.CreateJob;
using JobApplication.Application.Services;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JobController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPut("{id}/close")]
        public async Task<IActionResult> CloseJob(int id)
        {
            var result = await _mediator.Send(new CloseJobCommands(id));
            if (!result)
            {
                return NotFound(new { message = $"Job with ID {id} not found." });
            }

            return Ok(new { message = "Job closed successfully." });
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateJobDto createJobDto)
        {
            var job = await _mediator.Send(new CreateJobCommands
            {
                Title = createJobDto.Title,
                Description = createJobDto.Description
            });
            return Ok(job);
        }
    }
}
