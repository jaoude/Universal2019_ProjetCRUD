using MultiGrain.BLL.Dtos;
using MultiGrain.BLL.Dtos.Result;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.BLL.Services
{
    public interface ICatalogService : IServiceBase
    {
        Task<IEnumerable<Catalog>> GetCatalogAsync(CancellationToken ct);
        List<FullTeachingUnitDto> GetCatalog(int id);
        //Task<int?> CreateCatalogAsync(CreateCatalogDto CreateCatalognDto, CancellationToken ct);

    }
}
