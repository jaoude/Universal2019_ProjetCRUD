using MultiGrain.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.BLL.Services
{
    public interface IActionPlanService : IServiceBase
    {
        Task<IEnumerable<ActionPlanDto>> GetActionPlanAsync(CancellationToken ct);
        Task<ActionPlanDto> GetActionPlanAsync(Guid id, CancellationToken ct);
        Task<int?> CreateActionPlanAsync(CreateActionPlanDto CreateActionPlanDto, CancellationToken ct);

    }
}
