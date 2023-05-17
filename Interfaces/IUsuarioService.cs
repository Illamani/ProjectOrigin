using ProjectOrigin.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface IUsuarioService
	{
		Task<EstadoDto> GetAccessByUsuarioAsync(long numeroTarjeta, int PIN);
		Task<UsuarioDto> GetUsuario();
		Task<EstadoDto> GetUsuarioByUsuarioTarjetaAsync(long input);
		Task<List<UsuarioDto>> GetUsuarios();
		Task InsertUsuarios(UsuarioDto input);
	}
}
