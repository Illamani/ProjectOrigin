namespace ProjectOrigin.Models
{
	public class Cuenta
	{
		public int Id { get; set; }
		public string NombreUsuario { get; set; }
		public double Balance {get; set;}
		public bool IsBlocked { get; set;}
		public Tarjeta Tarjeta { get; set;}
		public long NumeroTarjeta { get; set;}
	}
}
