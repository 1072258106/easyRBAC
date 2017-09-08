﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using EasyRbac.Domain.Entity;
using EasyRbac.Dto.User;
using Microsoft.Extensions.DependencyInjection;

namespace EasyRbac.Dto.Mapper
{
    public static class AutoMapperDependencyInject
    {
        public static void UseDtoAutoMapper(this IServiceCollection serviceCollection)
        {
            var config = new MapperConfiguration(x =>
            {
                x.CreateMap<UserEntity, UserInfoDto>();
                x.CreateMap(typeof(PagingList<>), typeof(PagingList<>));
            });
            var mapper = new AutoMapper.Mapper(config);
            serviceCollection.AddSingleton<IMapper>(mapper);
        }
    }
}
