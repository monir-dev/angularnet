using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using server.Dtos;
using server.Models;

namespace server.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Users, UserForLoginDto>().ReverseMap();
            CreateMap<Users, UserForRegisterDto>().ReverseMap();
        }


        public static IMapper Init()
        {
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfile()));

            return new Mapper(configuration);
        }
    }
}
