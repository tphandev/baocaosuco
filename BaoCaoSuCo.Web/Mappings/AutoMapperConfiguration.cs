using AutoMapper;
using BaoCaoSuCo.Model.Models;
using BaoCaoSuCo.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaoCaoSuCo.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<SuCo, SuCoViewModel>();
                cfg.CreateMap<DonVi, DonViViewModel>();
               
            });
        }
    }
}