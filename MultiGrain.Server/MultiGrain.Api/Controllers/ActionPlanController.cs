using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.BLL.Services;
using MultiGrain.DAL.Repositories;
using MultiGrain.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.Api.Controllers
{
    [Route("api/action")]
    [ApiController]
    public class ActionPlanController : ControllerBase
    {
        private readonly ILogger<ActionPlanController> _logger;
        private readonly IActionPlanService _actionService;
        public ActionPlanController(ILogger<ActionPlanController> logger, IActionPlanService ActionPlanService)
        {
            _actionService = ActionPlanService;
            _logger = logger;
        }


        [HttpGet]
        [Route("{id}", Name = "GetActionPlan")]
        public async Task<IActionResult> GetActionPlan(Guid id, CancellationToken ct)
        {
            _logger.LogInformation("called GetActionPlan");
            var action = await _actionService.GetActionPlanAsync(id, ct);
            return Ok(action);
        }

        [HttpPost]
        public async Task<IActionResult> CreateActionPlan([FromBody] CreateActionPlanDto act, CancellationToken ct)
        {
            _logger.LogInformation("called CreateActionPlan {0}", act.ToString());
            var id = await _actionService.CreateActionPlanAsync(act, ct);
            if (id == Guid.Empty)
                return UnprocessableEntity();
            else
                return CreatedAtRoute("GetActionPlan",new { id = id },act);
        }
    }
}

