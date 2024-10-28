using AutoMapper;
using Prontuario.Aplicacao.Pacientes.Dtos;
using Prontuario.Dominio.Pacientes;

namespace Prontuario.Aplicacao.Mappings
{
    public class EntitiesToDtoMappingProfile : Profile
    {
        public EntitiesToDtoMappingProfile()
        {
            CreateMap<Paciente, PacienteDto>().ReverseMap();
        }

    }
}
