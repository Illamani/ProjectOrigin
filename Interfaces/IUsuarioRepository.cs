using ProjectOrigin.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
    public interface IUsuarioRepository
	{
		Task<Estado> GetAccessByUsuarioAsync(long numeroTarjeta, int PIN);
		Task<Usuario> GetUsuario();
		Task<Estado> GetUsuarioByUsuarioTarjetaAsync(long input);
		Task<List<Usuario>> GetUsuarios();
		Task InsertUsuarios(Usuario input);
	}
}
