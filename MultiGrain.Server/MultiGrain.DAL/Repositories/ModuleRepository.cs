using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class ModuleRepository : Repository<Module>, IModuleRepository
    {
        public ModuleRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}