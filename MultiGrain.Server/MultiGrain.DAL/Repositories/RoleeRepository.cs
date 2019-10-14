using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class RoleeRepository : Repository<Rolee>, IRoleeRepository
    {
        public RoleeRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}

