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
    public class TeachingUnitService : ServiceBase, ITeachingUnitService
    {
        public TeachingUnitService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<TeachingUnitService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<IEnumerable<TeachingUnitDto>> GetTeachingUnitAsync(CancellationToken ct)
        {
            IEnumerable<TeachingUnit> TeachingUnitEntity = await _uow.TeachingUnit.GetTeachingUnitAsync(ct);
            IEnumerable<TeachingUnitDto> TeachingUnitDto = _mapper.Mapper.Map<IEnumerable<TeachingUnitDto>>(TeachingUnitEntity);
            return TeachingUnitDto.ToList();
        }

        public async Task<TeachingUnitDto> GetTeachingUnitAsync(Guid id, CancellationToken ct)
        {
            TeachingUnit TeachingUnitEntity = await _uow.TeachingUnit.GetTeachingUnitAsync(id, ct);
            TeachingUnitDto TeachingUnitDto = _mapper.Mapper.Map<TeachingUnitDto>(TeachingUnitEntity);
            return TeachingUnitDto;
        }

        public async Task<int?> CreateTeachingUnitAsync(CreateTeachingUnitDto CreateTeachingUnitDto, CancellationToken ct)
        {
            TeachingUnit TeachingUnitEntity = _mapper.Mapper.Map<TeachingUnit>(CreateTeachingUnitDto);
            _uow.TeachingUnit.CreateTeachingUnit(TeachingUnitEntity);

            if (await _uow.SaveChangesAsync(ct) > 0)
                return TeachingUnitEntity.Id;
            else
                return null;
        }
    }

}
