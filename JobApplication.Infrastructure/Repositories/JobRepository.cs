using JobApplication.Application.Interfaces;
using JobApplication.Domain.Entities;
using JobApplication.Infrastructure.Persistence;

namespace JobApplication.Infrastructure.Repositories
{
    public class JobRepository : IJobRepository
    {
        private readonly ApplicationDbContext _context;

        public JobRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Job job)
        {
            await _context.Jobs.AddAsync(job);
        }
        public void Update(Job job)
        {
            _context.Jobs.Update(job);
        }

        public async Task<Job?> GetByIdAsync(int id)
        {
            return await _context.Jobs.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
