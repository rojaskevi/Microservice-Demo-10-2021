using System;
using System.Collections.Generic;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Microservices.Demo.Report.API.CQRS.Queries.FindAllPolicy
{
    public class FindAllPolicyQuery : IRequest<IEnumerable<PolicyDetailsDto>>
    {
    }
}
