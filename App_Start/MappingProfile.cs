using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Midly.Dtos;
using Midly.Models;

namespace Midly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<Movie, MovieDto>();

            // Dto to Domain
            Mapper.CreateMap<MovieDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}