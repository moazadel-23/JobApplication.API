using JobApplication.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication.Application.DTOs
{
    public class CloseJobDto
    {
        public JobStatus JobStatus { get; set; }
    }
}
