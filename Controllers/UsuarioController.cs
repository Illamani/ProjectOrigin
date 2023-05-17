using Microsoft.AspNetCore.Mvc;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models.Dto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ProjectOrigin.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsuarioController : ControllerBase, IUsuarioService
	{
		private readonly IUsuarioService _cajeroService;
		public UsuarioController(IUsuarioService cajeroService)
		{
			_cajeroService = cajeroService;
		}
		[HttpGet]
		[Route("GetUsuario")]
		public Task<UsuarioDto> GetUsuario()
		{
			return _cajeroService.GetUsuario();
		}

		[HttpPost]
		[Route("InsertUsuarios")]
		public Task InsertUsuarios(UsuarioDto input)
		{
			return _cajeroService.InsertUsuarios(input);
		}
		[HttpGet]
		[Route("GetUsuarios")]
		public Task<List<UsuarioDto>> GetUsuarios()
		{
			return _cajeroService.GetUsuarios();
		}

		//Metodos Principales
		[HttpGet]
		[Route("GetUsuarioByUsuarioTarjetaAsync")]
		public Task<EstadoDto> GetUsuarioByUsuarioTarjetaAsync([Range(1000000000000000, 9999999999999999, ErrorMessage = "El campo debe ser un número 16 dígitos.")]  long input)
		{
			return _cajeroService.GetUsuarioByUsuarioTarjetaAsync(input);
		}
		[HttpGet]
		[Route("GetAccessByUsuarioAsync")]
		public Task<EstadoDto> GetAccessByUsuarioAsync(long numeroTarjeta, int PIN)
		{
			return _cajeroService.GetAccessByUsuarioAsync(numeroTarjeta, PIN);
		}
	}
}
