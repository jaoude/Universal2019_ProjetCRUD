using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Entities;
namespace MultiGrain.DAL.Repositories
{
    public class InstitutionRepository : Repository<Institution>, IInstitutionRepository
    {
      
        public InstitutionRepository(MultiGrainDbContext _db)
            : base(_db)
        {
        }

        public async Task<Institution> GetInstitutionAsync(Guid id, CancellationToken ct)
        {
            return await _db.Set<Institution>().FirstOrDefaultAsync(ct);
        }

        public async Task<IEnumerable<Institution>> GetInstitutionAsync(CancellationToken ct)
        {
            return await _db.Set<Institution>().ToListAsync(ct);
        }

        public async Task CreateInstitution(Institution InstitutionEntity)
        {
            await _db.Set<Institution>().AddAsync(InstitutionEntity);
        }
        public async Task UpdateInstitutionAsync(Institution ins, CancellationToken ct)
        {
            var originalEntity = await _db.Set<Institution>().FirstOrDefaultAsync(c => c.Id == ins.Id); 
            if(originalEntity != null)
            {
                originalEntity.LectureDuration = ins.LectureDuration;
                originalEntity.Mission = ins.Mission;
                originalEntity.Signature = ins.Signature;
                originalEntity.Vision = ins.Vision;
                originalEntity.Title = ins.Title;
            }
        }
    }
}
