using JobApplication.Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly JobServices _jobServices;

        public JobController(JobServices jobServices)
        {
            _jobServices = jobServices;
        }

        [HttpPut("{id}/close")]
        public async Task<IActionResult> CloseJob(int id)
        {
            var result = await _jobServices.closeJob(id);
            if (!result)
            {
                return NotFound(new { message = $"Job with ID {id} not found." });
            }

            return Ok(new { message = "Job closed successfully." });
        }
    }
}
