using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class KPIRepository : Repository<KPI>, IKPIRepository
    {
        public KPIRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}