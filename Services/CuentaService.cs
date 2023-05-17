using AutoMapper;
using ProjectOrigin.Interfaces;

namespace ProjectOrigin.Services
{
	public class CuentaService : ICuentaService
	{
		private readonly IMapper _mapper;
		private readonly ICuentaRepository _usuarioRepository;
		public CuentaService(IMapper mapper, ICuentaRepository usuarioRepository)
		{
			_mapper = mapper;
			_usuarioRepository = usuarioRepository;
		}
	}
}
