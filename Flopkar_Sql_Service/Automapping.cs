using AutoMapper;
using Flopkart_Sql_Repository.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flopkart_Model;

namespace Flopkart_Service
{
    public class Automapping : Profile
    {
        public Automapping()
        {
            CreateMap<SqlProducts, ProductModel>()
                .ForMember(dest => dest.ProductId, src => src.MapFrom(x => x.ProductId))
                .ReverseMap();
        }
    }
}
