using System;

namespace ProjectOrigin.Models.Dto
{
	public class BalanceDto
	{
		public long NumeroTarjeta { get; set; }
		public DateTime FechaVencimiento { get; set; }
		public double BalanceTotal { get; set; }
	}
}
