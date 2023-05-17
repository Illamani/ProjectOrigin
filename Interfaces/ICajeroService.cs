using ProjectOrigin.Models.Dto;
using System.Threading.Tasks;

namespace ProjectOrigin.Interfaces
{
	public interface ICajeroService
	{
		Task<TarjetaDto> GetUsuario();
		Task InsertUsuarios(TarjetaDto input);
	}
}
