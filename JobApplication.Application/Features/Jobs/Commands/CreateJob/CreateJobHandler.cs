using JobApplication.Application.DTOs;
using JobApplication.Application.Interfaces;
using JobApplication.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication.Application.Features.Jobs.Commands.CreateJob
{
    internal class CreateJobHandler : IRequestHandler<CreateJobCommands, bool>
    {
        private readonly IJobRepository _jobRepository;

        public CreateJobHandler(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<bool> Handle(CreateJobCommands request, CancellationToken cancellationToken)
        {
            Job job = new()
            {
                Title = request.Title,
                Description = request.Description
            };

            await _jobRepository.Add(job);
            await _jobRepository.SaveChangesAsync();

            return true;
        }
    }
}
