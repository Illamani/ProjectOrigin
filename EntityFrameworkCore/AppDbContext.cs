using Microsoft.EntityFrameworkCore;
using ProjectOrigin.Models.Entities;

namespace ProjectOrigin.EntityFrameworkCore
{
    public class AppDbContext : DbContext
	{

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }

        public DbSet<Usuario> Tarjeta { get; set; }
        public DbSet<Cuenta> Cuenta { get; set;}
        public DbSet<Registros> Registros { get; set; }
    }
}
