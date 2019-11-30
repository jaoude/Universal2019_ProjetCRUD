using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.DAL.Repositories
{
    public interface IInstitutionRepository : IRepository<Institution>
    {
        Task<IEnumerable<Institution>> GetInstitutionAsync(CancellationToken ct);
        Task<Institution> GetInstitutionAsync(Guid id, CancellationToken ct);
        Task CreateInstitution(Institution InstitutionEntity);
        Task UpdateInstitutionAsync(Institution ins, CancellationToken ct);
    }
}
