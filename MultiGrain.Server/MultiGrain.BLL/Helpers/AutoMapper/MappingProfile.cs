using AutoMapper;
using MultiGrain.BLL.Dtos;
using MultiGrain.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiGrain.BLL.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonDto>();
            CreateMap<CreatePersonDto, Person>();

            CreateMap<UploadFileDocumentDto, FileDocument>();

            CreateMap<ActionPlan, ActionPlanDto>();
            CreateMap<CreateActionPlanDto, ActionPlan>();

            CreateMap<Catalog, CatalogDto>();
            CreateMap<CreateCatalogDto, Catalog>();

            CreateMap<Institution, InstitutionDto>();
            CreateMap<CreateInstitutionDto, Institution>();

            CreateMap<Programm, ProgrammDto>();
            CreateMap<CreateProgrammDto, Programm>();

            CreateMap<TeachingUnit,TeachingUnitDto >();
            CreateMap<CreateTeachingUnitDto, TeachingUnit>();
        }
    }
}
