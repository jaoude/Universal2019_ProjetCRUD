using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.DAL.Repositories
{
    public interface IActionPlanRepository : IRepository<ActionPlan>
    {
        Task<IEnumerable<ActionPlan>> GetActionPlanAsync(CancellationToken ct);
        Task<ActionPlan> GetActionPlanAsync(Guid id, CancellationToken ct);
        void CreateActionPlan(ActionPlan actionplanEntity);

    }
}
