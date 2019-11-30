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
    [Route("api/catalogs")]
    [ApiController]
    public class CatalogsController : ControllerBase
    {
        private readonly ILogger<CatalogsController> _logger;
        private readonly ICatalogService _catalogService;
        public CatalogsController(ILogger<CatalogsController> logger,
            ICatalogService catalogService)
        {
            _catalogService = catalogService;
            _logger = logger;
        }


        [HttpGet]
        public async Task<IActionResult> GetCatalogs(CancellationToken ct)
        {
            _logger.LogInformation("called GetCatalogs");
            var personsDto = await _catalogService.GetCatalogAsync(ct);
            return Ok(personsDto);
        }


        [HttpGet]
        [Route("{id}", Name = "GetCatalog")]
        public async Task<IActionResult> GetPerson(int id, CancellationToken ct)
        {
            _logger.LogInformation("called GetPerson");
            var personDto = await _catalogService.GetCatalogAsync(id, ct);
            return Ok(personDto);
        }

        //[HttpPost]
        //public async Task<IActionResult> CreatePerson([FromBody] CreatePersonDto person, CancellationToken ct)
        //{
        //    _logger.LogInformation("called CreatePerson {0}", person.ToString());
        //    var id = await _personService.CreatePersonAsync(person, ct);
        //    if (id == Guid.Empty)
        //        return UnprocessableEntity();
        //    else
        //        return CreatedAtRoute("GetPerson",
        //            new { id = id },
        //            person);
        //}
    }
}

