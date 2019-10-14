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
        private readonly IPersonService _personService;
        public InstitutionsController(ILogger<InstitutionsController> logger, IPersonService personService)
        {
            _personService = personService;
            _logger = logger;
        }


        [HttpPost]
        public IActionResult Create([FromBody] CreateInstitutionDto institution, CancellationToken ct)
        {
            _logger.LogInformation("called Create{0}", institution.ToString());
            return Ok();
        }
    }
}

