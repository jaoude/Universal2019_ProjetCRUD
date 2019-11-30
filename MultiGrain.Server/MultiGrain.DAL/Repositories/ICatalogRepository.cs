using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.DAL.Repositories
{
    public interface ICatalogRepository : IRepository<Catalog>
    {
        Task<IEnumerable<Catalog>> GetCatalogAsync(CancellationToken ct);
        Task<Catalog> GetCatalogAsync(int id, CancellationToken ct);
        //void CreateCatalog(Catalog CatalogEntity);


    }
}
