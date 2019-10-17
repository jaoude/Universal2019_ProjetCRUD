using MultiGrain.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.BLL.Services
{
    public interface IProgrammService : IServiceBase
    {
        Task<IEnumerable<ProgrammDto>> GetProgrammAsync(CancellationToken ct);
        Task<ProgrammDto> GetProgrammAsync(Guid id, CancellationToken ct);
        Task<int?> CreateProgrammAsync(CreateProgrammDto CreateProgrammDto, CancellationToken ct);

    }
}
