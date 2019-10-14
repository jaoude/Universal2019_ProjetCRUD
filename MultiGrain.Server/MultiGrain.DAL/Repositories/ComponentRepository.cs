using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class ComponentRepository : Repository<Component>, IComponentRepository
    {
        public ComponentRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}