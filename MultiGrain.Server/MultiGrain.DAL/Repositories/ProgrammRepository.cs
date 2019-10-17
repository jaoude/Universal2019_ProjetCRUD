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
    public class ProgrammRepository : Repository<Programm>, IProgrammRepository
    {
        

        public ProgrammRepository(MultiGrainDbContext _db)
            : base(_db)
        {
        }

        public async Task<Programm> GetProgrammAsync(Guid id, CancellationToken ct)
        {
            return await _db.Set<Programm>().FirstOrDefaultAsync(ct);
        }

        public async Task<IEnumerable<Programm>> GetProgrammAsync(CancellationToken ct)
        {
            return await _db.Set<Programm>().ToListAsync(ct);
        }

        public void CreateProgramm(Programm ProgrammEntity)
        {
            _db.Set<Programm>().Add(ProgrammEntity);
        }
    }
}
