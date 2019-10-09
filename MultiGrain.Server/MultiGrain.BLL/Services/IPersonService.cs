using MultiGrain.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.BLL.Services
{
    public interface IPersonService : IServiceBase
    {
        Task<IEnumerable<PersonDto>> GetPersonsAsync(CancellationToken ct);
        Task<PersonDto> GetPersonAsync(Guid id, CancellationToken ct);
        Task<Guid> CreatePersonAsync(CreatePersonDto createPerosnDto, CancellationToken ct);
    }
}
