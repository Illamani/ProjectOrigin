using AutoMapper;
using ProjectOrigin.Models.Dto;
using ProjectOrigin.Models.Entities;

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

			CreateMap<Balance, BalanceDto>();
			CreateMap<BalanceDto, BalanceDto>();

			CreateMap<Retiro, RetiroDto>();
			CreateMap<RetiroDto, Retiro>();
		}
    }
}
