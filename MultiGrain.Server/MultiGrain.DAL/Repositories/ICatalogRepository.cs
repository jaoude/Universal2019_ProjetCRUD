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
        List<TeachingUnit> GetCatalog(int id);
        //void CreateCatalog(Catalog CatalogEntity);


    }

}
