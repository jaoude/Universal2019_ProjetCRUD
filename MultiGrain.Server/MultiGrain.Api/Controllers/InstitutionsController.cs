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
    [Route("api/institutions")]
    [ApiController]
    public class InstitutionsController : ControllerBase
    {
        private readonly ILogger<InstitutionsController> _logger;
        private readonly IInstitutionService _instituService;
        public InstitutionsController(ILogger<InstitutionsController> logger, IInstitutionService InstitutionService)
        {
            _instituService = InstitutionService;
            _logger = logger;
        }

        [HttpDelete("{id}")]
      
        public async Task<IActionResult> DeleteInstitution(int id, CancellationToken ct)
        {
            var action = await _instituService.DeleteInstitutionAsync(id, ct);
            return Ok(action);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetInstitution(CancellationToken ct)
        {
            var action = await _instituService.GetInstitutionAsync(ct);
            return Ok(action);
        }

        [HttpGet]
        public async Task<IActionResult> GetInstitutions(CancellationToken ct)
        {
            var action = await _instituService.GetInstitutionAsync(ct);
            return Ok(action);
        }


        [HttpPost]
        public async Task<IActionResult> CreateInstitution([FromBody] CreateInstitutionDto ins, CancellationToken ct)
        {
            // _logger.LogInformation("called CreateInstitution {0}", person.ToString());
            var insti = await _instituService.CreateInstitutionAsync(ins, ct);
            if (insti == null)
                return UnprocessableEntity();
            else
                return CreatedAtRoute("GetInstitution", new { insti }, ins);
        }
    }
}


