using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public  class SessionRepository : Repository<Session>, ISessionRepository
    {
        public SessionRepository(MultiGrainDbContext _db): base(_db)
        {

        }
    }
}

