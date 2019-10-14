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
        IYearRepository Year { get; }
        ITypesRepository Types { get; }
        ITeachingUnitContentRepository TeachingUnitContent { get; }
        ITeachingRepository Teaching { get; }
        ITeacherRepository Teacher { get; }
        ISessionRepository Session { get; }
        ISemesterRepository Semester { get; }
        IRoomRepository Room { get; }
        IRoleeRepository Rolee { get; }
        IProgrammRepository Programm { get; }
        IOutcomeRepository Outcome { get; }
        IModuleRepository Module { get; }
        IKPIRepository KPI { get; }
        IActionPlanRepository ActionPlan { get; }
        IGroupRepository Group { get; }
        IEvaluationTypeRepository EvaluationType { get; }
        IEvaluationRepository Evaluation { get; }
        IDiplomaRepository Diploma { get; }
        IComponentRepository Component { get; }
        ICatalogRepository Catalog { get; }
        IActionPlanRepository ActionPlans { get; }

        Task<int> SaveChangesAsync(CancellationToken ct);

        int SaveChanges();
        
    }
}
