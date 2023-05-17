using AutoMapper;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models;
using ProjectOrigin.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectOrigin.Services
{
	public class UsuarioService : IUsuarioService
	{
        private readonly IMapper _mapper;
        private readonly IUsuarioRepository _cajeroRepository;
        public UsuarioService(IMapper mapper, IUsuarioRepository cajeroRepository)
		{
			_mapper = mapper;
			_cajeroRepository = cajeroRepository;
		}
		public async Task InsertUsuarios(UsuarioDto input)
        {
            var tarjeta = _mapper.Map<UsuarioDto, Usuario>(input);
			await _cajeroRepository.InsertUsuarios(tarjeta);
        }
		public async Task<UsuarioDto> GetUsuario()
		{
			var tarjeta = await _cajeroRepository.GetUsuario();
			return _mapper.Map<Usuario,UsuarioDto>(tarjeta);
		}
		public async Task<List<UsuarioDto>> GetUsuarios()
		{
			var tarjetaList = await _cajeroRepository.GetUsuarios();
			return _mapper.Map<List<Usuario>, List<UsuarioDto>>(tarjetaList);
		}
		public async Task<EstadoDto> GetUsuarioByUsuarioTarjetaAsync(long input)
		{
			var tarjeta = await _cajeroRepository.GetUsuarioByUsuarioTarjetaAsync(input);
			return _mapper.Map<Estado, EstadoDto>(tarjeta);
		}
		public async Task<EstadoDto> GetAccessByUsuarioAsync(long numeroTarjeta, int PIN)
		{
			var acceso = await _cajeroRepository.GetAccessByUsuarioAsync(numeroTarjeta, PIN);
			return _mapper.Map<Estado, EstadoDto>(acceso);
		}
	}
}
