using MultiGrain.DAL.DBContext;
using MultiGrain.DAL.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MultiGrain.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MultiGrainDbContext _db;
        private readonly IServiceProvider _serviceProvider;

        public UnitOfWork(MultiGrainDbContext db,
            IServiceProvider serviceProvider)
        {
            _db = db;
            _serviceProvider = serviceProvider;
        }

       
        public IInstitutionRepository Institutions => _serviceProvider.GetService<IInstitutionRepository>();
        public IPersonRepository Persons => _serviceProvider.GetService<IPersonRepository>();
        public IFileDocumentRepository FileDocuments => _serviceProvider.GetService<IFileDocumentRepository>();

        public async Task<int> SaveChangesAsync(CancellationToken ct)
        {
            return await _db.SaveChangesAsync(ct);
        }

        public int SaveChanges()
        {
            return _db.SaveChanges();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}
