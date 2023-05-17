using ProjectOrigin.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICajeroRepository
	{
		Task<Estado> GetAccessByUsuarioAsync(long numeroTarjeta, int PIN);
		Task<Tarjeta> GetUsuario();
		Task<Estado> GetUsuarioByUsuarioTarjetaAsync(long input);
		Task<List<Tarjeta>> GetUsuarios();
		Task InsertUsuarios(Tarjeta input);
	}
}
