using JobApplication.Domain.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobApplication.Domain.Entities;

public class Job
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    //public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public JobStatus JobStatus { get; set; }

}
