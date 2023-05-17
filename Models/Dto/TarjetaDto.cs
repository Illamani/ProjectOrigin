using System.ComponentModel.DataAnnotations;

namespace ProjectOrigin.Models.Dto
{
	public class TarjetaDto
	{
		public int Id { get; set; }
		public bool IsBlocked { get; set; }
		public int Count { get; set; }
		[RegularExpression("^[0-9]*$", ErrorMessage = "Solo se permiten números.")]
		[MaxLength(16)]
		[MinLength(16)]
		public string NumeroTarjeta { get; set; }
		[RegularExpression("^[0-9]*$", ErrorMessage = "Solo se permiten números.")]
		[MaxLength(4)]
		[MinLength(4)]
		public string PIN { get; set; }
		public string NombreUsuario { get; set; }
	}
}
