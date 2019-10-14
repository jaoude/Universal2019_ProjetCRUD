using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.DAL.Repositories
{
    public class GroupRepository : Repository<Group>, IGroupRepository
    {
        public GroupRepository(MultiGrainDbContext _db) : base(_db)
        {

        }
    }
}