using AutoMapper;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.DAL.Entities;
using MultiGrain.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using MultiGrain.BLL.Helpers;


namespace MultiGrain.BLL.Services
{
    public class ActionPlanService : ServiceBase, IActionPlanService
    {
        public ActionPlanService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<PersonService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<IEnumerable<ActionPlanDto>> GetActionPlanAsync(CancellationToken ct)
        {
            IEnumerable<ActionPlan> ActionPlanEntity = await _uow.ActionPlan.GetActionPlanAsync(ct);
            IEnumerable<ActionPlanDto> ActionPlanDto = _mapper.Mapper.Map<IEnumerable<ActionPlanDto>>(ActionPlanEntity);
            return ActionPlanDto.ToList();
        }

        public async Task<ActionPlanDto> GetActionPlanAsync(Guid id, CancellationToken ct)
        {
            ActionPlan ActionPlanEntity = await _uow.ActionPlan.GetActionPlanAsync(id, ct);
            ActionPlanDto ActionPlanDto = _mapper.Mapper.Map<ActionPlanDto>(ActionPlanEntity);
            return ActionPlanDto;
        }

        public async Task<int?> CreateActionPlanAsync(CreateActionPlanDto CreateActionPlanDto, CancellationToken ct)
        {
            ActionPlan ActionPlanEntity = _mapper.Mapper.Map<ActionPlan>(CreateActionPlanDto);
            _uow.ActionPlan.CreateActionPlan(ActionPlanEntity);

            if (await _uow.SaveChangesAsync(ct) > 0)
                return ActionPlanEntity.Id;// personsEntity.Id;
            else
                return null;
        }
    }

}
