using MultiGrain.DAL.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        
        IInstitutionRepository Institutions { get; }
        IPersonRepository Persons { get; }
        IFileDocumentRepository FileDocuments { get; }
        
        Task<int> SaveChangesAsync(CancellationToken ct);

        int SaveChanges();
        
    }
}
