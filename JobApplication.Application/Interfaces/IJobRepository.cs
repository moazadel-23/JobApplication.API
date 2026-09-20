using JobApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication.Application.Interfaces
{
    public interface IJobRepository
    {
        void Update(Job job);
        Task<Job?> GetByIdAsync(int id);
        Task SaveChangesAsync();
    }
}
