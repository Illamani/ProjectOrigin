using System;

namespace ProjectOrigin.Models
{
	public class Registros
	{
		public int Id { get; set; }
		public int UsuarioId { get; set; }
		public int CuentaId { get; set; }
		public DateTime OperacionTiempo { get; set; }
		public int CodigoOperacion { get; set; }
	}
}
