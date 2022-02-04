using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Demo.Report.API.CQRS.Queries.Infrastructure.Dtos.Policy
{
    public class PolicyDetailsDto
    {
        public string Number { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string PolicyHolder { get; set; }
        public decimal TotalPremium { get; set; }
        public string ProductCode { get; set; }
        public string AccountNumber { get; set; }

        public List<string> Covers { get; set; }

        public int PolicyStatusId { get; set; }
        public DateTime? CreationDate { get; set; }
        public string AgentLogin { get; set; }
    }
}
