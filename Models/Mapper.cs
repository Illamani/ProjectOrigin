using AutoMapper;
using ProjectOrigin.Models.Dto;

namespace ProjectOrigin.Models
{
	public class Mapper : Profile
	{
		public Mapper()
		{
			CreateMap<Tarjeta, TarjetaDto>();
		}
    }
}
