using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.DAL.Repositories
{
    public interface IProgrammRepository : IRepository<Programm>
    {
        Task<IEnumerable<Programm>> GetProgrammAsync(CancellationToken ct);
        Task<Programm> GetProgrammAsync(Guid id, CancellationToken ct);
        void CreateProgramm(Programm ProgrammEntity);
        Task<List<Programm>> GetProgrammsByInstitutionIdAsync  (int instId, CancellationToken ct);
    }
}
