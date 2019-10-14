using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class SemesterRepository : Repository<Semester>, ISemesterRepository
    {
        public SemesterRepository(MultiGrainDbContext _db): base(_db)
        {
        }
    }
}
