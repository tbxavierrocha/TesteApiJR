using ApiDotNet.Application.DTOs;
using ApiDotNet.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Mapping
{
    public class DomainToDtoMapping : Profile
    {
        public DomainToDtoMapping() 
        {
            CreateMap<Person,PersonDTO>();
        }
    }
}
