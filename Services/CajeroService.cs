using AutoMapper;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models;
using ProjectOrigin.Models.Dto;
using System.Threading.Tasks;

namespace ProjectOrigin.Services
{
	public class CajeroService : ICajeroService
	{
        private readonly IMapper _mapper;
        private readonly ICajeroRepository _cajeroRepository;
        public CajeroService(IMapper mapper, ICajeroRepository cajeroRepository)
		{
			_mapper = mapper;
			_cajeroRepository = cajeroRepository;
		}
		public async Task InsertUsuarios(TarjetaDto input)
        {
            var tarjeta = _mapper.Map<TarjetaDto, Tarjeta>(input);
			await _cajeroRepository.InsertUsuarios(tarjeta);
        }
		public async Task<TarjetaDto> GetUsuario()
		{
			var tarjeta = await _cajeroRepository.GetTarjeta();
			return _mapper.Map<Tarjeta,TarjetaDto>(tarjeta);
		}
	}
}
