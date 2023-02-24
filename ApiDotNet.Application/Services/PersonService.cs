using ApiDotNet.Application.Services.Interfaces;
using ApiDotNet.Application.DTOs;
using ApiDotNet.Domain.Repositories;
using AutoMapper;
using ApiDotNet.Application.DTOs.Validations;
using ApiDotNet.Domain.Entities;

namespace ApiDotNet.Application.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepositorie;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepositorie, IMapper mapper) 
        {
            _personRepositorie = personRepositorie;
            _mapper = mapper;        
        }

        public async Task<ResultService<PersonDTO>> CreateAsync(PersonDTO personDTO)
        {
            if (personDTO == null)
                return ResultService.Fail<PersonDTO>("Objeto deve ser informado!");

            var result = new PersonDTOValidator().Validate(personDTO);
            if (!result.IsValid)
                return ResultService.RequestError<PersonDTO>("Problemas de validade!", result);

            var person = _mapper.Map<Person>(personDTO);
            var data = await _personRepositorie.CreateAsync(person);
            return ResultService.Ok<PersonDTO>(_mapper.Map<PersonDTO>(data));

        }
    }
}

//O que é uma DTO?
//O que é uma entidade?
