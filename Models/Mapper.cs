using AutoMapper;
using ProjectOrigin.Models.Dto;

namespace ProjectOrigin.Models
{
	public class Mapper : Profile
	{
		public Mapper()
		{
			CreateMap<Tarjeta, TarjetaDto>();
			CreateMap<TarjetaDto, Tarjeta>();
			CreateMap<Estado, EstadoDto>();
			CreateMap<EstadoDto, Estado>();
		}
    }
}
