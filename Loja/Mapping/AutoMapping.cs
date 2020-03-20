using Loja.Models;
using Loja.Models.DTO;
using Loja.Models.Entity;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Loja.Models.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Produto, ProdutoDTO>();
        }

    }
}
