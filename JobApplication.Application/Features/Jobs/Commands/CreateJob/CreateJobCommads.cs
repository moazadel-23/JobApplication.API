using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication.Application.Features.Jobs.Commands.CreateJob
{
    public class CreateJobCommands : IRequest<bool>
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
    }
}
