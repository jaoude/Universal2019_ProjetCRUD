using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.BLL.Helpers;
using MultiGrain.BLL.Services;
using MultiGrain.DAL.DBContext;
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
    [Route("api/institutions")]
    [ApiController]
    public class InstitutionsController : ControllerBase
    {
        private readonly ILogger<InstitutionsController> _logger;
        private readonly IInstitutionService _instituService;
        private readonly MultiGrainDbContext _context;
        private readonly IAutoMapperService _mapper;
        public InstitutionsController(ILogger<InstitutionsController> logger, IInstitutionService institutionService, IAutoMapperService mapper)
        {
            _instituService = institutionService;
            _logger = logger;
            _mapper = mapper;
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
                return Ok();
        }
       
        [HttpPut("{id}")]
        public async Task<IActionResult> CreateInstitution([FromBody] CreateInstitutionDto ins, int id, CancellationToken ct)
        {
                if (id != ins.id)
                {
                    return BadRequest();
                }
            else
            {
               await _instituService.UpdateInstitutionAsync(ins, ct);
            }
            return NoContent();
            //    Institution inst = _mapper.Mapper.Map<Institution>(ins);
            //// _context.Institutions.Update(inst);
            //try
            //{
            //    _context.Entry<Institution>(inst).State = EntityState.Modified;
            //}
            //catch(Exception e)
            //{
                
            //};
            //    try
            //    {
            //        await _context.SaveChangesAsync();
            //    }
            //    catch (DbUpdateConcurrencyException)
            //    {
            //        if (!_context.Institutions.Any(c=> c.Id == id))
            //        {
            //            return NotFound();
            //        }
            //        else
            //        {
            //            throw;
            //        }
            //    }

            //    return NoContent();
            }
        }
    }



