using AutoMapper;
using Microsoft.Extensions.Logging;
using MultiGrain.BLL.Dtos;
using MultiGrain.DAL.Entities;
using MultiGrain.DAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using MultiGrain.BLL.Helpers;


namespace MultiGrain.BLL.Services
{
    public class InstitutionService : ServiceBase, IInstitutionService
    {
        public InstitutionService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<InstitutionService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<IEnumerable<InstitutionDto>> GetInstitutionAsync(CancellationToken ct)
        {
            IEnumerable<Institution> InstitutionEntity = await _uow.Institutions.GetInstitutionAsync(ct);
            IEnumerable<InstitutionDto> InstitutionDto = _mapper.Mapper.Map<IEnumerable<InstitutionDto>>(InstitutionEntity);
            return InstitutionDto.ToList();
        }

        public async Task<InstitutionDto> GetInstitutionAsync(Guid id, CancellationToken ct)
        {
            Institution InstitutionEntity = await _uow.Institutions.GetInstitutionAsync(id, ct);
            InstitutionDto InstitutionDto = _mapper.Mapper.Map<InstitutionDto>(InstitutionEntity);
            return InstitutionDto;
        }

        public async Task<int?> CreateInstitutionAsync(CreateInstitutionDto CreateInstitutionDto, CancellationToken ct)
        {
            Institution InstitutionEntity = _mapper.Mapper.Map<Institution>(CreateInstitutionDto);
            _uow.Institutions.CreateInstitution(InstitutionEntity);

            if (await _uow.SaveChangesAsync(ct) > 0)
                return InstitutionEntity.Id;// personsEntity.Id;
            else
                return null;
        }
    }

}
