using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class TeachingUnitContentRepository : Repository<TeachingUnitContent>, ITeachingUnitContentRepository
    {
        public TeachingUnitContentRepository(MultiGrainDbContext _db): base(_db)
        {
        }
    }
}
