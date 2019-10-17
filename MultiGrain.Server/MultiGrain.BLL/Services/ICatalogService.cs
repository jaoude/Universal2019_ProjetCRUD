using MultiGrain.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.BLL.Services
{
    public interface ICatalogService : IServiceBase
    {
        Task<IEnumerable<CatalogDto>> GetCatalogAsync(CancellationToken ct);
        Task<CatalogDto> GetCatalogAsync(Guid id, CancellationToken ct);
        Task<int?> CreateCatalogAsync(CreateCatalogDto CreateCatalognDto, CancellationToken ct);

    }
}
