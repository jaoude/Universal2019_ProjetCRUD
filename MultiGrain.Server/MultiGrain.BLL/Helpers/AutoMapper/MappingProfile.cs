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
        }
    }
}
