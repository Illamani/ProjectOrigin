using System;

namespace ProjectOrigin.Models.Entities
{
    public class Registros
    {
        public int Id { get; set; }
        public long NumeroTarjeta { get; set; }
        public Usuario Usuario { get; set; }
        public Cuenta Cuenta { get; set; }
		public DateTime OperacionTiempo { get; set; }
        public int CodigoOperacion { get; set; }
    }
}
