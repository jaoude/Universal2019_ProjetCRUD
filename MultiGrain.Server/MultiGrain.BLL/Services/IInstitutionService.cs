﻿using MultiGrain.BLL.Dtos;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MultiGrain.BLL.Services
{
    public interface IInstitutionService : IServiceBase
    {
        Task UpdateInstitutionAsync(CreateInstitutionDto ins,CancellationToken ct);
        Task<IEnumerable<InstitutionDto>> GetInstitutionAsync(CancellationToken ct);
        Task<InstitutionDto> GetInstitutionAsync(Guid id, CancellationToken ct);
        Task<int?> CreateInstitutionAsync(CreateInstitutionDto CreateInstitutionDto, CancellationToken ct);
        Task<bool> DeleteInstitutionAsync(int id, CancellationToken ct);
    }
}
