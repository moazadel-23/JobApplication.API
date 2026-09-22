using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobApplication.Application.Features.Jobs.Commands.CloseJob
{
    public class CloseJobCommands : IRequest<bool>
    {
        public int Id { get; set; }
        public CloseJobCommands(int id)
        {
            Id = id;
        }
    }
}
