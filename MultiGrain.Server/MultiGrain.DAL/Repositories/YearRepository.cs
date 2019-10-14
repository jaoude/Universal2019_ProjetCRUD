using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class YearRepository : Repository<Year>, IYearRepository
    {
        public YearRepository(MultiGrainDbContext _db): base(_db)
        {
        }
    }
}

