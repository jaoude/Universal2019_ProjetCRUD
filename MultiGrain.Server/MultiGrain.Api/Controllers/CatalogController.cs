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
    [Route("api/catalog")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ILogger<CatalogController> _logger;
        private readonly ICatalogService _catalogService;
        public CatalogController(ILogger<CatalogController> logger, ICatalogService CatalogService)
        {
            _catalogService = CatalogService;
            _logger = logger;
        }


        [HttpGet]
        //[Route("{id}", Name = "GetActionPlan")]
        public async Task<IActionResult> GetCatalog(CancellationToken ct)
        {
            var action = await _catalogService.GetCatalogAsync(ct);
            return Ok(action);
            //_logger.LogInformation("called GetActionPlan");
            //var action = await _actionService.GetActionPlanAsync(id, ct);
            //return Ok(action);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCatalog([FromBody] CreateCatalogDto cat, CancellationToken ct)
        {
            // _logger.LogInformation("called CreatePerson {0}", person.ToString());
            var cata = await _catalogService.CreateCatalogAsync(cat, ct);
            if (cata == null)
                return UnprocessableEntity();
            else
                return CreatedAtRoute("GetCatalog", new { cata }, cat);


        }
    }
}

