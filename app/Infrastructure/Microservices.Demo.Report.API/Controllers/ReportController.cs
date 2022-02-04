using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microservices.Demo.Report.API.Application;
using Microservices.Demo.Report.API.CQRS.Commands.Policy.CreatePolicy;
using Microservices.Demo.Report.API.CQRS.Commands.Policy.TerminatePolicy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Microservices.Demo.Report.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly PolicyApplicationService _policyApplicationService;
        public ReportController(PolicyApplicationService policyApplicationService)
        {
            _policyApplicationService = policyApplicationService;
        }

        // POST 
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreatePolicyCommand command)
        {
            return new JsonResult(await _policyApplicationService.GetAllAsync());
        }
    }
}