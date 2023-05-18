using AutoMapper;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models;
using ProjectOrigin.Models.Dto;
using System.Threading.Tasks;

namespace ProjectOrigin.Services
{
	public class CuentaService : ICuentaService
	{
		private readonly IMapper _mapper;
		private readonly ICuentaRepository _cuentaRepository;
		public CuentaService(IMapper mapper, ICuentaRepository cuentaRepository)
		{
			_mapper = mapper;
			_cuentaRepository = cuentaRepository;
		}
		public async Task<BalanceDto> GetBalanceAsync(long inputNumeroCuenta)
		{
			var balance = await _cuentaRepository.GetBalanceAsync(inputNumeroCuenta);
			return _mapper.Map<Balance, BalanceDto>(balance);
		}
		public async Task<RetiroDto> GetRetiroAsync(long retiroInput, long numeroTarjeta)
		{
			var retiro = await _cuentaRepository.GetRetiroAsync(retiroInput, numeroTarjeta);
			return _mapper.Map<Retiro, RetiroDto>(retiro);
		}
	}
}
