using Microsoft.EntityFrameworkCore;
using JobApplication.Domain.Entities;
using System.Collections.Generic;
using System.Text;

namespace JobApplication.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Domain.Entities.Application> Applications { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
    }
}
