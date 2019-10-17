using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.DAL.Repositories
{
    public interface ITeachingUnitRepository : IRepository<TeachingUnit>
    {
        Task<IEnumerable<TeachingUnit>> GetTeachingUnitAsync(CancellationToken ct);
        Task<TeachingUnit> GetTeachingUnitAsync(Guid id, CancellationToken ct);
        void CreateTeachingUnit(TeachingUnit TeachingUnitEntity);

    }
}
