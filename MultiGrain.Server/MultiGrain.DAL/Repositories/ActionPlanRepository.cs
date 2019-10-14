using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
namespace MultiGrain.DAL.Repositories
{
    public class ActionPlanRepository : Repository<ActionPlan>, IActionPlanRepository
    {
        private MultiGrainDbContext _context;

        public ActionPlanRepository(MultiGrainDbContext _db)
            : base(_db)
        {
        }

        public async Task<ActionPlan> GetActionPlanAsync(Guid id, CancellationToken ct)
        {
            return await _db.Set<ActionPlan>().FirstOrDefaultAsync(ct);
        }

        public async Task<IEnumerable<ActionPlan>> GetActionPlanAsync(CancellationToken ct)
        {
            return await _db.Set<ActionPlan>().ToListAsync(ct);
        }

        public void CreateActionPlan(ActionPlan actionPlanEntity)
        {
            _db.Set<ActionPlan>().Add(actionPlanEntity);
        }
    }
}
