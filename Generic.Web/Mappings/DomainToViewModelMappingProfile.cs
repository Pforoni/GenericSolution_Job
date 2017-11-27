using AutoMapper;
using Generic.Entities;
using Generic.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Generic.Web.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        public DomainToViewModelMappingProfile()
        {
            //CreateMap<Genero, GeneroViewModel>().ReverseMap();
            CreateMap<Genero, GeneroViewModel>()
               .ForMember(vm => vm.ID, map => map.MapFrom(g => g.ID));
        }
    }
}
