using JobApplication.Application.Interfaces;
using JobApplication.Domain.Enums;
using MediatR;
using System.Collections.Generic;
using System.Text;

namespace JobApplication.Application.Features.Jobs.Commands.CloseJob
{
    internal class CloseJobHandler : IRequestHandler<CloseJobCommands, bool>
    {
        private readonly IJobRepository _jobRepository;
        public CloseJobHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<bool> Handle(CloseJobCommands request, CancellationToken cancellationToken)
        {
            var job = await _jobRepository.GetByIdAsync(request.Id);
            if (job == null)
            {
                return false;
            }

            job.JobStatus = JobStatus.closed;
            _jobRepository.Update(job);
            await _jobRepository.SaveChangesAsync();
            return true;
        }
    }
}
