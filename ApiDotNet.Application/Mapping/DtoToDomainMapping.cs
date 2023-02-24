using ApiDotNet.Application.DTOs;
using AutoMapper;
using ApiDotNet.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Application.Mapping
{
    internal class DtoToDomainMapping : Profile
    {
        public DtoToDomainMapping() 
        {
            CreateMap<PersonDTO, PersonDTO>();        
        }
    }
}
