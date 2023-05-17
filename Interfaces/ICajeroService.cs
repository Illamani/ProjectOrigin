using ProjectOrigin.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICajeroService
	{
		Task<EstadoDto> GetAccessByUsuarioAsync(long numeroTarjeta, int PIN);
		Task<TarjetaDto> GetUsuario();
		Task<EstadoDto> GetUsuarioByUsuarioTarjetaAsync(long input);
		Task<List<TarjetaDto>> GetUsuarios();
		Task InsertUsuarios(TarjetaDto input);
	}
}
