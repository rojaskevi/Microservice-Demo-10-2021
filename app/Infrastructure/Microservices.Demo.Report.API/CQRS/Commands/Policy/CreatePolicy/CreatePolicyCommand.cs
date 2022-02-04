using MediatR;
using Microservices.Demo.Report.API.CQRS.Commands.Infrastructure.Dtos.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Commands.Policy.CreatePolicy
{
    public class CreatePolicyCommand: IRequest<CreatePolicyResult>
    {
        public string OfferNumber { get; set; }
        public PersonDto PolicyHolder { get; set; }
        public AddressDto PolicyHolderAddress { get; set; }
    }
}
