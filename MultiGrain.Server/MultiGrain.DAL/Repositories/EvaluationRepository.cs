using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class EvaluationRepository : Repository<Evaluation>, IEvaluationRepository
    {
        public EvaluationRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}