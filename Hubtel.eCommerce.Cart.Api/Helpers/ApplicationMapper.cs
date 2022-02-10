using AutoMapper;
using Hubtel.eCommerce.Cart.Api.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.eCommerce.Cart.Api.Helpers
{
    public class ApplicationMapper : Profile
    {

        public ApplicationMapper()
        {
            CreateMap<Entities.Cart, CartDto>().ReverseMap();
            CreateMap<Entities.Customer, CustomerDto>().ReverseMap();
            CreateMap<Entities.Item, ItemDto>().ReverseMap();
        }
    }
}
