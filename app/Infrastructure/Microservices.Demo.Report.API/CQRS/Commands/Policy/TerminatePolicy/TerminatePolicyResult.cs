using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Commands.Policy.TerminatePolicy
{
    public class TerminatePolicyResult
    {
        public string PolicyNumber { get; set; }
        public decimal MoneyToReturn { get; set; }
    }
}
