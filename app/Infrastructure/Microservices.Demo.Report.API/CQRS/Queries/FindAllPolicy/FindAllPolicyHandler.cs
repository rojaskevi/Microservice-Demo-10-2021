using MediatR;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy;
using Microservices.Demo.Report.API.Infrastructure.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Queries.FindAllPolicy
{
    public class FindAllPolicyHandler
    {
        private readonly IPolicyRepository _policyRepository;
        public async Task<IEnumerable<PolicyDetailsDto>> Handle(FindAllPolicyQuery request, CancellationToken cancellationToken)
        {
            var result = await _policyRepository.FindAllActive();

            return result.Select(p => new PolicyDetailsDto
            {
                Number = p.Number,
                ProductCode = p.ProductCode,
                PolicyStatusId = p.PolicyStatusId,
                CreationDate = p.CreationDate,
                AgentLogin = p.AgentLogin
            }).ToList();
        }
    }
}
