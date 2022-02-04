using MediatR;
using Microservices.Demo.Report.API.CQRS.Commands.Policy.CreatePolicy;
using Microservices.Demo.Report.API.CQRS.Commands.Policy.TerminatePolicy;
using Microservices.Demo.Report.API.CQRS.Queries.FindAllPolicy;
using Microservices.Demo.Report.API.CQRS.Queries.Policy.GetPolicyDetails;
using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Application
{
    public class PolicyApplicationService
    {
        private readonly IMediator _mediator;
        public PolicyApplicationService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<CreatePolicyResult> CreatePolicyAsync(CreatePolicyCommand command)
        {
            var policyResult = await _mediator.Send(command);
            return policyResult;
        }

        public async Task<IEnumerable<PolicyDetailsDto>> GetAllAsync()
        {
            var products = await _mediator.Send(new FindAllPolicyQuery());
            return products;
        }
        public async Task<GetPolicyDetailsQueryResult> GetPolicyDetails(string policyNumber)
        {
            var result = await _mediator.Send(new GetPolicyDetailsQuery { PolicyNumber = policyNumber });
            return result;
        }
        public async Task<TerminatePolicyResult> TerminatePolicy(TerminatePolicyCommand command)
        {
            var result = await _mediator.Send(command);
            return result;
        }
    }
}
