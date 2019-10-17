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
    public class TeachingUnitRepository : Repository<TeachingUnit>, ITeachingUnitRepository
    {
        public TeachingUnitRepository(MultiGrainDbContext _db)
            : base(_db)
        {
        }

        public async Task<TeachingUnit> GetTeachingUnitAsync(Guid id, CancellationToken ct)
        {
            return await _db.Set<TeachingUnit>().FirstOrDefaultAsync(ct);
        }

        public async Task<IEnumerable<TeachingUnit>> GetTeachingUnitAsync(CancellationToken ct)
        {
            return await _db.Set<TeachingUnit>().ToListAsync(ct);
        }

        public void CreateTeachingUnit(TeachingUnit TeachingUnitEntity)
        {
            _db.Set<TeachingUnit>().Add(TeachingUnitEntity);
        }
    }
}
