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
    [Route("api/program")]
    [ApiController]
    public class ProgrammController : ControllerBase
    {
        private readonly ILogger<ProgrammController> _logger;
        private readonly IProgrammService _ProgrammService;
        public ProgrammController(ILogger<ProgrammController> logger, IProgrammService ProgrammService)
        {
            _ProgrammService = ProgrammService;
            _logger = logger;
        }


        [HttpGet]
        //[Route("{id}", Name = "GetActionPlan")]
        public async Task<IActionResult> GetActionPlan(CancellationToken ct)
        {
            var Programm = await _ProgrammService.GetProgrammAsync(ct);
            return Ok(Programm);
            //_logger.LogInformation("called GetActionPlan");
            //var action = await _actionService.GetActionPlanAsync(id, ct);
            //return Ok(action);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProgramm([FromBody] CreateProgrammDto Prog, CancellationToken ct)
        {
            _logger.LogInformation("called CreateActionPlan {0}", Prog.ToString());
            var id = await _ProgrammService.CreateProgrammAsync(Prog, ct);
            if (id == null)
                return UnprocessableEntity();
            else
                return CreatedAtRoute("GetProgramm", new { id }, Prog);


        }
    }
}

