using ProjectOrigin.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICajeroService
	{
		Task<TarjetaDto> GetUsuario();
		Task<List<TarjetaDto>> GetUsuarios();
		Task InsertUsuarios(TarjetaDto input);
	}
}
