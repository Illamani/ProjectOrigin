using ProjectOrigin.Models.Dto;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICuentaService
	{
		Task<BalanceDto> GetBalanceAsync(long inputNumeroCuenta);
		Task<RetiroDto> GetRetiroAsync(double retiroInput, long numeroTarjeta);
		Task InsertDineroACuenta(double insertInput, long numeroTarjeta);
	}
}
