using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<TeachingUnit> GetCatalog(int id)
        {

            var catalog =  _db.Set<Catalog>().FirstOrDefault(c => c.Id == id);
            var years = catalog.Years;
            var semesters =  _db.Set<Semester>().Where(c => years.Contains(c.Year)).ToList();
            semesters = years.SelectMany(c => c.Semesters).ToList();
            ////var years = await _db.Set<Year>().Select(c => c.Catalogs).ToListAsync(ct);
            //var tu = await _db.Set<TeachingUnit>().Select(c => c.SemesterId).ToListAsync(ct);
            var result = _db.Set<Catalog>().FirstOrDefault(c => c.Id == id).Years
                .SelectMany(c => c.Semesters).SelectMany(c => c.TeachingUnits).ToList();
            return result;
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
