using AutoMapper;
using ClienteAPI.Application.DTOs;
using ClienteAPI.Domain.Models;

namespace ClienteAPI.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile() 
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
        }
    }
}
