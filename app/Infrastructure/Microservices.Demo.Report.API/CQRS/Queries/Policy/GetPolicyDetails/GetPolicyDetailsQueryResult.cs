using Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Queries.Policy.GetPolicyDetails
{
    public class GetPolicyDetailsQueryResult
    {
        public PolicyDetailsDto Policy { get; set; }
    }
}
