using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class ProgrammRepository : Repository<Programm>, IProgrammRepository
    {
        public ProgrammRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}
