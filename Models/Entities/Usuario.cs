﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectOrigin.Models.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public bool IsBlocked { get; set; }
        public int Count { get; set; }

        [Range(1000000000000000, 9999999999999999)]
        public long NumeroTarjeta { get; set; }
        public Cuenta Cuenta { get; set; }
        public ICollection<Registros> Registros { get; set; }

        [Range(1000, 9999)]
        public int PIN { get; set; }
        public string NombreUsuario { get; set; }
    }
}
