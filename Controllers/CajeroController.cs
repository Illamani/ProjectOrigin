using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectOrigin.Interfaces;

namespace ProjectOrigin.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CajeroController : ControllerBase, ICajeroService
	{
		[HttpGet]
		[Route("Get")]
		public IActionResult Get()
		{
			return Ok();
		}
	}
}
