using ProjectOrigin.Models;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICuentaRepository
	{
		Task<Balance> GetBalanceAsync(long numeroTarjeta);
		Task<Retiro> GetRetiroAsync(long retiroInput, long numeroTarjeta);
	}
}
