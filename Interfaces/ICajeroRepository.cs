using ProjectOrigin.Models;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICajeroRepository
	{
		Task<Tarjeta> GetTarjeta();
		Task InsertUsuarios(Tarjeta input);
	}
}
