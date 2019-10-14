using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class EvaluationTypeRepository : Repository<EvaluationType>, IEvaluationTypeRepository
    {
        public EvaluationTypeRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}