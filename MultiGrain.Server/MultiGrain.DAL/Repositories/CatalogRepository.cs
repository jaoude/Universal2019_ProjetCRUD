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
    public class CatalogRepository : Repository<Catalog>, ICatalogRepository
    {
        private MultiGrainDbContext _context;

        public CatalogRepository(MultiGrainDbContext _db)
            : base(_db)
        {
        }

        public async Task<Catalog> GetCatalogAsync(int id, CancellationToken ct)
        {
            return await _db.Set<Catalog>()
                .Include("Year")
                .Include("Semester")
                .Include("TeachingUnit")
                .FirstOrDefaultAsync(c => c.Id == id, ct);
        }

        public async Task<IEnumerable<Catalog>> GetCatalogAsync(CancellationToken ct)
        {
            return await _db.Set<Catalog>().ToListAsync(ct);
        }

        //public void CreateCatalog(Catalog CatalogEntity)
        //{
        //    _db.Set<Catalog>().Add(CatalogEntity);
        //}
    }
}
