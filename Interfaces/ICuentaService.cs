using ProjectOrigin.Models.Dto;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICuentaService
	{
		Task<BalanceDto> GetBalanceAsync(long inputNumeroCuenta);
		Task<RetiroDto> GetRetiroAsync(long retiroInput, long numeroTarjeta);
	}
}
