using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JobApplication.Domain.Entities;

public class Candidate
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string? CVUrl { get; set; }

}
