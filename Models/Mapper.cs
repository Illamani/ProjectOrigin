using AutoMapper;
using ProjectOrigin.Models.Dto;

namespace ProjectOrigin.Models
{
	public class Mapper : Profile
	{
		public Mapper()
		{
			CreateMap<Usuario, UsuarioDto>();
			CreateMap<UsuarioDto, Usuario>();
			CreateMap<Estado, EstadoDto>();
			CreateMap<EstadoDto, Estado>();
		}
    }
}
