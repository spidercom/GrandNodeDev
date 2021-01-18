﻿using AutoMapper;
using Grand.Domain.Customers;
using Grand.Core.Infrastructure.Mapper;
using Grand.Admin.Models.Customers;

namespace Grand.Admin.Infrastructure.Mapper.Profiles
{
    public class CustomerActionTypeProfile : Profile, IMapperProfile
    {
        public CustomerActionTypeProfile()
        {
            CreateMap<CustomerActionTypeModel, CustomerActionType>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.SystemKeyword, mo => mo.Ignore());
            CreateMap<CustomerActionType, CustomerActionTypeModel>();
        }

        public int Order => 0;
    }
}