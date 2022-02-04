using Microservices.Demo.Report.API.Infrastructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.Domain.Entities
{
    public class PolicyTerminationResult
    {
        public PolicyVersion TerminalVersion { get; private set; }
        public decimal AmountToReturn { get; private set; }

        public PolicyTerminationResult(PolicyVersion terminalVersion, decimal amountToReturn)
        {
            TerminalVersion = terminalVersion;
            AmountToReturn = amountToReturn;
        }
    }
}
