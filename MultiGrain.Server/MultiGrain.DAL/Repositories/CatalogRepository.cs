using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Entities
{
    public class CatalogRepository : Repository<Catalog>, ICatalogRepository
    {
        public CatalogRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}