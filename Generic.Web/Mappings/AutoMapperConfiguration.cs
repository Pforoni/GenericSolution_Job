using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Generic.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(c =>
            {
                c.AddProfile<DomainToViewModelMappingProfile>();
                //c.AddProfile<ViewModelToDomainMappingProfile>();
            });
        }
    }
}