using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PJDDD.Domain.Entities;
using PJDDD.MVC.ViewsModels;

namespace PJDDD.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(x =>
                {
                    x.CreateMap<Cliente,ClienteViewModel>();
                    x.CreateMap<Produto, ProdutoViewModel>();
                    x.CreateMap<ClienteViewModel, Cliente>();
                    x.CreateMap<ProdutoViewModel, Produto>();
                });
        }
    }
}