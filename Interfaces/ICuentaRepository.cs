using ProjectOrigin.Models;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICuentaRepository
	{
		Task<Balance> GetBalanceAsync(long numeroTarjeta);
		Task<Retiro> GetRetiroAsync(double retiroInput, long numeroTarjeta);
		Task InsertDineroACuenta(double insertInput, long numeroTarjeta);
	}
}
