using MultiGrain.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.BLL.Services
{
    public interface ITeachingUnitService : IServiceBase
    {
        Task<IEnumerable<TeachingUnitDto>> GetTeachingUnitAsync(CancellationToken ct);
        Task<TeachingUnitDto> GetTeachingUnitAsync(Guid id, CancellationToken ct);
        Task<int?> CreateTeachingUnitAsync(CreateTeachingUnitDto CreateTeachingUnitDto, CancellationToken ct);

    }
}
