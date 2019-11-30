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
    public class ProgrammService : ServiceBase, IProgrammService
    {
        public ProgrammService(IUnitOfWork uow, IAutoMapperService mapper, ILogger<ProgrammService> logger) : base(uow, mapper, logger)
        {
        }

        public async Task<IEnumerable<ProgrammDto>> GetProgrammAsync(CancellationToken ct)
        {
            IEnumerable<Programm> ProgrammEntity = await _uow.Programm.GetProgrammAsync(ct);
            IEnumerable<ProgrammDto> ProgrammDto = _mapper.Mapper.Map<IEnumerable<ProgrammDto>>(ProgrammEntity);
            return ProgrammDto.ToList();
        }

        public async Task<List<ProgrammDto>> GetProgrammsByInstitutionIdAsync(int instId, CancellationToken ct)
        {
            var ProgrammEntity = await _uow.Programm.GetProgrammsByInstitutionIdAsync(instId, ct);
            var ProgrammDto = _mapper.Mapper.Map<List<ProgrammDto>>(ProgrammEntity);
            return ProgrammDto;
        }

        public async Task<ProgrammDto> GetProgrammAsync(Guid id, CancellationToken ct)
        {
            Programm ProgrammEntity = await _uow.Programm.GetProgrammAsync(id, ct);
            ProgrammDto ProgrammDto = _mapper.Mapper.Map<ProgrammDto>(ProgrammEntity);
            return ProgrammDto;
        }

     
        public async Task<int?> CreateProgrammAsync(CreateProgrammDto CreateProgrammDto, CancellationToken ct)
        {
            Programm ProgrammEntity = _mapper.Mapper.Map<Programm>(CreateProgrammDto);
            _uow.Programm.CreateProgramm(ProgrammEntity);

            if (await _uow.SaveChangesAsync(ct) > 0)
                return ProgrammEntity.Id;// personsEntity.Id;
            else
                return null;

        }

        
    }

}
