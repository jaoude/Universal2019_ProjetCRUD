using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.BLL.Services;
using MultiGrain.DAL.Entities;
using MultiGrain.DAL.Repositories;
using MultiGrain.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.Api.Controllers
{
    [Route("api/teachingunit")]
    [ApiController]
    public class TeachingUnitsController : ControllerBase
    {
        private readonly ILogger<TeachingUnitsController> _logger;
        private readonly ITeachingUnitService _TeachingUnitService;
        public TeachingUnitsController(ILogger<TeachingUnitsController> logger, ITeachingUnitService TeachingUnitService)
        {
            _TeachingUnitService = TeachingUnitService;
            _logger = logger;
        }


        [HttpGet]
        //[Route("{id}", Name = "GetActionPlan")]
        public async Task<IActionResult> GetTeachingUnitPlan(CancellationToken ct)
        {
            var action = await _TeachingUnitService.GetTeachingUnitAsync(ct);
            return Ok(action);
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateTeachingUnit([FromBody] CreateTeachingUnitDto act, CancellationToken ct)
        {
            _logger.LogInformation("called CreateActionPlan {0}", act.ToString());
            var id = await _TeachingUnitService.CreateTeachingUnitAsync(act, ct);
            if (id == null)
                return UnprocessableEntity();
            else
                return CreatedAtRoute("GetTeachingUnit", new { id }, act);


        }
    }
}

