using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class DiplomaRepository : Repository<Diploma>, IDiplomaRepository
    {
        public DiplomaRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}