using Microsoft.AspNetCore.Mvc;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectOrigin.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CajeroController : ControllerBase, ICajeroService
	{
		private readonly ICajeroService _cajeroService;
		public CajeroController(ICajeroService cajeroService)
		{
			_cajeroService = cajeroService;
		}
		[HttpGet]
		[Route("GetUsuario")]
		public Task<TarjetaDto> GetUsuario()
		{
			return _cajeroService.GetUsuario();
		}

		[HttpPost]
		[Route("InsertUsuarios")]
		public Task InsertUsuarios(TarjetaDto input)
		{
			return _cajeroService.InsertUsuarios(input);
		}
		[HttpGet]
		[Route("GetUsuarios")]
		public Task<List<TarjetaDto>> GetUsuarios()
		{
			return _cajeroService.GetUsuarios();
		}
	}
}
