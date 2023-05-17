using Microsoft.AspNetCore.Mvc;
using ProjectOrigin.Interfaces;
using ProjectOrigin.Models.Dto;
using System.Threading.Tasks;

namespace ProjectOrigin.Controllers
{
	public class CuentaController : ControllerBase, ICuentaService
	{
        private readonly ICuentaService _cuentaService;
        public CuentaController(ICuentaService cuentaService)
        {
            _cuentaService = cuentaService;
        }
		[HttpGet]
		[Route("GetPrueba")]
		public IActionResult GetUsuario()
		{
			return Ok();
		}
	}
}
