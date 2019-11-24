using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace server.Utility
{
    public static class AutoMapperExtensions
    {
        private static IMapper _mapper;

        static AutoMapperExtensions()
        {
            _mapper = AutoMapperProfile.Init();
        }

        // Generic Implementation
        public static TDestination MapTo<TDestination>(this object source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public static IQueryable<TDestination> MapTo<TDestination>(this IQueryable source)
        {
            return _mapper.ProjectTo<TDestination>(source);
        }

        public static List<TDestination> MapTo<TDestination>(this List<object> entity)
        {
            return _mapper.Map<List<TDestination>>(entity);
        }


        // For single object
        //        public static User ToModel(this UserDto entity)
        //        {
        //            return _mapper.Map<User>(entity);
        //        }
        //        public static UserDto ToEntity(this User model)
        //        {
        //            return _mapper.Map<UserDto>(model);
        //        }


        // For List of object
        //        public static List<User> ToModel(this List<UserDto> entity)
        //        {
        //            return _mapper.Map<List<UserDto>, List<User>>(entity);
        //        }
        //        public static List<UserDto> ToEntity(this List<User> model)
        //        {
        //            return _mapper.Map<List<User>, List<UserDto>>(model);
        //        }
    }
}
