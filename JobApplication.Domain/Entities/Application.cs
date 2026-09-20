using JobApplication.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace JobApplication.Domain.Entities;

public class Application
{
    [Key]
    public int Id { get; set; }

    public string Status { get; set; } = "Pending";

    public DateTime AppliedAt { get; set; } = DateTime.UtcNow;

    public ApplicationStatus applicationStatus { get; set; }
    public DateTime UpdateStatusAt { get; set; }
    public int CandidateId { get; set; }
    public Candidate? Candidate { get; set; }

    public int JobId { get; set; }
    public Job? Job { get; set; }
}
