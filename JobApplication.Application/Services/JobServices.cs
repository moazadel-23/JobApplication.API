using JobApplication.Application.DTOs;
using JobApplication.Application.Interfaces;
using JobApplication.Domain.Entities;
using JobApplication.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication.Application.Services
{
    public class JobServices : IJobServices
    {
        private readonly IJobRepository _jobRepository;

        public JobServices(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<bool> closeJob(int jobId)
        {
            var job = await _jobRepository.GetByIdAsync(jobId);
            if (job == null)
            {
                return false;
            }

            job.JobStatus = JobStatus.closed;
            _jobRepository.Update(job);
            await _jobRepository.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CreateJob(CreateJobDto createJobDto)
        {
            Job job = new()
            {
                Title = createJobDto.Title,
                Description = createJobDto.Description
            };

            await _jobRepository.Add(job);
            await _jobRepository.SaveChangesAsync();

            return true;
        }
    }
}
