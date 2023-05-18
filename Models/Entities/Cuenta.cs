using System;
using System.Collections.Generic;

namespace ProjectOrigin.Models.Entities
{
    public class Cuenta
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public double Balance { get; set; }
        public bool IsBlocked { get; set; }
        public Usuario Usuario { get; set;}
		public ICollection<Registros> Registros { get; set; }

		public long NumeroTarjeta { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
