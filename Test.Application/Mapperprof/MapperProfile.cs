using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Application.Dto;
using Test.Domain.Entity;

namespace Test.Application.Mapperprof
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
      CreateMap<User, UserDto>().ReverseMap();
      CreateMap<Item, ItemDto>().ReverseMap();
      CreateMap<User, GetUserDto>().ReverseMap();
        }
    }
}
