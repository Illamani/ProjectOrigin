﻿namespace ProjectOrigin.Models
{
	public class Estado
	{
		public bool Ok { get; set; }
		public bool UsuarioBloqueado { get; set; }
		public string Mensaje { get; set; }
		public long? NumeroTarjeta { get; set; }
	}
}