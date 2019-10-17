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

        public IYearRepository Year => _serviceProvider.GetService<IYearRepository>();

        public ITypesRepository Types => _serviceProvider.GetService<ITypesRepository>();

        public ITeachingUnitContentRepository TeachingUnitContent  => _serviceProvider.GetService<ITeachingUnitContentRepository>();
        public ITeachingUnitRepository TeachingUnit => _serviceProvider.GetService<ITeachingUnitRepository>();
        public ITeachingRepository Teaching => _serviceProvider.GetService<ITeachingRepository>();
        public ITeacherRepository Teacher => _serviceProvider.GetService<ITeacherRepository>();

        public ISessionRepository Session => _serviceProvider.GetService<ISessionRepository>();

        public ISemesterRepository Semester => _serviceProvider.GetService<ISemesterRepository>();

        public IRoomRepository Room => _serviceProvider.GetService<IRoomRepository>();

        public IRoleeRepository Rolee => _serviceProvider.GetService<IRoleeRepository>();

        public IProgrammRepository Programm => _serviceProvider.GetService<IProgrammRepository>();

        public IOutcomeRepository Outcome => _serviceProvider.GetService<IOutcomeRepository>();

        public IModuleRepository Module => _serviceProvider.GetService<IModuleRepository>();

        public IKPIRepository KPI => _serviceProvider.GetService<IKPIRepository>();

        public IActionPlanRepository ActionPlan => _serviceProvider.GetService<IActionPlanRepository>();

        public IGroupRepository Group => _serviceProvider.GetService<IGroupRepository>();

        public IEvaluationTypeRepository EvaluationType => _serviceProvider.GetService<IEvaluationTypeRepository>();

        public IEvaluationRepository Evaluation => _serviceProvider.GetService<IEvaluationRepository>();

        public IDiplomaRepository Diploma => _serviceProvider.GetService<IDiplomaRepository>();

        public IComponentRepository Component => _serviceProvider.GetService<IComponentRepository>();

        public ICatalogRepository Catalog => _serviceProvider.GetService<ICatalogRepository>();

        public IActionPlanRepository ActionPlans => _serviceProvider.GetService<IActionPlanRepository>();

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
