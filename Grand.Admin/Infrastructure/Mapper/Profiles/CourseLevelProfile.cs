﻿using AutoMapper;
using Grand.Domain.Courses;
using Grand.Core.Infrastructure.Mapper;
using Grand.Admin.Models.Courses;

namespace Grand.Admin.Infrastructure.Mapper.Profiles
{
    public class CourseLevelProfile : Profile, IMapperProfile
    {
        public CourseLevelProfile()
        {
            CreateMap<CourseLevel, CourseLevelModel>();
            CreateMap<CourseLevelModel, CourseLevel>()
                .ForMember(dest => dest.Id, mo => mo.Ignore());
        }

        public int Order => 0;
    }
}