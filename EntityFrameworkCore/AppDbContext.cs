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
		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(e =>
            {
                e.HasOne(x => x.Cuenta).WithOne(x => x.Usuario).HasPrincipalKey<Usuario>(x => x.NumeroTarjeta).HasForeignKey<Cuenta>(x => x.NumeroTarjeta);
                e.HasMany(x => x.Registros).WithOne(x => x.Usuario).HasPrincipalKey(x => x.NumeroTarjeta).HasForeignKey(x => x.NumeroTarjeta);
			});
            modelBuilder.Entity<Cuenta>(e =>
            {
                e.HasOne(x => x.Usuario).WithOne(x => x.Cuenta).HasPrincipalKey<Cuenta>(x => x.NumeroTarjeta).HasForeignKey<Usuario>(x => x.NumeroTarjeta);
				e.HasMany(x => x.Registros).WithOne(x => x.Cuenta).HasPrincipalKey(x => x.NumeroTarjeta).HasForeignKey(x => x.NumeroTarjeta);
			});

        }

	}
}
