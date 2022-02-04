using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Commands.Policy.TerminatePolicy
{
    public class TerminatePolicyCommand : IRequest<TerminatePolicyResult>
    {
        public string PolicyNumber { get; set; }
        public DateTime TerminationDate { get; set; }
    }
}
